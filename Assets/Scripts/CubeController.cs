using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	// キューブの移動速度
	private float speed = -0.2f;

	// 消滅位置
	private float deadLine = -10;

	// Use this for initialization
	void Start(){
	}

	// Update is called once per frame
	void Update () {
		// キューブを移動させる
		transform.Translate (this.speed, 0, 0);

		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine){
			Destroy (gameObject);
		}
	}

	//キューブの接触時に効果音をつけ課題
	void OnCollisionEnter2D(Collision2D other)
	{
		//キューブが地面に接触する時とキューブ同士が積み重なるときのみに効果音を鳴らす。
		//ユニティちゃんなどは例外の為、効果音が鳴らない。
		if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Cube")
			GetComponent<AudioSource> ().Play ();
	}
}
