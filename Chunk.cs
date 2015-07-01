using UnityEngine;
using System.Collections;

public class Chunk : MonoBehaviour {

	private int chunkWidth = 16;
	private int chunkHeight = 16;

	public Block block = new Block();

	private Block[,] blockGrid = new Block[16,16];


	private int chunkType;

	public void Start(){
		for (int i = 0; i < chunkWidth; i++) {
			for(int j = 0; j < chunkHeight; j++){
				blockGrid[i,j] = block;
				blockGrid[i,j].setBlockXAndY(i,j);
				Debug.Log ("Chunk is started, and blockGrid[i,j] is " + blockGrid[i,j].ToString());

			}
		}
	}

	public void loadChunk(){
		for (int i = 0; i < chunkWidth; i++) {
			for(int j = 0; j < chunkHeight; j++){

				Instantiate(blockGrid[i,j], new Vector3(i,j,0),Quaternion.identity);
				
				
			}
		}
	
	}

	/*
	public Chunk(int chunkType){
		for (int i = 0; i < chunkWidth; i++) {
			for(int j = 0; j < chunkHeight; j++){


				Instantiate(block, new Vector3(i,j,0), Quaternion.identity);
				block.setBlockXAndY(i,j);
			}
		}
	}
	public Chunk(){
		for (int i = 0; i < chunkWidth; i++) {
			for(int j = 0; j < chunkHeight; j++){
				

				Instantiate(block, new Vector3(i,j,0), Quaternion.identity);
				block.setBlockXAndY(i,j);
			}
		}
	}
	*/
}
 