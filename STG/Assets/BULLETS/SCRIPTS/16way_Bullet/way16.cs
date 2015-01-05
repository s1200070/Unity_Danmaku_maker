using UnityEngine;
using System.Collections;

public class way16 : MonoBehaviour {

	
	public GameObject Enemy;
	
	private float ex;
	private float ey;
	
	private float x;
	private float y; 
	
	private float vx;
	private float vy;
	
	float speed = 0.1f;
	float theta;

	//int[,] v8 = new int[8, 2];

	
	// Use this for initialization
	IEnumerator Start () {
		int[,] v3 = new int[16,2] {
			
			{3,0},{3,1},{2,2},{1,3},
			{0,3},{-1,3},{-2,2},{-3,1},
			{-3,0},{-3,-1},{-2,-2},{-1,-3},
			{0,-3},{1,3},{2,-2},{3,-1}
		};
		int dir = (int)(theta*16/360);
		
		
		ex = Enemy.transform.position.x;
		ey = Enemy.transform.position.y;
		x = ex;
		y = ey;
		//vx = Mathf.Cos(Mathf.PI/180*theta)*speed;
		//vy = Mathf.Sin(Mathf.PI/180*theta)*speed;

		vx = v3[dir,0];
		vy = v3[dir,1];
		while(true) {
			
			x += vx;
			y += vy;
			
			this.transform.position = new Vector2(x,y);
			
			yield return null;
		}
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
	}
}
