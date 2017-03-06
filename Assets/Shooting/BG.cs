using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// 배경 스크롤 처리한다.
/// </summary>
public class BG : MonoBehaviour {
	public float scrollSpeed = 0.2f;
	MeshRenderer mr;
	// Use this for initialization
	void Start () {
		mr = gameObject.GetComponent<MeshRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {
		
		mr.material.mainTextureOffset += Vector2.up * scrollSpeed * Time.deltaTime;
	}
}
