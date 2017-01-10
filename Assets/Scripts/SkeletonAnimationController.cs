using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAnimationController : MonoBehaviour
{

	public GameObject skeleton;
	public Animator floorAnim;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	/*public void StartAnimation ()
	{
		if (skeleton != null) {
			skeleton.SetActive(true);
			skeleton.GetComponent<Rigidbody>().isKinematic = false;
			Invoke("InitStandUp", 1);
		}
	}

	private void InitStandUp ()
	{
		CancelInvoke("InitStandUp");

		if (skeleton != null) {
			skeleton.GetComponent<Animator>().Play ("StandUp02");
		}
	}*/

	public void StartFloorAnimation ()
	{
		print ("START FLOOR ROOLLL");
		if (floorAnim != null) {

			print ("START FLOOR ROOLLL33333333333333333333333");
			floorAnim.Play ("floorRolling");
		}
	}
}
