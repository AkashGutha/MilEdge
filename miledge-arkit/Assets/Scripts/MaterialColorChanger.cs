using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialColorChanger : MonoBehaviour
{
    private Material _mat;
	public GameObject Dress;

	private void Awake() {
		_mat = Dress.GetComponent<Renderer>().sharedMaterial;
	}

	public void ChangeColor(Color color){
		_mat.SetColor("_Color", color);
	}
}
