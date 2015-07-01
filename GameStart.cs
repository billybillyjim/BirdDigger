using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {

	public Chunk c = new Chunk();

	// Use this for initialization
	void Start () {
	
		makeChunk ();

	}

	private void makeChunk(){

		c.loadChunk ();


	}


}
