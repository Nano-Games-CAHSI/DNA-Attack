using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARTrackedImageManager))]
public class TrackedImageInfoMultipleManager : MonoBehaviour
{

    //object that will be instantiated
    [SerializeField]
    private GameObject arObjectToPlace;

    //the scale that the object will be set to
    [SerializeField]
    private Vector3 scaleFactor = new Vector3(0.1f,0.1f,0.1f);

    //reference to the image tracker manager from AR Foundation
    private ARTrackedImageManager m_TrackedImageManager;

    //dictionary that will assosiate the objects with their names
    private Dictionary<string, GameObject> arObjects = new Dictionary<string, GameObject>();

    //the awake function creates a new object of the instantiated object to place and adds the object to the dictionary
    void Awake()
    {
        m_TrackedImageManager = GetComponent<ARTrackedImageManager>();
        
        GameObject newARObject = Instantiate(arObjectToPlace, Vector3.zero, Quaternion.identity);
        newARObject.name = arObjectToPlace.name;
        arObjects.Add(arObjectToPlace.name, newARObject);
    }

    // begins and ends the image tracking
    void OnEnable()
    {
        m_TrackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        m_TrackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    //when the image is found it will update its information calling the UpdateARImage method
    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (ARTrackedImage trackedImage in eventArgs.added)
        {
            UpdateARImage(trackedImage);
        }
    }

    //method that will create the object in the AR plane
    private void UpdateARImage(ARTrackedImage trackedImage)
    {
        // Assign and Place Game Object
        AssignGameObject(trackedImage.referenceImage.name, trackedImage.transform.position);
    }

    //Assigns and places the object
    void AssignGameObject(string name, Vector3 newPosition)
    {
        //if the object is not empty it places it on the corresponding location
        if(arObjectToPlace != null)
        {
            GameObject goARObject = arObjects[name];
            goARObject.SetActive(true);
            goARObject.transform.position = newPosition;
            goARObject.transform.localScale = scaleFactor;
        }
    }
}