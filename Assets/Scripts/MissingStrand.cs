using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissingStrand : MonoBehaviour
{
    [SerializeField]
    GameObject adeine;
    [SerializeField]
    GameObject thymine;
    [SerializeField]
    GameObject cytosine;
    [SerializeField]
    GameObject guanine;

    GameObject spawnableObject;

    public float range;
    bool inContact = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnStrandA()
    {
        //finds position of object tagged empty filling in as an unmatched dna strand
        Vector3 pos = new Vector3(GameObject.FindWithTag("Empty").transform.position.x, (float) (GameObject.FindWithTag("Empty").transform.position.y - 0.01), GameObject.FindWithTag("Empty").transform.position.z);
       //spawns the adeine strand where the empty strand was
       spawnableObject = Instantiate(adeine, pos, Quaternion.identity);
       //destroys the empty strand
       Destroy(GameObject.FindWithTag("Empty"));
    }

    public void SpawnStrandC()
    {
        //finds position of object tagged empty filling in as an unmatched dna strand
        Vector3 pos = new Vector3(GameObject.FindWithTag("Empty").transform.position.x, (float) (GameObject.FindWithTag("Empty").transform.position.y - 0.01), GameObject.FindWithTag("Empty").transform.position.z);
       //spawns the cytosine strand where the empty strand was
       spawnableObject = Instantiate(cytosine, pos, Quaternion.identity);
       //destroys the empty strand
       Destroy(GameObject.FindWithTag("Empty"));
    }

    public void SpawnStrandT()
    {
        //finds position of object tagged empty filling in as an unmatched dna strand
        Vector3 pos = new Vector3(GameObject.FindWithTag("Empty").transform.position.x, (float) (GameObject.FindWithTag("Empty").transform.position.y - 0.01), GameObject.FindWithTag("Empty").transform.position.z);
        //spawns the thymine strand where the empty strand was
        spawnableObject = Instantiate(thymine, pos, Quaternion.identity);
        //destroys the empty strand
        Destroy(GameObject.FindWithTag("Empty"));
    }

    public void SpawnStrandG()
    {
        //finds position of object tagged empty filling in as an unmatched dna strand
        Vector3 pos = new Vector3(GameObject.FindWithTag("Empty").transform.position.x, (float) (GameObject.FindWithTag("Empty").transform.position.y - 0.01), GameObject.FindWithTag("Empty").transform.position.z);
        //spawns the guanine strand where the empty strand was
        spawnableObject = Instantiate(guanine, pos, Quaternion.identity);
        //destroys the empty strand
        Destroy(GameObject.FindWithTag("Empty"));
    }

}
