using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour {

    public LayerMask layer;
    private Vector3 previousPos;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update () {
        Ray ray = new Ray(transform.position, Vector3.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit,1,layer))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit");
            if (Vector3.Angle(transform.position- previousPos, hit.transform.up)>130)
            {
                Debug.Log("Destroy");
                Destroy(hit.transform.gameObject);
            }
        }
        previousPos = transform.position;
	}
}
