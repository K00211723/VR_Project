﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void onTriggerEnter(Collider col){
		if (col.gameObject.tag == "Scene1");
		SceneManager.LoadScene("Now",LoadSceneMode.Additive);
	}
}
