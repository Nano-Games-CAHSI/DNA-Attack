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

            if (RaycastManager.Raycast(Input.GetTouch(0).position, m_Hits)) {
                if (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(0).phase == TouchPhase.Began || Input.GetTouch(0).phase == TouchPhase.Ended)
                {
                    if (Physics.Raycast(ray, out hit)) 
                    {
                        if (hit.collider.name == "Microscope")
                        {
                            Destroy(hit.collider.gameObject);
                            dnaBeatCanvas.SetActive(true);
                            //SpawnStrandSpawner(m_Hits[0].pose.position);
                            Vector3 SpawnerPosition = new Vector3(hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y+0.5f, hit.collider.gameObject.transform.position.z);
                            SpawnStrandSpawner(SpawnerPosition);
                        }
                    }
                }
            }
    }

    public void SpawnNanobot(Vector3 spawnPosition){
        spawnableObject = Instantiate(nanobotPrefab, spawnPosition, Quaternion.identity);
    }

    public void SpawnStrandSpawner(Vector3 spawnPosition){
        spawnableObject = Instantiate(StrandMatchSpawner, spawnPosition, Quaternion.identity);
        secondSpawnableObject = Instantiate(strandColliderCheck, new Vector3(spawnPosition.x, spawnPosition.y-1, spawnPosition.z), Quaternion.identity);
    }


}
