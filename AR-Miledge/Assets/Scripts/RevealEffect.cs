using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class RevealEffect : MonoBehaviour {

	public Material material;
	private float cutOff = 0.0f;

	private void Start () {
		material.SetFloat ("_CutOff", 0f);
		StartCoroutine (LeftToRightAnimation ());
	}

	// Postprocess the image
	private void OnRenderImage (RenderTexture source, RenderTexture destination) {
		Graphics.Blit (source, destination, material);
	}

	public void StartLeftToRightAnimation () {
		StartCoroutine (LeftToRightAnimation ());
	}

	IEnumerator LeftToRightAnimation () {
		yield return new WaitForSeconds (2);
		while (cutOff < 1f) {
			cutOff += 0.001f;
			material.SetFloat ("_CutOff", cutOff);
			yield return new WaitForSeconds(0.001f);
		}
		cutOff = 0;
	}

}