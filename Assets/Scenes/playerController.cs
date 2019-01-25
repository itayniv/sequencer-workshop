using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {


    public float rayLength;
    public LayerMask layerMask;
    public GameObject sequencerGameObject;
    //public GameObject soundGeneration;




	// Use this for initialization
	void Start () {
        sequencerGameObject = GameObject.FindWithTag("Sequencer");
        //soundGeneration = GameObject.FindWithTag("soundGeneration");

		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("press Down");
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, rayLength, layerMask))
            {
                //Debug.Log("hit" + hit.point);
                //Debug.Log(hit.transform.gameObject);
                //Vector3 hitPos = hit.point;

                GameObject hitPad = hit.transform.gameObject;

                sequencerGameObject.GetComponent<sequencer>().patternCheck(hitPad);
                //soundGeneration.GetComponent<ProceduralAudioController>().playVariables(hitPos);

            }

        }
		
	}
}
