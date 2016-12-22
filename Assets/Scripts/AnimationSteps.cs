using UnityEngine;
using System.Collections;

	public class AnimationSteps  : MonoBehaviour
	{
		public Animator towerAnim;

		void Start ()
		{
		}
		
		public void StartTowerAnimation ()
		{
			if (towerAnim != null) {
				towerAnim.Play ("towerAnim");
			}
		}
	}
