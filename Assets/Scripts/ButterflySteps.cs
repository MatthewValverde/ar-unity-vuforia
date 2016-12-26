using UnityEngine;
using System.Collections;

public class ButterflySteps  : MonoBehaviour
{
	public Animator butterflyAnimation;

	void Start ()
	{
	}

	public void StartAnimation ()
	{
		if (butterflyAnimation != null) {

			butterflyAnimation.Play("butterflyFlying");
		}
	}
}
