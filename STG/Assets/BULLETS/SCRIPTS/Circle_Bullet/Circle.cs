using UnityEngine;
using System.Collections;

public class Circle : MonoBehaviour {

	// Use this for initialization
	
	public float radius;
	public int num;
	public GameObject Enemy;
	public int speed;
	float x=0;
	float y=0;
	int i=0;
	public GameObject bullet;
	private GameObject[] bullets = new GameObject[14];
	
	
	
	// Use this for initialization
	IEnumerator Start () {
		while(true){
			for(int i=0;i<4;i++){


				transform.rotation = Quaternion.Euler(0,0 , 360/10*1);
				bullets[0] = (GameObject)Instantiate (bullet,this.transform.position,this.transform.rotation);
				
				transform.rotation = Quaternion.Euler(0,0 ,360/10*2);
				bullets[1] = (GameObject)Instantiate (bullet,this.transform.position,this.transform.rotation);

				
				transform.rotation = Quaternion.Euler(0,0, 360/10*3);
				bullets[2] = (GameObject)Instantiate (bullet,this.transform.position,this.transform.rotation);

				
				transform.rotation = Quaternion.Euler(0,0, 360/10*4);
				bullets[3] = (GameObject)Instantiate (bullet,this.transform.position,this.transform.rotation);

				
				transform.rotation = Quaternion.Euler(0,0, 360/10*5);
				bullets[4] = (GameObject)Instantiate (bullet,this.transform.position,this.transform.rotation);

				transform.rotation = Quaternion.Euler(0,0 , 360/10*6);
				bullets[5] = (GameObject)Instantiate (bullet,this.transform.position,this.transform.rotation);
				
				transform.rotation = Quaternion.Euler(0,0 ,360/10*7);
				bullets[6] = (GameObject)Instantiate (bullet,this.transform.position,this.transform.rotation);
				
				
				transform.rotation = Quaternion.Euler(0,0, 360/10*8);
				bullets[7] = (GameObject)Instantiate (bullet,this.transform.position,this.transform.rotation);
				
				
				transform.rotation = Quaternion.Euler(0,0, 360/10*9);
				bullets[8] = (GameObject)Instantiate (bullet,this.transform.position,this.transform.rotation);
				
				
				transform.rotation = Quaternion.Euler(0,0, 360/10*10);
				bullets[9] = (GameObject)Instantiate (bullet,this.transform.position,this.transform.rotation);



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
