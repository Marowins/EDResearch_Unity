using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		if ( Input.GetKeyDown( KeyCode.UpArrow )) {
			this.gameObject.transform.Translate (this.gameObject.transform.forward * 5f * Time.deltaTime );
		}
		if ( Input.GetKeyDown( KeyCode.DownArrow )) {
			this.gameObject.GetComponent<Rigidbody> ().AddForce (this.gameObject.transform.forward * 200);
		}
	}
}