using UnityEngine;
using System.Collections;

public class ControlRelativoAconANIMACION : MonoBehaviour {

	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;
	//Relativo al pivote de la camara
	public Transform piv_Cam;

	//ANIMATOR
	public Animator anim;


	//COLLISION DE LA ESPADA
	public GameObject espadaCollider;




	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		anim.SetBool ("tocandoSuelo", controller.isGrounded);

		if (controller.isGrounded) {

			moveDirection = piv_Cam.TransformDirection (new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical")));
			//Le paso la magnitud de la direccion al animator.
			anim.SetFloat ("magnitud", moveDirection.magnitude);

			moveDirection *= speed;
			if (Input.GetButtonDown("Jump"))
				moveDirection.y = jumpSpeed;

		} 
		else {
			anim.Play ("jump");
			//CONTROL AEREO
			Vector3 tempdirection =  piv_Cam.TransformDirection (new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical")));
			moveDirection.x = tempdirection.x * speed;
			moveDirection.z = tempdirection.z * speed;
		}

		//ROTACION
		Vector3 temp_Rot_Vector = piv_Cam.TransformDirection (new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical")));

		if (temp_Rot_Vector.magnitude > 0.1f) {

			transform.forward = temp_Rot_Vector.normalized;

		}

		//ATAQUE
		if (Input.GetButtonDown ("Fire1") && controller.isGrounded) {

			anim.Play ("atack");
		}


		//APLICO Gravedad
		moveDirection.y -= gravity * Time.deltaTime;

		if (!anim.GetCurrentAnimatorStateInfo (0).IsName ("atack")) {
			//APLICO MOVIMIENTO
			controller.Move (moveDirection * Time.deltaTime);
			//desactivo el collider de la espada
			espadaCollider.SetActive (false);
		} else {
			espadaCollider.SetActive (true);

		}



	}
}
