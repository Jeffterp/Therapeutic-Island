using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour {
	public Terrain terrain;
	// Use this for initialization
	void Start () {
		Terrain terrain_clone = Instantiate (terrain); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
