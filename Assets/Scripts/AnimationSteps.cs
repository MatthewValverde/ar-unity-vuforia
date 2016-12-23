using UnityEngine;
using System.Collections;

	public class AnimationSteps  : MonoBehaviour
	{
		public Animator towerAnim;

		void Start ()
		{
		}
		
		public void StartAnimation ()
		{
			if (towerAnim != null) {
				towerAnim.Play ("towerAnim");
			}
		}
	}
