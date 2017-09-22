using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour {

	float rotSpeed = 1000;

	void OnMouseDrag()
	{
		float rotY = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
		transform.Rotate(0, -rotY,0, Space.Self);
	}
}
