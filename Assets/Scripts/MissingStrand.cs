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

    bool Acolliding;
    bool Tcolliding;
    bool Ccolliding;
    bool Gcolliding;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.collider.name == "Adeine")
        {
            Acolliding = true;
            Debug.Log("Enter");
        }
        else if(other.collider.name == "Cytosine")
        {
            Ccolliding = true;
            Debug.Log("Enter");            
        }
        else if(other.collider.name == "Guanine")
        {
            Gcolliding = true;
            Debug.Log("Enter");            
        }
        else if(other.collider.name == "Thymine")
        {
            Tcolliding = true;
            Debug.Log("Enter");            
        }
    }

    private void OnCollisionExit(Collision other) {
        if(other.collider.name == "Adeine")
        {
            Acolliding = false;
            Debug.Log("Exit");
        }
        else if(other.collider.name == "Cytosine")
        {
            Ccolliding = false;
            Debug.Log("Exit");            
        }
        else if(other.collider.name == "Guanine")
        {
            Gcolliding = false;
            Debug.Log("Exit");            
        }
        else if(other.collider.name == "Thymine")
        {
            Tcolliding = false;
            Debug.Log("Exit");            
        }
    }

    public void SpawnStrandA()
    {
        if(Acolliding)
        {
            spawnableObject = Instantiate(adeine, transform.position, Quaternion.identity);
        }
    }

    public void SpawnStrandC()
    {
        if(Ccolliding)
        {
            spawnableObject = Instantiate(cytosine, transform.position, Quaternion.identity);
        }
    }

    public void SpawnStrandT()
    {
        if(Tcolliding)
        {
            spawnableObject = Instantiate(thymine, transform.position, Quaternion.identity);
        }
    }

    public void SpawnStrandG()
    {
        if(Gcolliding)
        {
            spawnableObject = Instantiate(guanine, transform.position, Quaternion.identity);
        }
    }

}
