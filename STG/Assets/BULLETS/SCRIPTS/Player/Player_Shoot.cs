using UnityEngine;
using System.Collections;

public class Player_Shoot : MonoBehaviour {
	public GameObject Player_Bullet;

	// Use this for initialization
	IEnumerator Start () {
		while(true){
			Instantiate(Player_Bullet,this.transform.position,this.transform.rotation);
			yield return new WaitForSeconds(0.1f);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
