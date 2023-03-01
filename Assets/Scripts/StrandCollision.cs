using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrandCollision : MonoBehaviour
{
    public float range;
    bool inContact = false;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.up;
        Ray theRay = new Ray(transform.position, transform.TransformDirection(direction*range));
        Debug.DrawRay(transform.position, transform.TransformDirection(direction*range));

        if(Physics.Raycast(theRay, out RaycastHit hit, range)){
            Debug.Log("A");
            inContact = true;
        }
        else{
            inContact = false;
        }
    }

    private void spawnAdenine() {
        if(inContact){

        }
    }
    private void spawnCytosine() {
        if(inContact){
            
        }
    }
    private void spawnThymine() {
        if(inContact){
            
        }
    }
    private void spawnGuanine() {
        if(inContact){
            
        }
    }
}
