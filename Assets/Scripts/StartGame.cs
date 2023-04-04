using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    private Vector3 scaleFactor = new Vector3(0.1f,0.1f,0.1f);

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnMicroscope(GameObject microscope)
    {
        GameObject Microscope = Instantiate(microscope, new Vector3(-0.2f, 0f, 1.0f), Quaternion.Euler(new Vector3(0,90,0)));
        Microscope.transform.localScale = scaleFactor;
        Microscope.name = "Microscope";
        GameObject.FindWithTag("StartCanvas").SetActive(false);
    }
}
