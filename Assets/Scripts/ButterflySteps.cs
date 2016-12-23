using UnityEngine;
using System.Collections;

public class ButterflySteps  : MonoBehaviour
{
	public GameObject butterfly;

	void Start ()
	{
	}

	public void StartAnimation ()
	{
		if (butterfly != null) {
			butterfly.SetActive (true);
		}
	}
}
