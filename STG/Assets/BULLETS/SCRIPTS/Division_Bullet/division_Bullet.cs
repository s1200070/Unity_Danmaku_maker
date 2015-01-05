using UnityEngine;
using System.Collections;

public class division_Bullet : MonoBehaviour {

	public Sprite bullet;
	private GameObject[] bullets = new GameObject[5];
	public GameObject division_bullet;

	// Use this for initialization
	IEnumerator Start () {

		while(true){

			
			yield return new WaitForSeconds(1f);
			for(int i=0;i<3;i++){
				division_bullet.renderer.enabled = false;
				bullets[0] = (GameObject)Instantiate (bullet,this.transform.position,new Quaternion(this.transform.rotation.x,this.transform.rotation.y,this.transform.rotation.z+Mathf.PI/180*20,this.transform.rotation.w));
				bullets[1] = (GameObject)Instantiate (bullet,this.transform.position,new Quaternion(this.transform.rotation.x,this.transform.rotation.y,this.transform.rotation.z+Mathf.PI/180*10,this.transform.rotation.w));
				bullets[2] = (GameObject)Instantiate (bullet,this.transform.position,new Quaternion(this.transform.rotation.x,this.transform.rotation.y,this.transform.rotation.z+0,this.transform.rotation.w));
				bullets[3] = (GameObject)Instantiate (bullet,this.transform.position,new Quaternion(this.transform.rotation.x,this.transform.rotation.y,this.transform.rotation.z-Mathf.PI/180*10,this.transform.rotation.w));
				bullets[4] = (GameObject)Instantiate (bullet,this.transform.position,new Quaternion(this.transform.rotation.x,this.transform.rotation.y,this.transform.rotation.z-Mathf.PI/180*20,this.transform.rotation.w));
				
				yield return new WaitForSeconds(0.1f);
			}
			Destroy(division_bullet);
			yield return null;

		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
