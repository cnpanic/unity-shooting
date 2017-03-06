using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}

	
	// Update is called once per frame
	void Update () {
	// 사용자의 입력을 받아서 움직이도록 한다.
	// 1. 사용자의 입력
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

	// 2. 움직일 방향찾기
	// 3. 이동시키기
		Vector3 dir = Vector3.right * h + Vector3.up * v;
		transform.Translate (dir * speed * Time.deltaTime);
	//	transform.Translate (Vector3.left * 5 * Time.deltaTime);
	//  transform.Translate (Vector3.forward * 5 * Time.deltaTime);
	//	transform.Translate (Vector3.back * 5 * Time.deltaTime);

	}
}
