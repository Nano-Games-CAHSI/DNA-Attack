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

        //finds position of object tagged empty filling in as an unmatched dna strand
        Vector3 pos = new Vector3(GameObject.FindWithTag("Empty").transform.position.x, (float) (GameObject.FindWithTag("Empty").transform.position.y - 0.01), GameObject.FindWithTag("Empty").transform.position.z);
       //spawns the adeine strand where the empty strand was
       spawnableObject = Instantiate(adeine, pos, Quaternion.identity);
       //destroys the empty strand
       float dist = Vector3.Distance(GameObject.FindWithTag("Adeine").transform.position, GameObject.FindWithTag("Empty").transform.position);
       if(dist<0.25)
       {
            if(GameObject.FindWithTag("Empty").transform.position.y <= GameObject.FindWithTag("StrandCollider").transform.position.y+0.1 && GameObject.FindWithTag("Empty").transform.position.y >= GameObject.FindWithTag("StrandCollider").transform.position.y-0.1){
                pointCounter+=2;
            }
            else if(GameObject.FindWithTag("Empty").transform.position.y <= GameObject.FindWithTag("StrandCollider").transform.position.y+0.2 && GameObject.FindWithTag("Empty").transform.position.y >= GameObject.FindWithTag("StrandCollider").transform.position.y-0.2){
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
       Destroy(GameObject.FindWithTag("Empty"));
       pointObject.GetComponent<Score>().pointCounter = pointCounter;
    }

    public void SpawnStrandC()
    {
        GameObject pointObject = GameObject.FindWithTag("ScoreKeeper");
        GameObject poinstScored_text_object = GameObject.FindWithTag("PointScore");
        poinstScored_text = poinstScored_text_object.GetComponent<TextMeshProUGUI>();

        //finds position of object tagged empty filling in as an unmatched dna strand
        Vector3 pos = new Vector3(GameObject.FindWithTag("Empty").transform.position.x, (float) (GameObject.FindWithTag("Empty").transform.position.y - 0.01), GameObject.FindWithTag("Empty").transform.position.z);
       //spawns the cytosine strand where the empty strand was
       spawnableObject = Instantiate(cytosine, pos, Quaternion.identity);
       //destroys the empty strand
       float dist = Vector3.Distance(GameObject.FindWithTag("Cytosine").transform.position, GameObject.FindWithTag("Empty").transform.position);
       if(dist<0.3)
       {
            if(GameObject.FindWithTag("Empty").transform.position.y <= GameObject.FindWithTag("StrandCollider").transform.position.y+0.1 && GameObject.FindWithTag("Empty").transform.position.y >= GameObject.FindWithTag("StrandCollider").transform.position.y-0.1){
                pointCounter+=2;
            }
            else if(GameObject.FindWithTag("Empty").transform.position.y <= GameObject.FindWithTag("StrandCollider").transform.position.y+0.2 && GameObject.FindWithTag("Empty").transform.position.y >= GameObject.FindWithTag("StrandCollider").transform.position.y-0.2){
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
       Destroy(GameObject.FindWithTag("Empty"));
       pointObject.GetComponent<Score>().pointCounter = pointCounter;
    }

    public void SpawnStrandT()
    {
        GameObject pointObject = GameObject.FindWithTag("ScoreKeeper");
        GameObject poinstScored_text_object = GameObject.FindWithTag("PointScore");
        poinstScored_text = poinstScored_text_object.GetComponent<TextMeshProUGUI>();

        //finds position of object tagged empty filling in as an unmatched dna strand
        Vector3 pos = new Vector3(GameObject.FindWithTag("Empty").transform.position.x, (float) (GameObject.FindWithTag("Empty").transform.position.y - 0.01), GameObject.FindWithTag("Empty").transform.position.z);
        //spawns the thymine strand where the empty strand was
        spawnableObject = Instantiate(thymine, pos, Quaternion.identity);
        //destroys the empty strand
       float dist = Vector3.Distance(GameObject.FindWithTag("Thymine").transform.position, GameObject.FindWithTag("Empty").transform.position);
       if(dist<0.3)
       {
            if(GameObject.FindWithTag("Empty").transform.position.y <= GameObject.FindWithTag("StrandCollider").transform.position.y+0.1 && GameObject.FindWithTag("Empty").transform.position.y >= GameObject.FindWithTag("StrandCollider").transform.position.y-0.1){
                pointCounter+=2;
            }
            else if(GameObject.FindWithTag("Empty").transform.position.y <= GameObject.FindWithTag("StrandCollider").transform.position.y+0.2 && GameObject.FindWithTag("Empty").transform.position.y >= GameObject.FindWithTag("StrandCollider").transform.position.y-0.2){
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
       Destroy(GameObject.FindWithTag("Empty"));
       pointObject.GetComponent<Score>().pointCounter = pointCounter;
    }

    public void SpawnStrandG()
    {
        GameObject pointObject = GameObject.FindWithTag("ScoreKeeper");
        GameObject poinstScored_text_object = GameObject.FindWithTag("PointScore");
        poinstScored_text = poinstScored_text_object.GetComponent<TextMeshProUGUI>();

        //finds position of object tagged empty filling in as an unmatched dna strand
        Vector3 pos = new Vector3(GameObject.FindWithTag("Empty").transform.position.x, (float) (GameObject.FindWithTag("Empty").transform.position.y - 0.01), GameObject.FindWithTag("Empty").transform.position.z);
        //spawns the guanine strand where the empty strand was
        spawnableObject = Instantiate(guanine, pos, Quaternion.identity);
        //destroys the empty strand
       float dist = Vector3.Distance(GameObject.FindWithTag("Guanine").transform.position, GameObject.FindWithTag("Empty").transform.position);
       if(dist<0.3)
       {
            if(GameObject.FindWithTag("Empty").transform.position.y <= GameObject.FindWithTag("StrandCollider").transform.position.y+0.1 && GameObject.FindWithTag("Empty").transform.position.y >= GameObject.FindWithTag("StrandCollider").transform.position.y-0.1){
                pointCounter+=2;
            }
            else if(GameObject.FindWithTag("Empty").transform.position.y <= GameObject.FindWithTag("StrandCollider").transform.position.y+0.2 && GameObject.FindWithTag("Empty").transform.position.y >= GameObject.FindWithTag("StrandCollider").transform.position.y-0.2){
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
       Destroy(GameObject.FindWithTag("Empty"));
       pointObject.GetComponent<Score>().pointCounter = pointCounter;
    }

}
