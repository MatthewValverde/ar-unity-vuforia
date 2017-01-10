using UnityEngine;
using System.Collections;

namespace Vuforia
{

	public class CameraReadyScript  : MonoBehaviour,
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
			
				print ("READY  !!!!!");
				if (floorAnim != null) {
					floorAnim.Play ("towerFloorAnim");
				}

				Invoke ("StartTowerAnimation", 0.5f);

			} else {

				print ("NO");
				if (floorAnim != null) {
					floorAnim.Play ("towerFloorDefaultAnim");
				}

				if (towerAnim != null) {
					towerAnim.Play ("towerDefaultAnim");
				}

			}
		}

		public void StartTowerAnimation ()
		{
			CancelInvoke ("StartTowerAnimation");

			if (towerAnim != null) {
				towerAnim.Play ("towerAnim");
			}
		}
	}
}