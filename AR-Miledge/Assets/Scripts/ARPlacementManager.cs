using UnityEngine;
using UnityEngine.XR.iOS;
using System.Collections;
using System.Collections.Generic;

public class ARPlacementManager : MonoBehaviour {

	// public variables
	public bool ShootFromCenter;
	public GameObject Reticle;
	public GameObject Model;

	// private variables
	private Camera arCamera;
	private ARPoint arPoint;
	private Vector3 shootPosition;
	private List<ARHitTestResult> hits;
	private UnityARSessionNativeInterface nativeInterface;

	// constants
	private Vector3 screenCenter = new Vector3(0.5f,0.5f,0);

	private void Awake() {
		arCamera = Camera.main;
		Reticle.SetActive(false);
		nativeInterface = UnityARSessionNativeInterface.GetARSessionNativeInterface();
	}
	
	// Update is called once per frame
	void Update () {

		// get the point from where the ray will be shot
		if(ShootFromCenter){
			shootPosition = arCamera.ScreenToWorldPoint(screenCenter);
		}else if(Input.touchCount > 0){
			shootPosition = arCamera.ScreenToWorldPoint(Input.GetTouch(0).position);
		}

		// Raycast and gather the hits from the AR Planes
		if(shootPosition != null){
			arPoint.x = shootPosition.x;
			arPoint.y = shootPosition.y;
			hits = nativeInterface.HitTest( arPoint,
			ARHitTestResultType.ARHitTestResultTypeExistingPlaneUsingExtent
			);

			if(hits.Count>0){
				Debug.Log("Here");
				// display the reticle at that point
				Reticle.SetActive(true);
				Reticle.transform.SetPositionAndRotation(UnityARMatrixOps.GetPosition(hits[0].worldTransform), Quaternion.identity);
			}else{
				// swwitch off the reticle if we are not hittng any plane.
				// Reticle.SetActive(false);
			}
		}
	}
}
