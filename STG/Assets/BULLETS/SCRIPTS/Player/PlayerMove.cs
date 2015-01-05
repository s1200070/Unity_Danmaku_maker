using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	// Spaceshipコンポーネント
	float speed = 4.2f;

	void Update ()
	{
		// 右・左
		float x = Input.GetAxisRaw ("Horizontal");
		
		// 上・下
		float y = Input.GetAxisRaw ("Vertical");
		
		// 移動する向きを求める
		Vector2 direction = new Vector2 (x, y).normalized;

		// 移動の制限
		Move (direction);
		
	}
	
	// 機体の移動
	void Move (Vector2 direction)
	{
		// 画面左下のワールド座標をビューポートから取得
		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
		
		// 画面右上のワールド座標をビューポートから取得
		Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
		
		// プレイヤーの座標を取得
		Vector2 pos = transform.position;
		
		// 移動量を加える
		pos += direction  * speed * Time.deltaTime;
		//Debug.Log(pos.x);

		// プレイヤーの位置が画面内に収まるように制限をかける
		pos.x = Mathf.Clamp (pos.x, -3, 3);
		pos.y = Mathf.Clamp (pos.y, -5, 5);

		//Debug.Log(pos.x);
		
		// 制限をかけた値をプレイヤーの位置とする
		this.transform.position = pos;
	}
	
	// ぶつかった瞬間に呼び出される

}
