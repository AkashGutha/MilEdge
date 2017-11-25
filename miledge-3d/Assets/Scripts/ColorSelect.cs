using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelect : MonoBehaviour {

    private Color color;

    private void Awake () {
        color = GetComponent<Image> ().color;
    }

    public void ChangeColor () {

        GameObject.FindGameObjectWithTag ("Display Model").GetComponent<MaterialColorChanger> ().ChangeDressColor (color);
    }
}