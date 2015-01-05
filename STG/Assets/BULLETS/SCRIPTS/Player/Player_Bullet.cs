using UnityEngine;
using System.Collections;

public class Player_Bullet : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {

		this.transform.position += this.transform.up*0.3f;
		Destroy(this.gameObject,0.6f);
	
	}
}
