using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    GameObject spawnableObject;
    GameObject SpawnableObjectTwo;

    int frameCount;
    int strandCount;

    // Start is called before the first frame update
    void Start()
    {
        List<GameObject> AE = new List<GameObject>();
        AE.Add(adeine);
        AE.Add(slotFill);
        dividedStrands.Add(AE);

        List<GameObject> EA = new List<GameObject>();
        EA.Add(slotFill);
        EA.Add(adeine);
        dividedStrands.Add(EA);

        List<GameObject> TE = new List<GameObject>();
        TE.Add(thymine);
        TE.Add(slotFill);
        dividedStrands.Add(TE);

        List<GameObject> ET = new List<GameObject>();
        ET.Add(slotFill);
        ET.Add(thymine);
        dividedStrands.Add(ET);

        List<GameObject> CE = new List<GameObject>();
        CE.Add(cytosine);
        CE.Add(slotFill);
        dividedStrands.Add(CE);

        List<GameObject> EC = new List<GameObject>();
        EC.Add(slotFill);
        EC.Add(cytosine);
        dividedStrands.Add(EC);

        List<GameObject> GE = new List<GameObject>();
        GE.Add(guanine);
        GE.Add(slotFill);
        dividedStrands.Add(GE);

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
       if(frameCount==30)
       {
        if(strandCount<20)
        {
            SpawnStrandDivide(transform.position, dividedStrands[Random.Range(0, dividedStrands.Count)]);
        }
        frameCount=0;
        strandCount++;
       } 
       else
       {
        frameCount++;
       }

       if(strandCount == 22) 
       {
        Destroy(GameObject.FindWithTag("StrandSpawner"));
        Destroy(GameObject.FindWithTag("StrandCollider"));
       }
    }

    public void SpawnStrandDivide(Vector3 spawnPosition, List<GameObject> chosenStrands)
    {
        Vector3 spawnPositionOne = new Vector3(spawnPosition.x, spawnPosition.y, spawnPosition.z+0.1f);
        Vector3 spawnPositionTwo = new Vector3(spawnPosition.x, spawnPosition.y, spawnPosition.z-0.1f);
        spawnableObject = Instantiate(chosenStrands[0], spawnPositionOne, Quaternion.identity);
        SpawnableObjectTwo = Instantiate(chosenStrands[1], spawnPositionTwo, Quaternion.identity);
    }

}
