using UnityEngine;
using System.Collections;

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
	public bool FullRandom = false;
	public int RandomSeed = 12345;
	public GameObject Floor = null;
	public GameObject Wall = null;
	public GameObject Pillar = null;
	public int Rows = 5;
	public int Columns = 5;
	public float CellWidth = 5;
	public float CellHeight = 5;
	public bool AddGaps = true;
	private bool enteredLabyrinth = false;

	public void DeleteAllSavedData() { // it is required to delete all saved data, after initial enter to the maze, data must be refreshed.
		PlayerPrefs.DeleteAll ();
	}

	void Start () {
		// enteredLabyrinth let us know, whether the player enters the maze for the first time.
		if (PlayerPrefs.GetInt ("enteredLabyrinth", 0) != null) {
			enteredLabyrinth = PlayerPrefs.GetInt ("enteredLabyrinth", 0) != 0;
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
			for(int column = 0; column < Columns; column++){
				float x = column*(CellWidth+(AddGaps? .2f : 0));
				float z = row*(CellHeight+(AddGaps? .2f : 0));

				GameObject tmp;
				tmp = Instantiate(Floor,new Vector3(x,0,z), Quaternion.Euler(0,0,0)) as GameObject;
				tmp.transform.parent = transform;
				tmp.name = "Floor_Column" + column.ToString() + "_Row" + row.ToString();

				string wallDirection = "Wall_At_Column" + column.ToString() + "_Row" + row.ToString();
				if(!enteredLabyrinth) { // this is required to save directions of walls per cell.
					MazeCell cell = mMazeGenerator.GetMazeCell(row,column);
					PlayerPrefs.SetInt(wallDirection+"_Right", cell.WallRight ? 1 : 0);
					PlayerPrefs.SetInt(wallDirection+"_Front", cell.WallFront ? 1 : 0);
					PlayerPrefs.SetInt(wallDirection+"_Left", cell.WallLeft ? 1 : 0);
					PlayerPrefs.SetInt(wallDirection+"_Back", cell.WallBack ? 1 : 0);
				}

				WallPlacement wallPlacement; // so once directions of walls per cell are saved, next time the player enters the maze, the same maze with the same wall directions per cell will be generated.

				wallPlacement.WallRight = PlayerPrefs.GetInt(wallDirection+"_Right", 0) != 0;
				wallPlacement.WallFront = PlayerPrefs.GetInt(wallDirection+"_Front", 0) != 0;
				wallPlacement.WallLeft = PlayerPrefs.GetInt(wallDirection+"_Left", 0) != 0;
				wallPlacement.WallBack = PlayerPrefs.GetInt(wallDirection+"_Back", 0) != 0;

				if(wallPlacement.WallRight){
					tmp = Instantiate(Wall,new Vector3(x+CellWidth/2,0,z)+Wall.transform.position,Quaternion.Euler(0,90,0)) as GameObject;// right
					tmp.transform.parent = transform;
				}
				if(wallPlacement.WallFront){
					tmp = Instantiate(Wall,new Vector3(x,0,z+CellHeight/2)+Wall.transform.position,Quaternion.Euler(0,0,0)) as GameObject;// front
					tmp.transform.parent = transform;
				}
				if(wallPlacement.WallLeft){
					tmp = Instantiate(Wall,new Vector3(x-CellWidth/2,0,z)+Wall.transform.position,Quaternion.Euler(0,270,0)) as GameObject;// left
					tmp.transform.parent = transform;
				}
				if(wallPlacement.WallBack) {
					tmp = Instantiate(Wall,new Vector3(x,0,z-CellHeight/2)+Wall.transform.position,Quaternion.Euler(0,180,0)) as GameObject;// back
					tmp.transform.parent = transform;
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
				}
			}
		}
		enteredLabyrinth = true;
		PlayerPrefs.SetInt("enteredLabyrinth", enteredLabyrinth ? 1 : 0);
		if (PlayerPrefs.GetInt ("RowsCount", 0) == 0 && PlayerPrefs.GetInt ("ColumnsCount", 0) == 0) {
			PlayerPrefs.SetInt ("RowsCount", Rows);
			PlayerPrefs.SetInt ("ColumnsCount", Columns);
		}
	}
}
