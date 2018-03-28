using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidFollow : MonoBehaviour {
    private GameObject followTarget;
    private GameObject asteroid;
	// Use this for initialization
	void Start () {
        followTarget = GameObject.Find("Player");
        asteroid = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
