using UnityEngine;
using System.Collections;

public class Scene1_Enemy : MonoBehaviour {

	public GameObject Bullet_5way;
	public GameObject Bullet_div;
	public GameObject Bullet_Circle_rotate;
	private bool isShot = false;

	private GameObject Enemy;

	// Use this for initialization
	 IEnumerator Start () {

		while(true){


			if(Enemy_Destroy.HP==99980&&isShot==false){
				Enemy = (GameObject)Instantiate(Bullet_5way, this.transform.position, this.transform.rotation);
				isShot = true;
			}
			if(Enemy_Destroy.HP==99960){
				Destroy(Enemy);
				isShot = false;
			}


			if(Enemy_Destroy.HP<=99950&&Enemy_Destroy.HP>99910&&isShot==false){
				Enemy = (GameObject)Instantiate(Bullet_div,this.transform.position, this.transform.rotation);
				isShot = true;
				yield return new WaitForSeconds(1.0f);
				isShot = false;
			}
			if(Enemy_Destroy.HP==99910){
				Destroy(Enemy);
				isShot = false;

			}

			if(Enemy_Destroy.HP<=99910&&Enemy_Destroy.HP>99890&&isShot==false){
				Enemy = (GameObject)Instantiate(Bullet_Circle_rotate,this.transform.position,this.transform.rotation);
				isShot = true;
				yield return new WaitForSeconds(1.0f);
				isShot = false;
			}
			if(Enemy_Destroy.HP==99890){
				Destroy(Enemy);
				isShot = false;
				
			}

			yield return null;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
