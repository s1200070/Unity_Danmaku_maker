using UnityEngine;
using System.Collections;

public class Accelaration_Bullet : MonoBehaviour {
	public float v0 = 0.1f;
	public float a = 0.3f;
	float accel = 1;
	// Use this for initialization
	void Start () {
		float accel = 1;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += transform.up*-1*v0*accel;
		accel += a;
	}

}
