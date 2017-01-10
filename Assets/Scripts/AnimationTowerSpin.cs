using UnityEngine;
using System.Collections;

public class AnimationTowerSpin  : MonoBehaviour
{
	public Animator towerAnim;

	void Start ()
	{
	}

	public void StartTowerSpin ()
	{
		if (towerAnim != null) {
			towerAnim.Play ("towerSpinAnim");
		}
	}
}
