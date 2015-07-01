using UnityEngine;
using UnityEditor;
using System.Collections;

public class Block : MonoBehaviour {

	private Sprite blockSprite;  	//The sprite for the block
	private int blockType;			//The int tells which block the constructor should make
	private int hitsToBreak;		//One hit per unit
	private int blockX;
	private int blockY;

	public void Start(){

		this.blockSprite = gameObject.GetComponent<Sprite> ();

	}

	public void setBlockXAndY(int i, int j){
		this.blockX = i;
		this.blockY = j;
	}

	public string ToString(){
	
		return (this.blockX.ToString () + ", " + this.blockY.ToString ());
	}
}
