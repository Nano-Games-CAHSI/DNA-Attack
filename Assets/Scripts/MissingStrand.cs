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
        Vector3 pos = new Vector3(GameObject.FindWithTag("Empty").transform.position.x, (float) (GameObject.FindWithTag("Empty").transform.position.y - 0.01), GameObject.FindWithTag("Empty").transform.position.z);
       spawnableObject = Instantiate(adeine, pos, Quaternion.identity);
       Destroy(GameObject.FindWithTag("Empty"));
    }

    public void SpawnStrandC()
    {
        Vector3 pos = new Vector3(GameObject.FindWithTag("Empty").transform.position.x, (float) (GameObject.FindWithTag("Empty").transform.position.y - 0.01), GameObject.FindWithTag("Empty").transform.position.z);
       spawnableObject = Instantiate(cytosine, pos, Quaternion.identity);
       Destroy(GameObject.FindWithTag("Empty"));
    }

    public void SpawnStrandT()
    {
        Vector3 pos = new Vector3(GameObject.FindWithTag("Empty").transform.position.x, (float) (GameObject.FindWithTag("Empty").transform.position.y - 0.01), GameObject.FindWithTag("Empty").transform.position.z);
        spawnableObject = Instantiate(thymine, pos, Quaternion.identity);
        Destroy(GameObject.FindWithTag("Empty"));
    }

    public void SpawnStrandG()
    {
        Vector3 pos = new Vector3(GameObject.FindWithTag("Empty").transform.position.x, (float) (GameObject.FindWithTag("Empty").transform.position.y - 0.01), GameObject.FindWithTag("Empty").transform.position.z);
        spawnableObject = Instantiate(guanine, pos, Quaternion.identity);
        Destroy(GameObject.FindWithTag("Empty"));
    }

}
