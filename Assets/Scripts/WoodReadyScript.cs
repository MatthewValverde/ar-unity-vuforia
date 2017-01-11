using UnityEngine;
using System.Collections;

namespace Vuforia
{

	public class WoodReadyScript  : MonoBehaviour,
ITrackableEventHandler
	{
		private TrackableBehaviour mTrackableBehaviour;

		public Animator floorAnim;

		public Animator towerAnim;

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
			
				Invoke ("StartAnimation", 3f);

			} else {

				print ("NO");
				if (floorAnim != null) {
					floorAnim.Play ("towerFloorDefaultAnim");
				}

				if (towerAnim != null) {
					towerAnim.Play ("tableDefault");
				}
			}
		}

		public void StartFloorAnimation ()
		{
			CancelInvoke ("StartFloorAnimation");

			if (floorAnim != null) {
				floorAnim.Play ("towerFloorAnim");
			}
		}

		public void StartAnimation ()
		{
			print("START ANIMATION .. ");

			if (towerAnim != null) {
				towerAnim.Play ("Table");
			}
		}
	}
}