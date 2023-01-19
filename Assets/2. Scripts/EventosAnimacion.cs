using UnityEngine;
using System.Collections;

public class EventosAnimacion : MonoBehaviour {

	public AudioSource miAudioSource;

	public AudioClip sonidoataque;
	public AudioClip sonidosalto;
	public AudioClip sonidopasos;


	// Use this for initialization
	void Start () {
		miAudioSource = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
	


	}


	public void SonidoAtaque(){

		miAudioSource.PlayOneShot (sonidoataque, 1f);
		miAudioSource.pitch = 1;

	}
	public void SonidoSalto(){

		miAudioSource.PlayOneShot (sonidosalto, 1f);

		miAudioSource.pitch = 1;

	}
	public void SonidoPasos(){

		miAudioSource.PlayOneShot (sonidopasos, 0.5f);
		miAudioSource.pitch = (Random.Range(0.8f,1.2f));

			

	}


}
