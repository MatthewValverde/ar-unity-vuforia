using UnityEngine;
using System.Collections;

namespace Vuforia
{

	public class SkeletonInit  : MonoBehaviour,
ITrackableEventHandler
	{
		private TrackableBehaviour mTrackableBehaviour;

		public Animator floorAnim;

		public GameObject skeleton;
		public Animator skeletonAnimator;
		public Rigidbody skeletonRigidBody;

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
				if (floorAnim != null) {
					floorAnim.Play ("towerFloorAnim");
				}
					

			} else {

				print ("NO");
				if (floorAnim != null) {
					floorAnim.Play ("towerFloorDefaultAnim");
				}

				if (skeleton != null) {
					//skeletonRigidBody.isKinematic = true;

					skeleton.GetComponent<Rigidbody>().isKinematic = true;
					skeleton.SetActive(false);
				}

				if (skeletonAnimator != null) {
					//skeletonAnimator.Play ("towerDefaultAnim");
				}

			}
		}


	}
}