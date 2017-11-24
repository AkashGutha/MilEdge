using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelect : MonoBehaviour
{

    private Color color;
    public GameObject Target;

    private void Awake()
    {
        color = GetComponent<Image>().color;
    }

    public  void ChangeColor()
    {
        if (Target != null)
        {
            Target.GetComponent<MaterialColorChanger>().ChangeDressColor(color);
        }
    }
}
