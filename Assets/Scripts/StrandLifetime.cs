using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrandLifetime : MonoBehaviour
{
    public float lifetime = 2.0f;
   
    void  Awake ()
    {
        //Destroy(this.gameObject, lifetime);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //verify if the strand is a certain position bellow the Strand Collider
        if(this.gameObject.transform.position.y < (float) (GameObject.FindWithTag("StrandCollider").transform.position.y-0.2))
        {
            //destroys the dna strand
            Destroy(this.gameObject);
        }
    }
}
