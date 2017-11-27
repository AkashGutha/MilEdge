using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private GameObject[] Models;
	private int modelIndex = 1;
	private Quaternion previousRotation;

	private void Awake () {
		Models = new GameObject[3] {
			GameObject.Find ("Model_hefty"),
				GameObject.Find ("Model_medium"),
				GameObject.Find ("Model_thin")
		};
		setRestModelsAsInactive (0);
		Debug.Log (Models.Length);
	}

	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKeyUp (KeyCode.Escape)) {
				Application.Quit ();
			}
		}
	}

	public void SwitchWeight () {
		// save previous rotation
		previousRotation = GameObject.FindGameObjectWithTag ("Display Model").transform.localRotation;

		Models[modelIndex].SetActive (true);
		Models[modelIndex].transform.SetPositionAndRotation (Vector3.zero, previousRotation);

		setRestModelsAsInactive (modelIndex);
		modelIndex++;
		if (modelIndex == Models.Length) modelIndex = 0;
	}

	private void setRestModelsAsInactive (int modelIndex) {
		for (int i = 0; i < Models.Length; i++) {
			Debug.Log ((i != modelIndex) + "  " + i);
			if (i != modelIndex)
				Models[i].SetActive (false);
		}
	}

	private void setAllActive (int modelIndex) {
		for (int i = 0; i < Models.Length; i++) {
			Models[i].SetActive (true);
		}
	}
}