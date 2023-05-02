using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MissingStrand : MonoBehaviour
{

    [SerializeField]
    Material adeine_material;
    [SerializeField]
    Material thymine_material;
    [SerializeField]
    Material cytosine_material;
    [SerializeField]
    Material guanine_material;

    TextMeshProUGUI poinstScored_text;

    GameObject spawnableObject;

    public int pointCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void SpawnStrand(Material strandMaterial, string strandName)
    {
        GameObject pointObject = GameObject.FindWithTag("ScoreKeeper");
        GameObject poinstScored_text_object = GameObject.FindWithTag("PointScore");
        poinstScored_text = poinstScored_text_object.GetComponent<TextMeshProUGUI>();

        pointCounter = pointObject.GetComponent<Score>().pointCounter;

       spawnableObject = GameObject.FindWithTag("Empty");
       spawnableObject.GetComponent<Renderer>().material = strandMaterial;
  
       float dist = Vector3.Distance(GameObject.FindWithTag(strandName).transform.position, spawnableObject.transform.position);
       if(dist<0.25 && dist>=0.20)
       {
            if(spawnableObject.transform.position.y <= GameObject.FindWithTag("StrandCollider").transform.position.y+0.1 && spawnableObject.transform.position.y >= GameObject.FindWithTag("StrandCollider").transform.position.y-0.1){
                pointCounter+=2;
            }
            else if(spawnableObject.transform.position.y <= GameObject.FindWithTag("StrandCollider").transform.position.y+0.2 && spawnableObject.transform.position.y >= GameObject.FindWithTag("StrandCollider").transform.position.y-0.2){
                pointCounter+=1;
            }
            else{
                pointCounter-=1;
            }        
       }
       else{
        pointCounter-=1;
       }
       spawnableObject.tag = strandName;
       poinstScored_text.SetText("Points Scored: "+pointCounter);
       pointObject.GetComponent<Score>().pointCounter = pointCounter;
    }

    public void SpawnStrandA()
    {
        SpawnStrand(adeine_material, "Adeine");
    }

    public void SpawnStrandC()
    {
        SpawnStrand(cytosine_material, "Cytosine");
    }

    public void SpawnStrandT()
    {
        SpawnStrand(thymine_material, "Thymine");
    }

    public void SpawnStrandG()
    {
        SpawnStrand(guanine_material, "Guanine");
    }

}
