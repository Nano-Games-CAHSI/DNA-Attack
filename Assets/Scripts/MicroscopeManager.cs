using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class MicroscopeManager : MonoBehaviour
{
    [SerializeField]
    ARRaycastManager RaycastManager;
    [SerializeField]
    GameObject nanobotPrefab;
    GameObject spawnableObject;

    List<ARRaycastHit> m_Hits = new List<ARRaycastHit>();
    Camera arCamera;

    // Start is called before the first frame update
    void Start()
    {
        spawnableObject = null;
        arCamera = GameObject.Find("AR Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount==0) return;

        RaycastHit hit;
        Ray ray = arCamera.ScreenPointToRay(Input.GetTouch(0).position);

            if (RaycastManager.Raycast(Input.GetTouch(0).position, m_Hits)) {
                if (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(0).phase == TouchPhase.Began || Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    if (Physics.Raycast(ray, out hit)) 
                    {
                        if (hit.collider.name == "Microscope")
                        {
                            Destroy(hit.collider.gameObject);
                            SpawnNanobot(m_Hits[0].pose.position);
                        }
                    }
                }
            }
    }

    public void SpawnNanobot(Vector3 spawnPosition){
        spawnableObject = Instantiate(nanobotPrefab, spawnPosition, Quaternion.identity);
    }


}
