using UnityEngine;
using System.Collections;

public class Tail : MonoBehaviour {

	public GameObject player;
	// Player의 이동 속력
	public float speed = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// 1. 나는 플레이어를 따라 다니고 싶다.
		//    Player 가 어디에 있는지 찾자
		Vector3 playerPos = player.transform.position;
		//    Player 가 위치한 방향을 찾자
		Vector3 myPos = transform.position;
		// 	  targetVector =  player - me;
		//    따라가기 위한 방향
		Vector3 dir = playerPos - myPos;
		//    크기를 1로 만들어 주어야 한다.
		dir.Normalize();
		//    찾은 방향으로 이동하자
		//    Time.deltaTime = 한번 도는데 걸리는 시간
		transform.Translate(dir * 5 * Time.deltaTime);
		// 위와 같지만 
		// P = P(0) + vt
		//transform.position = transform.position + dir * 5 * Time.deltaTime; 

	}
}
