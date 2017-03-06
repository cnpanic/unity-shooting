using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGod : MonoBehaviour {
	public float createTime = 2;
	float currentTime = 0;
	public GameObject enemyPrefab;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		// if currentTime 값이 createTime 보다 크면
		if (currentTime > createTime) {
			// enemy 생성
			GameObject enemy = Instantiate(enemyPrefab);
			// enemy 위치 지정
			enemy.transform.position = transform.position;
			currentTime = 0;

		}

	}
}
