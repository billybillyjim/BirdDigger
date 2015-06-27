using UnityEngine;
using System.Collections;

public class Chunk : MonoBehaviour {

	private int chunkWidth = 16;
	private int chunkHeight = 16;

	private int chunkType;

	public Chunk(int chunkType){
		for (int i = 0; i < chunkWidth; i++) {
			for(int j = 0; j < chunkHeight; j++){
				Instantiate(new Block(1,i,j), new Vector3(i,j,0), Quaternion.identity);
			}
		}
	}

}
 