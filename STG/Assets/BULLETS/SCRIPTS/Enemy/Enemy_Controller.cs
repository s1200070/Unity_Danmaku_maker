using UnityEngine;
using System.Collections;

// 敵のAIに関するスクリプトです。インスペクタから敵がどのタイミングからどの弾幕を発射するか指定できます。
public class Enemy_Controller : MonoBehaviour {


	public GameObject[] Enemy_Bullet = new GameObject[100];//とりあえず100発撃てるようにしておく 
	public float waittime = 1f;//何秒間隔で撃ちたいか
	public float Enemy_HP = 10; //自分のHPがいくつ削られたら次の弾幕に遷移するか
	private bool isShot = false;
	int current = 1;
	private GameObject Enemy; 
	private bool isAdded = false;
	int i = 1;
	// Use this for initialization
	IEnumerator Start () {
		i=1;

		while(true){
			if(current==i&&current!=Enemy_Bullet.Length)
			{
				//Debug.Log(i);

				Debug.Log("Enemy_Destroy.HP="+Enemy_Destroy.HP);
				Debug.Log("Enemy_Destroy.startHP-Enemy_HP*i="+(Enemy_Destroy.startHP-Enemy_HP*i));
				Debug.Log("Enemy_HP*(i+1)="+(Enemy_HP*(i+1)));

			if(Enemy_Destroy.HP<=Enemy_Destroy.startHP-Enemy_HP*i&&Enemy_Destroy.HP>Enemy_Destroy.startHP-Enemy_HP*(i+1)&&isShot==false){
				Enemy = (GameObject)Instantiate(Enemy_Bullet[i-1],this.transform.position,this.transform.rotation);
				isShot = true;
				isAdded = false;
				yield return new WaitForSeconds(waittime);
				}

			
			if(Enemy_Destroy.HP<Enemy_Destroy.startHP-Enemy_HP*(i+1)){
				Destroy(Enemy.gameObject);
					if(isAdded == false){
						current += 1;
						i++;
						isAdded = true;
						isShot = false;
					}
				}
			}

			yield return null;
		}
		yield return null;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
