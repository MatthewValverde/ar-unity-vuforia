using UnityEngine;
using System.Collections;

public class WoodFloorSteps  : MonoBehaviour
{
	public Animator tableAnim;

	void Start ()
	{
	}

	public void StartAnimation ()
	{
		if (tableAnim != null) {
			tableAnim.Play ("Table");
		}
	}
}
