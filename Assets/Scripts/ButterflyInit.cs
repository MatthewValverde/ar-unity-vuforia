using UnityEngine;
using System.Collections;

namespace Vuforia
{

	public class ButterflyInit  : MonoBehaviour,
ITrackableEventHandler
	{
		private TrackableBehaviour mTrackableBehaviour;

		public Animator butterflyAnimation;

		public GameObject butterfly;

		void Start ()
		{
			mTrackableBehaviour = GetComponent<TrackableBehaviour> ();
			if (mTrackableBehaviour) {
				mTrackableBehaviour.RegisterTrackableEventHandler (this);
			}
		}

		public void OnTrackableStateChanged (
			TrackableBehaviour.Status previousStatus,
			TrackableBehaviour.Status newStatus)
		{
			if (newStatus == TrackableBehaviour.Status.DETECTED ||
			    newStatus == TrackableBehaviour.Status.TRACKED ||
			    newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED) {
			
				print ("READY  !!!!!");

				if (butterfly != null) {
					butterfly.SetActive (true);
				}


					

			} else {



				if (butterfly != null) {

					butterfly.SetActive (false);
				}

			}
		}

		public void StartAnimation ()
		{
			if (butterflyAnimation != null) {

				butterflyAnimation.Play("butterflyFlying");
			}
		}


	}


}