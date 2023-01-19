using UnityEngine;
using System.Collections;

public class Zelda_nintendoDS : MonoBehaviour {

	public float speed = 4 ;
	public Transform Navi;
	public Camera micamara;
	public Animator anim ;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (Input.GetButton ("Fire1")) {
			anim.SetBool ("isRun", true);
			RaycastHit hit;
			Ray ray = micamara.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				Navi.position = hit.point;

				transform.LookAt (new Vector3 (Navi.position.x, transform.position.y, Navi.position.z));
				transform.Translate (Vector3.forward * speed * Time.deltaTime);

			}

		} else {
			anim.SetBool ("isRun", false);

		}
	
	}
}
