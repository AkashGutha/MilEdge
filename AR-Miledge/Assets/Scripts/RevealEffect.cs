using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class RevealEffect : MonoBehaviour {

    public Material material;
	private float cutOff = 0.0f;
 
    // Postprocess the image
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, material);
    }

	public void StartLeftToRightAnimation(){
		StartCoroutine(LeftToRightAnimation());
	}

	IEnumerator LeftToRightAnimation(){
		while(cutOff < 1f){
			cutOff += 0.03f;
			material.SetFloat("_CutOff", cutOff);
			yield return new WaitForFixedUpdate();
		}
		cutOff = 0;
	}

}
