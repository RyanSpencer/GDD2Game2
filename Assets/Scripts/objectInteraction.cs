using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectInteraction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp(0))
        {
            Ray clickRay = new Ray(Input.mousePosition, new Vector3(0.0f, 0.0f, 1.0f));
            RaycastHit clickRayHit;
            if (Physics.Raycast(clickRay, out clickRayHit, 20))
            {
                
            }
        }
	}
}
