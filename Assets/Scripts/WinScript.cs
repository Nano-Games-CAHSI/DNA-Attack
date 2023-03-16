using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    StrandSpawner conditional;

    [SerializeField]
    GameObject endGameCanvas;
    int frameCount;
    bool condition;

    // Start is called before the first frame update
    void Start()
    {
        frameCount = 0;
        condition = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("StrandSpawner") is not null)
        {
            condition = GameObject.FindWithTag("StrandSpawner").GetComponent<StrandSpawner>().end;
        }
        if(condition)
        {
            if(frameCount==90)
            {
                endGameCanvas.SetActive(true);
            }
            else if(frameCount<90)
            {
                frameCount++;
            }
        }
    }
}
