using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
	public GameObject bulletPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// 사용자가 mouse left Button click or left ctrl key push
		// 1. if mouse left clicked
		// 2. make a Bullet
		// 3. locationing Bullet
		if (Input.GetButtonDown ("Fire1")){	
			// bullet 생
			GameObject bullet = Instantiate(bulletPrefab);
			bullet.transform.position = transform.position;
		}
	}
}
