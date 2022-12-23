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
        if(this.gameObject.transform.position.y < (float) (GameObject.FindWithTag("StrandCollider").transform.position.y-0.2))
        {
            Destroy(this.gameObject);
        }
    }
}
