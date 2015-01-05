using UnityEngine;
using System.Collections;

public class bullet_move : MonoBehaviour {

	public float speed = 0.1f; 

	float x;
	float y;


	// Use this for initialization
	IEnumerator Start () {


		while(true){

			this.transform.position += transform.up*-speed;


			yield return null;

		}



	}
	
	// Update is called once per frame
	void Update () {
	}
}
