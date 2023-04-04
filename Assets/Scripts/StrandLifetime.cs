using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StrandLifetime : MonoBehaviour
{
    public float lifetime = 2.0f;

    Score pointsScript;

    TextMeshProUGUI poinstScored_text;
   
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
        if(this.gameObject.transform.position.y < (float) (GameObject.FindWithTag("StrandCollider").transform.position.y-0.1))
        {
            if(transform.tag == "Empty")
            {
                GameObject pointObject = GameObject.FindWithTag("ScoreKeeper");
                GameObject poinstScored_text_object = GameObject.FindWithTag("PointScore");
                poinstScored_text = poinstScored_text_object.GetComponent<TextMeshProUGUI>(); 
                //destroys the dna strand
                pointObject.GetComponent<Score>().pointCounter = pointObject.GetComponent<Score>().pointCounter-1;
                poinstScored_text.SetText("Points Scored: "+pointObject.GetComponent<Score>().pointCounter);
            }
            Destroy(this.gameObject);
        }
    }
}
