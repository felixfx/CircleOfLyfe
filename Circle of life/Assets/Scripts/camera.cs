﻿using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position + new Vector3(-5, 5, 10);
        transform.LookAt(player.transform.position);

	}
}
