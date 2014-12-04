using UnityEngine;
using System.Collections;

public class activarcamvas : MonoBehaviour {
	public GameObject canvas;
	public bool estacerca = false;
	public bool muestratexto = false;

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
		estacerca = true;
		}

	void OnTriggerExit2D(Collider2D col){
				estacerca = false;
		}
	// Update is called once per frame
	void Update () {
	if (estacerca) {
			canvas.SetActive (true);
				}else{
			canvas.SetActive(false); 
	}
}
}