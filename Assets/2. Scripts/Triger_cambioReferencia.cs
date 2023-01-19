using UnityEngine;
using System.Collections;

public class Triger_cambioReferencia : MonoBehaviour {
	public GameObject miCamara;

	public ControlRelativoAconANIMACION playerScript;
	public Transform piv_Cam_Exterior;
	public Transform referencia_Interior;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay(Collider other){
		if (other.transform.tag == "Player") {

			miCamara.SetActive (true);
			playerScript.piv_Cam = referencia_Interior;


		}
	}

	void OnTriggerExit(Collider other){
		if (other.transform.tag == "Player") {

			miCamara.SetActive (false);
			playerScript.piv_Cam = piv_Cam_Exterior;


		}
	}

	}
