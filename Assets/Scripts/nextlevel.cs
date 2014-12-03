using UnityEngine;
using System.Collections;

public class nextlevel : MonoBehaviour {

	public string nombreNivel = "zombie3";

		bool cargando = false;

	void OnTriggerStay2D(Collider2D target){

		if (target.transform.tag == "Player") {
			Application.LoadLevel(nombreNivel);
		}
	}
}