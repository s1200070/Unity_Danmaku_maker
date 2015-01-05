using UnityEngine;
using System.Collections;

public class nway_01 : MonoBehaviour {

	public Quaternion radius;
	public int num;
	public GameObject Enemy;
	public int speed;
	float x=0;
	float y=0;
	public GameObject bullet;
	private GameObject[] bullets = new GameObject[5];



	// Use this for initialization
	IEnumerator Start () {
		while(true){
		for(int i=0;i<4;i++){
			
			//bullets[i] = bullet;
			//bullets[i] = (GameObject)Instantiate (bullet,this.transform.position,this.transform.rotation);
				bullets[0] = (GameObject)Instantiate (bullet,this.transform.position,new Quaternion(this.transform.rotation.x,this.transform.rotation.y,this.transform.rotation.z+Mathf.PI/180*20,this.transform.rotation.w));
				bullets[1] = (GameObject)Instantiate (bullet,this.transform.position,new Quaternion(this.transform.rotation.x,this.transform.rotation.y,this.transform.rotation.z+Mathf.PI/180*10,this.transform.rotation.w));
				bullets[2] = (GameObject)Instantiate (bullet,this.transform.position,new Quaternion(this.transform.rotation.x,this.transform.rotation.y,this.transform.rotation.z+0,this.transform.rotation.w));
				bullets[3] = (GameObject)Instantiate (bullet,this.transform.position,new Quaternion(this.transform.rotation.x,this.transform.rotation.y,this.transform.rotation.z-Mathf.PI/180*10,this.transform.rotation.w));
				bullets[4] = (GameObject)Instantiate (bullet,this.transform.position,new Quaternion(this.transform.rotation.x,this.transform.rotation.y,this.transform.rotation.z-Mathf.PI/180*20,this.transform.rotation.w));


			yield return new WaitForSeconds(0.05f);
		}
			yield return new WaitForSeconds(0.5f);
			yield return null;
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
