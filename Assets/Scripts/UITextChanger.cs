using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UITextChanger : MonoBehaviour
{
    public MissingStrand missingStrand;

    [SerializeField] TextMeshProUGUI poinstScored_text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        Debug.Log(missingStrand.pointCounter.ToString());
        //poinstScored_text.SetText("Points Scored: " + missingStrand.pointCounter.ToString());
    }

}
