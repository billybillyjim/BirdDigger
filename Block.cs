using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	private Sprite blockSprite;  	//The sprite for the block
	private int blockType;			//The int tells which block the constructor should make
	private int hitsToBreak;		//One hit per unit
	private int[,] blockLocation;


	/**
	 * This is going to be called whenever a new chunk is made and a bunch
	 * of new blocks are made with it.
	 * 
	 * blocktype -- Defines the type of block by a switch statement which isn't written yet.
	 **/
	public Block(int blockType, int x, int y){	

		this.blockType = blockType;
		this.blockLocation = new int[x,y];



	}

}
