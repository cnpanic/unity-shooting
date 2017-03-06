using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Destroy zone 영역에 들어오는 object는 다 없앤다.
public class DestroyZone : MonoBehaviour {
	void OnTriggerEnter(Collider other)
	{
		Destroy (other.gameObject);
	}
}
