using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialColorChanger : MonoBehaviour {

	public void ChangeDressColor (Color color) {
		this.transform.Find ("Dress").GetComponentInChildren<Renderer> ().sharedMaterial.SetColor ("_Color", color);
	}

	public void ChangeSkinColor (Color color) {
		this.transform.Find ("Body").GetComponentInChildren<Renderer> ().sharedMaterial.SetColor ("_Color", color);
	}
}