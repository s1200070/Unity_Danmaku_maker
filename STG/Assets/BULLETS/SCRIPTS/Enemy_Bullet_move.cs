using UnityEngine;
using System.Collections;

public class Enemy_Bullet_move : MonoBehaviour {

	public float speed=0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += transform.up*-speed;
		if(this.gameObject.transform.position.y<-10){
			Destroy(this.gameObject);
		}
	}
}
