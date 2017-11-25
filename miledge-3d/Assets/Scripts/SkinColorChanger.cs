using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinColorChanger : MonoBehaviour {
	public GameObject Model;
	public Color[] SkinColors;

	private int index = 0;

	private void Awake () {

	}

	public void ChangeColor () {
		if (index > 3) { index = 0; }
		Model.GetComponent<MaterialColorChanger> ().ChangeSkinColor (SkinColors[index]);
		index++;
	}
}