using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinConditionDisplay : MonoBehaviour
{
    Score pointsScript;

    TextMeshProUGUI poinstScored_text;

    // Start is called before the first frame update
    void Start()
    {
        GameObject pointObject = GameObject.FindWithTag("ScoreKeeper");
        pointsScript = pointObject.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        updateCanvas();
    }

    public void updateCanvas()
    {
        GameObject poinstScored_text_object = GameObject.FindWithTag("EndScore");
        poinstScored_text = poinstScored_text_object.GetComponent<TextMeshProUGUI>();
        if(pointsScript.pointCounter<20)
        {
            Debug.Log("Lost"); 
            poinstScored_text.SetText("You have lost with a score of: "+pointsScript.pointCounter+"\nThe organism has now become completely corrupted and unfixable.\nBetter luck next time.");
        }
        else{
            Debug.Log("Won"); 
            poinstScored_text.SetText("Congratulations! You have won with a score of: "+pointsScript.pointCounter+"\nThe organism has been saved");
        } 
    }
}
