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
    GameObject secondSpawnableObject;
    [SerializeField]
    GameObject StrandMatchSpawner;
    [SerializeField]
    GameObject strandColliderCheck;
    [SerializeField]
    GameObject dnaBeatCanvas;
    [SerializeField]
    GameObject microscope;
    [SerializeField]
    GameObject WinManager;

    List<ARRaycastHit> m_Hits = new List<ARRaycastHit>();
    Camera arCamera;

    // Start is called before the first frame update
    void Start()
    {
        spawnableObject = null;
        secondSpawnableObject = null;
        arCamera = GameObject.Find("AR Camera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount==0) return;

        RaycastHit hit;
        Ray ray = arCamera.ScreenPointToRay(Input.GetTouch(0).position);
        //verifies when the screen is being touched and uses ray cast
            if (RaycastManager.Raycast(Input.GetTouch(0).position, m_Hits)) {
                if (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(0).phase == TouchPhase.Began || Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    if (Physics.Raycast(ray, out hit)) 
                    {
                        //verifies if you hit the microscope asset
                        if (hit.collider.name == "Microscope")
                        {
                            //destroys the microscope asset and activates the dnaBeat game canvas
                            Destroy(hit.collider.gameObject);
                            dnaBeatCanvas.SetActive(true);
                            //SpawnStrandSpawner(m_Hits[0].pose.position);
                            //spawns the dna strand spawner where microscope was placed
                            Vector3 SpawnerPosition = new Vector3(hit.collider.gameObject.transform.position.x+0.1f, hit.collider.gameObject.transform.position.y+0.5f, hit.collider.gameObject.transform.position.z);
                            SpawnStrandSpawner(SpawnerPosition);
                            WinManager.SetActive(true);
                        }
                    }
                }
            }
    }

    public void SpawnNanobot(Vector3 spawnPosition){
        //sets the spawnable object to be the nanobot
        spawnableObject = Instantiate(nanobotPrefab, spawnPosition, Quaternion.identity);
    }

    public void SpawnStrandSpawner(Vector3 spawnPosition){
        //sets the spawnable object to be the Strand Spawner
        spawnableObject = Instantiate(StrandMatchSpawner, spawnPosition, Quaternion.Euler(new Vector3(0,90,0)));
        //additionally spawns the Collider Checker bellow the strand spawner
        secondSpawnableObject = Instantiate(strandColliderCheck, new Vector3(spawnPosition.x, spawnPosition.y-1, spawnPosition.z), Quaternion.Euler(new Vector3(0,90,0)));
    }


}
