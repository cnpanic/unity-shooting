using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//public = 외부용
//Enemy가 아래로 내려오도록 하고 싶다.
// 1.폭발 prefab 공장 주소
// 2.폭발 만들기
// 3.위치 지정
public class Enemy : MonoBehaviour {
	public GameObject player;
	public GameObject explosionprefab;
	public float speed = 5.0f;
	Vector3 dir;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");

		Vector3 playerPos = player.transform.position;
		Vector3 myPos = transform.position; 
		dir = playerPos - myPos;
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (Vector3.right * speed  * Time.deltaTime);
			transform.Translate(dir * speed * Time.deltaTime);
	}
	//충돌하면 제거한다.
	//누군가와 충돌시 발생하는 함수
	void OnCollisionEnter(Collision other)
	{
		Destroy (other.gameObject); // 충돌한 other인 gameObject 를 제거한다.'
		Destroy (gameObject);
		GameObject explosion = Instantiate(explosionprefab);
		explosion.transform.position = transform.position;

	}
}

