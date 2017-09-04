using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {
	public Transform fpp; // first person player

	// Use this for initialization
	void Start () {
		#if UNITY_STANDALONE
		Instantiate(fpp, new Vector3(0, 0.788f, -1.5f), Quaternion.identity);
		fpp.Find("MainCamera").transform.SetPositionAndRotation(new Vector3(0, 1.5f, 0), Quaternion.identity);
		#endif
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
