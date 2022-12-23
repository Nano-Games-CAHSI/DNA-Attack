using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrandMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("ChangePosition", 0, 0);
    }

    void ChangePosition () {
        //Compute position for next time
        transform.position = new Vector3 (transform.position.x, (float) (transform.position.y - 0.01), transform.position.z);
    }
}
