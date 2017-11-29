using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialColorChanger : MonoBehaviour {

	private void Awake () {
		this.transform.Find ("Dress").GetComponentInChildren<Renderer> ().sharedMaterial.SetColor ("_Color", new Color (0.15f, 0.14f, 0.14f));
	}

	public void ChangeDressColor (Color color) {
		this.transform.Find ("Dress").GetComponentInChildren<Renderer> ().sharedMaterial.SetColor ("_Color", color);
	}

	public void ChangeSkinColor (Color color) {
		this.transform.Find ("Body").GetComponentInChildren<Renderer> ().sharedMaterial.SetColor ("_Color", color);
	}
}