using UnityEngine;
using System.Collections;

public class Move_Circle_Bullet : MonoBehaviour {

	public GameObject bullet0;
	public GameObject bullet1;
	public GameObject center;
	private GameObject[] bullets = new GameObject[10];
	private GameObject[] bullets2 = new GameObject[10];
	private GameObject[] bullets3 = new GameObject[10];
	private GameObject[] bullets4 = new GameObject[10];
	private GameObject[] bullets5 = new GameObject[10];
	
	
	
	//float x;
	//float y;
	//float x1;
	//float y2;
	
	float[] x = new float[10];
	float[] y = new float[10];
	
	float[] x2 = new float[10];
	float[] y2 = new float[10];
	
	float[] x3 = new float[10];
	float[] y3 = new float[10];
	
	float[] x4 = new float[10];
	float[] y4 = new float[10];
	
	float[] x5 = new float[10];
	float[] y5 = new float[10];
	
	
	float vx;
	float vy;
	
	//float cx;
	//float cy=3;
	//float cx=this.gameObject.transform.position.x;
	//float cy=this.transform.position.y;
	
	float r = 1.0f;
	float r2 = 1.3f;
	float r3 = 1.6f;
	float r4 = 1.9f;
	float r5 = 2.2f;
	
	float theta = 0.1f;
	float omega = -0.01f;
	
	float theta2 = 0.1f;
	
	int i = 0;
	
	// Use this for initialization
	void Start () {
		
		bullets[0] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		bullets[1] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		bullets[2] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		bullets[3] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		bullets[4] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		bullets[5] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		bullets[6] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		bullets[7] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		bullets[8] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		
		bullets2[0] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		bullets2[1] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		bullets2[2] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		bullets2[3] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		bullets2[4] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		bullets2[5] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		bullets2[6] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		bullets2[7] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		bullets2[8] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
		
		for(i=0;i<=8;i++){
			bullets3[i] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
			
		}
		for(i=0;i<=8;i++){
			bullets4[i] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
			
		}
		for(i=0;i<=8;i++){
			bullets5[i] = (GameObject)Instantiate(bullet0,this.transform.position,this.transform.rotation);
			
		}
		
	}
	
	// Update is called once per frame
	void Update () {


		float cx=this.gameObject.transform.position.x;
		float cy=this.transform.position.y;
		
		theta += omega;
		theta2 += omega;

		//r += 0.1f
		
		x[0] = cx+r*Mathf.Cos(theta);
		y[0] = cy+r*Mathf.Sin(theta);
		x[1] = cx+r*Mathf.Cos(theta+Mathf.PI*2/9);
		y[1]= cy+r*Mathf.Sin(theta+Mathf.PI*2/9);
		x[2] = cx+r*Mathf.Cos(theta+Mathf.PI*2/9*2);
		y[2] = cy+r*Mathf.Sin(theta+Mathf.PI*2/9*2);
		x[3] = cx+r*Mathf.Cos(theta+Mathf.PI*2/9*3);
		y[3]= cy+r*Mathf.Sin(theta+Mathf.PI*2/9*3);
		x[4] = cx+r*Mathf.Cos(theta+Mathf.PI*2/9*4);
		y[4] = cy+r*Mathf.Sin(theta+Mathf.PI*2/9*4);
		x[5] = cx+r*Mathf.Cos(theta+Mathf.PI*2/9*5);
		y[5]= cy+r*Mathf.Sin(theta+Mathf.PI*2/9*5);
		x[6] = cx+r*Mathf.Cos(theta+Mathf.PI*2/9*6);
		y[6] = cy+r*Mathf.Sin(theta+Mathf.PI*2/9*6);
		x[7] = cx+r*Mathf.Cos(theta+Mathf.PI*2/9*7);
		y[7]= cy+r*Mathf.Sin(theta+Mathf.PI*2/9*7);
		x[8] = cx+r*Mathf.Cos(theta+Mathf.PI*2/9*8);
		y[8]= cy+r*Mathf.Sin(theta+Mathf.PI*2/9*8);
		
		x2[0] = cx+r2*Mathf.Cos(-theta);
		y2[0] = cy+r2*Mathf.Sin(-theta);
		x2[1] = cx+r2*Mathf.Cos(-theta+Mathf.PI*2/9);
		y2[1]= cy+r2*Mathf.Sin(-theta+Mathf.PI*2/9);
		x2[2] = cx+r2*Mathf.Cos(-theta+Mathf.PI*2/9*2);
		y2[2] = cy+r2*Mathf.Sin(-theta+Mathf.PI*2/9*2);
		x2[3] = cx+r2*Mathf.Cos(-theta+Mathf.PI*2/9*3);
		y2[3]= cy+r2*Mathf.Sin(-theta+Mathf.PI*2/9*3);
		x2[4] = cx+r2*Mathf.Cos(-theta+Mathf.PI*2/9*4);
		y2[4] = cy+r2*Mathf.Sin(-theta+Mathf.PI*2/9*4);
		x2[5] = cx+r2*Mathf.Cos(-theta+Mathf.PI*2/9*5);
		y2[5]= cy+r2*Mathf.Sin(-theta+Mathf.PI*2/9*5);
		x2[6] = cx+r2*Mathf.Cos(-theta+Mathf.PI*2/9*6);
		y2[6] = cy+r2*Mathf.Sin(-theta+Mathf.PI*2/9*6);
		x2[7] = cx+r2*Mathf.Cos(-theta+Mathf.PI*2/9*7);
		y2[7]= cy+r2*Mathf.Sin(-theta+Mathf.PI*2/9*7);
		x2[8] = cx+r2*Mathf.Cos(-theta+Mathf.PI*2/9*8);
		y2[8]= cy+r2*Mathf.Sin(-theta+Mathf.PI*2/9*8);
		
		for(i=0;i<=8;i++){
			x3[i] = cx+r3*Mathf.Cos(theta+Mathf.PI*2/9*i);
			y3[i]= cy+r3*Mathf.Sin(theta+Mathf.PI*2/9*i);
			
		}
		for(i=0;i<=8;i++){
			x4[i] = cx+r4*Mathf.Cos(-theta+Mathf.PI*2/9*i);
			y4[i]= cy+r4*Mathf.Sin(-theta+Mathf.PI*2/9*i);
			
		}
		for(i=0;i<=8;i++){
			x5[i] = cx+r5*Mathf.Cos(theta+Mathf.PI*2/9*i);
			y5[i]= cy+r5*Mathf.Sin(theta+Mathf.PI*2/9*i);
			
		}
		
		
		bullets[0].transform.position = new Vector3(x[0],y[0],0);
		bullets[1].transform.position = new Vector3(x[1],y[1],0);
		bullets[2].transform.position = new Vector3(x[2],y[2],0);
		bullets[3].transform.position = new Vector3(x[3],y[3],0);
		bullets[4].transform.position = new Vector3(x[4],y[4],0);
		bullets[5].transform.position = new Vector3(x[5],y[5],0);
		bullets[6].transform.position = new Vector3(x[6],y[6],0);
		bullets[7].transform.position = new Vector3(x[7],y[7],0);
		bullets[8].transform.position = new Vector3(x[8],y[8],0);
		
		bullets2[0].transform.position = new Vector3(x2[0],y2[0],0);
		bullets2[1].transform.position = new Vector3(x2[1],y2[1],0);
		bullets2[2].transform.position = new Vector3(x2[2],y2[2],0);
		bullets2[3].transform.position = new Vector3(x2[3],y2[3],0);
		bullets2[4].transform.position = new Vector3(x2[4],y2[4],0);
		bullets2[5].transform.position = new Vector3(x2[5],y2[5],0);
		bullets2[6].transform.position = new Vector3(x2[6],y2[6],0);
		bullets2[7].transform.position = new Vector3(x2[7],y2[7],0);
		bullets2[8].transform.position = new Vector3(x2[8],y2[8],0);
		
		for(i=0;i<=8;i++){
			bullets3[i].transform.position = new Vector3(x3[i],y3[i],0);
			
		}
		for(i=0;i<=8;i++){
			bullets4[i].transform.position = new Vector3(x4[i],y4[i],0);
			
		}
		for(i=0;i<=8;i++){
			bullets5[i].transform.position = new Vector3(x5[i],y5[i],0);
			
		}

		r += 0.03f;
		r2 += 0.03f;
		r3 += 0.03f;
		r4 += 0.03f;
		r5 += 0.03f;

		Debug.Log (x[0]);
		
		//vx = -r*omega*Mathf.Sin(theta);
		//vy = r*omega*Mathf.Cos(theta);
	}
}
