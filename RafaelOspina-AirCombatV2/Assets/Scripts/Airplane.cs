using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour {
	public float speed;
	public float forwardSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (0, 0, forwardSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.UpArrow)) {
			this.transform.Translate (0, speed * Time.deltaTime, 0);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			this.transform.Translate (0, -speed * Time.deltaTime, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Translate (-speed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Translate (speed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKeyDown(KeyCode.Space)) {
			GameObject missile = GameObject.Instantiate (Resources.Load ("Prefabs/Missile") as GameObject);
			missile.transform.SetParent (this.gameObject.transform);
			missile.transform.localPosition = new Vector3 (0.347f, -0.032f, -0.233f);
			missile.transform.SetParent (null);
			GameObject missile2 = GameObject.Instantiate (Resources.Load ("Prefabs/Missile") as GameObject);
			missile2.transform.SetParent (this.gameObject.transform);
			missile2.transform.localPosition = new Vector3 (-0.347f, -0.032f, -0.233f);
			missile2.transform.SetParent (null);
		}
	}
	/*void OnCollisionEnter(Collision collision) {
		GameObject explosion = GameObject.Instantiate (Resources.Load ("Prefabs/Explosion") as GameObject);
		explosion.transform.position = this.transform.position;
		Destroy (this.gameObject);
	}*/
}
