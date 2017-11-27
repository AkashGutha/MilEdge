using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Rotate : MonoBehaviour
{

    public float AngularSpeed;
    public float DragSpeed;

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        var clicked = Input.GetMouseButton(0);
        if (!clicked) { transform.Rotate(0, AngularSpeed * Time.deltaTime, 0); }
        if (clicked)
        {
            var xInput = Input.GetAxis("Mouse X");
            if(xInput > 0.1f || xInput < -0.1f )
                transform.Rotate(0, -xInput * DragSpeed * 10 * Time.deltaTime, 0);
        }
#endif
#if !UNITY_EDITOR
        if (Input.touchCount > 0)
        {
            var deltaX = Input.GetTouch(0).deltaPosition.x;
            if (deltaX > 0.1f || deltaX < -0.1f  )
                transform.Rotate(0, -deltaX * DragSpeed * Time.deltaTime, 0);
        }
        else
        {
            transform.Rotate(0, AngularSpeed * Time.deltaTime, 0);
        }
#endif
    }
}
