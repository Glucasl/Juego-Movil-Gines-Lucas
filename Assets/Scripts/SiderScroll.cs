using UnityEngine;
using System.Collections;

public class SiderScroll : MonoBehaviour {

	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;
	//Relativo al pivote de la camara
	public Transform piv_Cam;

	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {

			moveDirection = piv_Cam.TransformDirection (new Vector3 (Input.GetAxis ("Horizontal"), 0,0));

			moveDirection *= speed;
			if (Input.GetButtonDown("Jump"))
				moveDirection.y = jumpSpeed;

		} 
		else {
			//CONTROL AEREO
			Vector3 tempdirection =  piv_Cam.TransformDirection (new Vector3 (Input.GetAxis ("Horizontal"), 0, 0));
			moveDirection.x = tempdirection.x * speed;
			moveDirection.z = tempdirection.z * speed;
		}

		//ROTACION
		Vector3 temp_Rot_Vector = piv_Cam.TransformDirection (new Vector3 (Input.GetAxis ("Horizontal"), 0, 0));

		if (temp_Rot_Vector.magnitude > 0.1f) {

			transform.forward = temp_Rot_Vector.normalized;

		}




		//APLICO Gravedad
		moveDirection.y -= gravity * Time.deltaTime;
		//APLICO MOVIMIENTO
		controller.Move(moveDirection * Time.deltaTime);
	}
}
