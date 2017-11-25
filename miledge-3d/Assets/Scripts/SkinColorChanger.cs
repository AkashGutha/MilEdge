using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinColorChanger : MonoBehaviour {
	public Color[] SkinColors;

	private int index = 0;

	private void Awake () {
		ChangeColor ();
	}

	public void ChangeColor () {
		if (index > 5) { index = 0; }
		this.GetComponent<Image> ().color = SkinColors[index];
		GameObject.FindGameObjectWithTag ("Display Model").GetComponent<MaterialColorChanger> ().ChangeSkinColor (SkinColors[index]);
		index++;
	}
}