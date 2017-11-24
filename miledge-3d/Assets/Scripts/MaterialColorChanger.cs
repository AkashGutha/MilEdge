using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialColorChanger : MonoBehaviour {
	private Material _dressMaterial;
	private Material _skinMaterial;
	public GameObject Dress;
	public GameObject Skin;

	private void Awake () {
		_dressMaterial = Dress.GetComponent<Renderer> ().sharedMaterial;
		_skinMaterial = Skin.GetComponent<Renderer> ().sharedMaterial;
	}

	public void ChangeDressColor (Color color) {
		_dressMaterial.SetColor ("_Color", color);
	}

	public void ChangeSkinColor (Color color) {
		_skinMaterial.SetColor ("_Color", color);
		Debug.Log("Here");
	}
}