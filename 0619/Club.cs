using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club : MonoBehaviour {
	public int changeRate;
	float timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if( (int)timer % changeRate == 0 ) {
			this.gameObject.GetComponent<Light>().intensity = 0.1f;
			this.gameObject.GetComponent<Light>().color = new Color(Random.RandomRange (0, 255), Random.RandomRange (0, 255), Random.RandomRange (0, 255));
		}
}

}