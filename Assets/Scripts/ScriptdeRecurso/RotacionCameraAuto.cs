using UnityEngine;
using System.Collections;

public class RotacionCameraAuto : MonoBehaviour {

	public Transform target;
	public float smoothTime = 0.3F;
	public float SmoothRotation = 1F;

	void Update() {



		transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * smoothTime );


		Vector3 vector3Temp  = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

		transform.rotation = Quaternion.Lerp (transform.rotation, target.rotation,  vector3Temp.magnitude * Time.deltaTime  * SmoothRotation );


		if (Input.GetButtonDown ("Fire2")) {

			transform.rotation = target.rotation;


		}
			
	}
}
