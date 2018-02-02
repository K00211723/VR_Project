using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locationChange : MonoBehaviour {
	public GameObject cameraRig1;
	public GameObject cameraRig2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void onTriggerEnter(Collider col){
		if (col.gameObject.tag == "trigger1") {
			cameraRig2.SetActive (true);
			cameraRig1.SetActive (false);
		}
		if (col.gameObject.tag == "trigger2") {
			cameraRig2.SetActive (false);
			cameraRig1.SetActive (true);
		}
	
	}
}
