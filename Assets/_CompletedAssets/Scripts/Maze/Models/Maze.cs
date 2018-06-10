using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Linq;
using MeezumGame;

//<summary>
//Game object, that creates maze and instantiates it in scene
//</summary>
public class Maze : MonoBehaviour {
	public struct WallPlacement {
		public bool WallRight;
		public bool WallFront;
		public bool WallLeft;
		public bool WallBack;
	}

	private BasicMazeGenerator mMazeGenerator = null;
	public bool FullRandom = true;
	public int RandomSeed = 3;
	public GameObject Floor = null;
	public GameObject Wall = null;
	public GameObject Pillar = null;
	public int Rows = 10;
	public int Columns = 10;
	public float CellWidth = 4;
	public float CellHeight = 4;
	public bool AddGaps = false;
	private bool enteredLabyrinth = false;
	private XElement maze;


	void putWallDirectionForCell(string wallDirectionKey, bool wallDirection) {
		if (maze.Element (wallDirectionKey) != null) {
			maze.Element (wallDirectionKey).Value = wallDirection ? 1.ToString () : 0.ToString ();
		} else {
			maze.Add (new XElement (wallDirectionKey, wallDirection ? 1 : 0));
		}
	}

	bool checkWallDirectionForCell(string wallDirectionKey) {
		if (maze.Element (wallDirectionKey).Value == "0") {
			return false;
		} else {
			return true;
		}
	}

	void Start () {
		maze = RollerBall.maze;
		if (maze.Element ("enteredLabyrinth") == null) {
			maze.Add (new XElement ("enteredLabyrinth", enteredLabyrinth ? 1 : 0));
			maze.Add (new XElement("RowsCount", Rows));
			maze.Add (new XElement("ColumnsCount", Columns));
			RollerBall.mManager.SaveMissions ();
		}

		// enteredLabyrinth let us know, whether the player enters the maze for the first time.
		if (maze.Element ("enteredLabyrinth") != null) {
			if (maze.Element ("enteredLabyrinth").Value == "0") {
				enteredLabyrinth = false;
			} else {
				enteredLabyrinth = true;
			}
		}

		// If the player enters the maze for the first time, the new maze will be generated, after iterative entering the previous generated model will be presented.
		if (!enteredLabyrinth) {
			if (!FullRandom) {
				Random.seed = RandomSeed;
			}
			mMazeGenerator = new RecursiveTreeMazeGenerator (Rows, Columns);
			mMazeGenerator.GenerateMaze ();
		}

		for (int row = 0; row < Rows; row++) {
			for(int column = 0; column < Columns; column++) {
				float x = column*(CellWidth+(AddGaps? .2f : 0));
				float z = row*(CellHeight+(AddGaps? .2f : 0));

				GameObject tmp;
				tmp = Instantiate(Floor,new Vector3(x,0,z), Quaternion.Euler(0,0,0)) as GameObject;
				tmp.transform.parent = transform;
				tmp.name = "Floor_Column" + column.ToString() + "_Row" + row.ToString();

				string wallDirection = "Wall_At_Column" + column.ToString() + "_Row" + row.ToString();
				if (!enteredLabyrinth) { // this is required to save directions of walls per cell.
					MazeCell cell = mMazeGenerator.GetMazeCell (row, column);
					putWallDirectionForCell (wallDirection + "_Right", cell.WallRight);
					putWallDirectionForCell (wallDirection + "_Front", cell.WallFront);
					putWallDirectionForCell (wallDirection + "_Left", cell.WallLeft);
					putWallDirectionForCell (wallDirection + "_Back", cell.WallBack);
					RollerBall.mManager.SaveMissions ();
				}

				WallPlacement wallPlacement; // so once directions of walls per cell are saved, next time the player enters the maze, the same maze with the same wall directions per cell will be generated.
				wallPlacement.WallRight = checkWallDirectionForCell(wallDirection + "_Right");
				wallPlacement.WallFront = checkWallDirectionForCell(wallDirection + "_Front");
				wallPlacement.WallLeft = checkWallDirectionForCell(wallDirection + "_Left");
				wallPlacement.WallBack = checkWallDirectionForCell(wallDirection + "_Back");

				if(wallPlacement.WallRight){
					tmp = Instantiate(Wall,new Vector3(x+CellWidth/2,0,z)+Wall.transform.position,Quaternion.Euler(0,90,0)) as GameObject;// right
					tmp.transform.parent = transform;
					tmp.GetComponent<Renderer> ().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
					tmp.GetComponent<Renderer> ().receiveShadows = false;
				}
				if(wallPlacement.WallFront){
					tmp = Instantiate(Wall,new Vector3(x,0,z+CellHeight/2)+Wall.transform.position,Quaternion.Euler(0,0,0)) as GameObject;// front
					tmp.transform.parent = transform;
					tmp.GetComponent<Renderer> ().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
					tmp.GetComponent<Renderer> ().receiveShadows = false;
				}
				if(wallPlacement.WallLeft){
					tmp = Instantiate(Wall,new Vector3(x-CellWidth/2,0,z)+Wall.transform.position,Quaternion.Euler(0,270,0)) as GameObject;// left
					tmp.transform.parent = transform;
					tmp.GetComponent<Renderer> ().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
					tmp.GetComponent<Renderer> ().receiveShadows = false;
				}
				if(wallPlacement.WallBack) {
					tmp = Instantiate(Wall,new Vector3(x,0,z-CellHeight/2)+Wall.transform.position,Quaternion.Euler(0,180,0)) as GameObject;// back
					tmp.transform.parent = transform;
					tmp.GetComponent<Renderer> ().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
					tmp.GetComponent<Renderer> ().receiveShadows = false;
				}
			}
		}

		if(Pillar != null){
			for (int row = 0; row < Rows+1; row++) {
				for (int column = 0; column < Columns+1; column++) {
					float x = column*(CellWidth+(AddGaps? .2f : 0));
					float z = row*(CellHeight+(AddGaps? .2f : 0));
					GameObject tmp = Instantiate(Pillar,new Vector3(x-CellWidth/2,0,z-CellHeight/2),Quaternion.identity) as GameObject;
					tmp.transform.parent = transform;
					tmp.GetComponent<Renderer> ().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
					tmp.GetComponent<Renderer> ().receiveShadows = false;
				}
			}
		}

		if (maze.Element ("enteredLabyrinth").Value == "0") {
			maze.Element ("enteredLabyrinth").Value = 1.ToString ();
		}

		if (Rows != 0 && Columns != 0) {
			maze.Element ("RowsCount").Value = Rows.ToString ();
			maze.Element ("ColumnsCount").Value = Columns.ToString ();
		}
		RollerBall.mManager.SaveMissions ();
	}
}
