using UnityEngine;
using System.Collections;

public class Uzumaki_Bullet : MonoBehaviour {

	public GameObject bullet;
	IEnumerator Start(){
		while(true){
		Instantiate(bullet,this.gameObject.transform.position,this.transform.rotation);
		yield return new WaitForSeconds(0.1f);
		}
	}
}
