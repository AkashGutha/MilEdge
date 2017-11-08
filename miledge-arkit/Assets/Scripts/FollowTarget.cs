using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{

  public float smoothing = 5f;
  public GameObject target;
  public Vector3 offset;

  // Update is called once per frame
  void Update()
  {
    transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, smoothing * Time.deltaTime);
    transform.LookAt(target.transform);
  }
}
