using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StrandSpawner : MonoBehaviour
{
    public List<List<GameObject>> dividedStrands = new List<List<GameObject>>();

    [SerializeField]
    GameObject adeine;
    [SerializeField]
    GameObject thymine;
    [SerializeField]
    GameObject cytosine;
    [SerializeField]
    GameObject guanine;
    [SerializeField]
    GameObject slotFill;

    TextMeshProUGUI poinstScored;

    GameObject spawnableObject;
    GameObject SpawnableObjectTwo;

    int frameCount;
    int strandCount;
    public bool end;

    // Start is called before the first frame update
    void Start()
    {
        end = false;
        //creates the list of adeine and empty strand combination and adds it to the dividedStrands list
        List<GameObject> AE = new List<GameObject>();
        AE.Add(adeine);
        AE.Add(slotFill);
        dividedStrands.Add(AE);

        //creates the list of adeine and empty strand combination and adds it to the dividedStrands list
        List<GameObject> EA = new List<GameObject>();
        EA.Add(slotFill);
        EA.Add(adeine);
        dividedStrands.Add(EA);

        //creates the list of thymine and empty strand combination and adds it to the dividedStrands list
        List<GameObject> TE = new List<GameObject>();
        TE.Add(thymine);
        TE.Add(slotFill);
        dividedStrands.Add(TE);

        //creates the list of thymine and empty strand combination and adds it to the dividedStrands list
        List<GameObject> ET = new List<GameObject>();
        ET.Add(slotFill);
        ET.Add(thymine);
        dividedStrands.Add(ET);

        //creates the list of cytosine and empty strand combination and adds it to the dividedStrands list
        List<GameObject> CE = new List<GameObject>();
        CE.Add(cytosine);
        CE.Add(slotFill);
        dividedStrands.Add(CE);

        //creates the list of cytosine and empty strand combination and adds it to the dividedStrands list
        List<GameObject> EC = new List<GameObject>();
        EC.Add(slotFill);
        EC.Add(cytosine);
        dividedStrands.Add(EC);

        //creates the list of guanine and empty strand combination and adds it to the dividedStrands list
        List<GameObject> GE = new List<GameObject>();
        GE.Add(guanine);
        GE.Add(slotFill);
        dividedStrands.Add(GE);

        //creates the list of guanine and empty strand combination and adds it to the dividedStrands list
        List<GameObject> EG = new List<GameObject>();
        EG.Add(slotFill);
        EG.Add(guanine);
        dividedStrands.Add(EG);

        frameCount = 0;
        strandCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //return back to 30
       if(frameCount==60)
       {
        //if less than 20 strands have been spawned keeps spawning strand combinations at random
        if(strandCount<20)
        {
            SpawnStrandDivide(transform.position, dividedStrands[Random.Range(0, dividedStrands.Count)]);
        }
        frameCount=0;
        strandCount++;
       } 
       else
       {
        //increases frame count
        frameCount++;
       }

        //when the strand count equals 22 destroys the strand spawner and the strand collider
       if(strandCount == 22) 
       {
        GameObject.FindWithTag("StrandSpawner").GetComponent<StrandSpawner>().end = true;
        Destroy(GameObject.FindWithTag("StrandSpawner"), 4);
        Destroy(GameObject.FindWithTag("StrandCollider"), 4);
        Destroy(GameObject.FindWithTag("StrandSpawnCanvas"), 4);
       }
    }

    public void SpawnStrandDivide(Vector3 spawnPosition, List<GameObject> chosenStrands)
    {
        //positions to spawn both matching dna strand pairs
        Vector3 spawnPositionOne = new Vector3(spawnPosition.x+0.1f, spawnPosition.y, spawnPosition.z);
        Vector3 spawnPositionTwo = new Vector3(spawnPosition.x-0.1f, spawnPosition.y, spawnPosition.z);
        //object that will instantiate the chosen dna strand pair
        spawnableObject = Instantiate(chosenStrands[0], spawnPositionOne, Quaternion.identity);
        SpawnableObjectTwo = Instantiate(chosenStrands[1], spawnPositionTwo, Quaternion.identity);
    }

}
