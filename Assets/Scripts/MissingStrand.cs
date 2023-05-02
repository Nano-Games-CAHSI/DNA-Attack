using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MissingStrand : MonoBehaviour
{
    [SerializeField]
    GameObject adeine;
    [SerializeField]
    GameObject thymine;
    [SerializeField]
    GameObject cytosine;
    [SerializeField]
    GameObject guanine;

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

    public void SpawnStrandA()
    {
        GameObject pointObject = GameObject.FindWithTag("ScoreKeeper");
        GameObject poinstScored_text_object = GameObject.FindWithTag("PointScore");
        poinstScored_text = poinstScored_text_object.GetComponent<TextMeshProUGUI>();

        pointCounter = pointObject.GetComponent<Score>().pointCounter;

       spawnableObject = GameObject.FindWithTag("Empty");
       spawnableObject.GetComponent<Renderer>().material = adeine_material;
       spawnableObject.tag = "Untagged";
  
       float dist = Vector3.Distance(GameObject.FindWithTag("Adeine").transform.position, spawnableObject.transform.position);
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
       poinstScored_text.SetText("Points Scored: "+pointCounter);
       pointObject.GetComponent<Score>().pointCounter = pointCounter;
    }

    public void SpawnStrandC()
    {
        GameObject pointObject = GameObject.FindWithTag("ScoreKeeper");
        GameObject poinstScored_text_object = GameObject.FindWithTag("PointScore");
        poinstScored_text = poinstScored_text_object.GetComponent<TextMeshProUGUI>();

        pointCounter = pointObject.GetComponent<Score>().pointCounter;

       spawnableObject = GameObject.FindWithTag("Empty");
       spawnableObject.GetComponent<Renderer>().material = cytosine_material;
       spawnableObject.tag = "Untagged";

       float dist = Vector3.Distance(GameObject.FindWithTag("Cytosine").transform.position, spawnableObject.transform.position);
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
       poinstScored_text.SetText("Points Scored: "+pointCounter);
       pointObject.GetComponent<Score>().pointCounter = pointCounter;
    }

    public void SpawnStrandT()
    {
        GameObject pointObject = GameObject.FindWithTag("ScoreKeeper");
        GameObject poinstScored_text_object = GameObject.FindWithTag("PointScore");
        poinstScored_text = poinstScored_text_object.GetComponent<TextMeshProUGUI>();

        pointCounter = pointObject.GetComponent<Score>().pointCounter;

       spawnableObject = GameObject.FindWithTag("Empty");
       spawnableObject.GetComponent<Renderer>().material = thymine_material;
       spawnableObject.tag = "Untagged";

       float dist = Vector3.Distance(GameObject.FindWithTag("Thymine").transform.position, spawnableObject.transform.position);
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
       poinstScored_text.SetText("Points Scored: "+pointCounter);
       pointObject.GetComponent<Score>().pointCounter = pointCounter;
    }

    public void SpawnStrandG()
    {
        GameObject pointObject = GameObject.FindWithTag("ScoreKeeper");
        GameObject poinstScored_text_object = GameObject.FindWithTag("PointScore");
        poinstScored_text = poinstScored_text_object.GetComponent<TextMeshProUGUI>();

        pointCounter = pointObject.GetComponent<Score>().pointCounter;

       spawnableObject = GameObject.FindWithTag("Empty");
       spawnableObject.GetComponent<Renderer>().material = guanine_material;
       spawnableObject.tag = "Untagged";

       float dist = Vector3.Distance(GameObject.FindWithTag("Guanine").transform.position, spawnableObject.transform.position);
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
       poinstScored_text.SetText("Points Scored: "+pointCounter);
       pointObject.GetComponent<Score>().pointCounter = pointCounter;
    }

}
