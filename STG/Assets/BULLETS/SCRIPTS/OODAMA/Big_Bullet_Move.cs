using UnityEngine;
using System.Collections;

public class Big_Bullet_Move : MonoBehaviour {
	public float speed = 0.03f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += this.transform.up*speed*-1;
		Destroy(this.gameObject,5);
	}
}
