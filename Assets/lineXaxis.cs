using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineXaxis : MonoBehaviour {
	private LineRenderer lineRenderer;
	public Transform sourcex;
	public Transform destinationx;

	// Use this for initialization
	void Start () {
		sourcex.position = new Vector3 (0.0f, 0.0f, 0.0f);
		destinationx.position = new Vector3(10.0f, 0.0f, 0.0f);
		lineRenderer = GetComponent<LineRenderer> ();
		lineRenderer.SetWidth(.3f,.3f);
		lineRenderer.SetPosition(0,sourcex.position);
		lineRenderer.SetPosition(1, destinationx.position);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
