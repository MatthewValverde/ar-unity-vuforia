using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodTableAnimationScript : MonoBehaviour {

	public Animator table;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartTableRotation(){
		table.Play("TableRotate");
	}
}
