using UnityEngine;
using System.Collections;

public class bullet_move_forward : MonoBehaviour {
	public float speed = 0.03f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += this.transform.right*speed;
		Destroy(this.gameObject,5);
	}
}
