using UnityEngine;
using System.Collections;

public class Triger_RE_camera : MonoBehaviour {
	public GameObject miCamara;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay(Collider other){
		if (other.transform.tag == "Player") {

			miCamara.SetActive (true);


		}
	}

	void OnTriggerExit(Collider other){
		if (other.transform.tag == "Player") {

			miCamara.SetActive (false);


		}
	}

	}
