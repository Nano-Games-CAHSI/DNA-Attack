using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StrandCollision : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(frameCount==30)
        {
            update = true;
        }
        else{
            frameCount++;
        }
        if(update)
        {
            if(GameObject.FindWithTag("Empty").transform.position.y<transform.position.y-0.1f)
            {
                GameObject pointObject = GameObject.FindWithTag("ScoreKeeper");
                GameObject poinstScored_text_object = GameObject.FindWithTag("PointScore");
                poinstScored_text = poinstScored_text_object.GetComponent<TextMeshProUGUI>();

                pointObject.GetComponent<Score>().pointCounter = pointObject.GetComponent<Score>().pointCounter-1;
                poinstScored_text.SetText("Points Scored: "+pointObject.GetComponent<Score>().pointCounter);

                GameObject.FindWithTag("Empty").tag = null;
            }     
            update = false;
        }*/
    }
}
