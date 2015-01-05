using UnityEngine;
using System.Collections;

public class Enemy_Destroy : MonoBehaviour {
	public static float HP=99989;
	public static float startHP;
	// Use this for initialization
	void Start () {
		startHP = HP;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (HP);
		if(HP<=0){
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "Bullet"){
			HP--;
		//	Debug.Log (HP);
		}
	}
}
