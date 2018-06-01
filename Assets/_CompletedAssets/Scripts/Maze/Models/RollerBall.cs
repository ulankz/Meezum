using UnityEngine;
using System;
using System.Collections;
using UnityEngine.SceneManagement;
using MeezumGame;
using UnityEngine.UI;
using UnityEngine.Events;

//<summary>
//Ball movement controlls and simple third-person-style camera
//</summary>
public class RollerBall : MonoBehaviour {

	public GameObject ViewCamera = null;
	public AudioClip HitSound = null;

	private AudioSource mAudioSource = null;
	private bool mFloorTouched = false;

	private int playerPosX = 0;
	private int playerPosZ = 0;

	string previousStep;
	Color defaultFloorColor;

	private int turnsCount = 0;
	private int taskLevel = 1;
	private int taskToComplete = 1;
	private int completedTasks = 0;
	private int maxAvailableTasks = 4;
	private GameObject enteredTask;
	System.Collections.Generic.List<GameObject> taskPortals = new System.Collections.Generic.List<GameObject> (); // taskPortals are necessary to record all the spawned tasks within the labyrinth

	public float moveSpeed;
	public Joystick joystick;
	public Vector3 viewCameraPosition;
	private double timer = 1.0;
	private bool allowMotion = false;
	private bool gameHasStarted = false;
	private int RowsCount = 0;
	private int ColumnsCount = 0;

	private ModalPanel modalPanel;
	private UnityAction myOkAction;
	private UnityAction myCancelAction;

	// This is to define where the wall was placed per cell
	public struct WallPlacement {
		public bool WallRight;
		public bool WallFront;
		public bool WallLeft;
		public bool WallBack;
	}

	// If the player gets stuck after completing all tasks, the following method will be invoked. 
	// For example, if he goes to the upper cell, where he will be surrounded by walls in front, right, left, except his back, then it means that he gets stuck.
	bool StuckInDeadline(string direction) {
		string wallDirection = "Wall_At_Column" + playerPosX.ToString() + "_Row" + playerPosZ.ToString();

		WallPlacement wallPlacement = getWallDirections(wallDirection);

		switch (direction) {
			case "up":
				if (wallPlacement.WallFront && wallPlacement.WallRight && wallPlacement.WallLeft) {
					return true;
				}
				break;
			case "down":
				if (wallPlacement.WallBack && wallPlacement.WallRight && wallPlacement.WallLeft) {
						return true;
				}
				break;
			case "right":
				if (wallPlacement.WallFront && wallPlacement.WallBack && wallPlacement.WallRight) {
					return true;
				}
				break;
			case "left":
				if (wallPlacement.WallFront && wallPlacement.WallBack && wallPlacement.WallLeft) {
					return true;
				}
				break;
		}
		return false;
	}

	// This method is invoked several times in FixedUpdate (). It is necessary to define where already generated walls per cell were placed.
	WallPlacement getWallDirections(string wallDirection) {
		WallPlacement wallPlacement;
		wallPlacement.WallRight = PlayerPrefs.GetInt(wallDirection+"_Right", 0) != 0; // This gets information whether the wall on the right side exists per cell.
		wallPlacement.WallFront = PlayerPrefs.GetInt(wallDirection+"_Front", 0) != 0;
		wallPlacement.WallLeft = PlayerPrefs.GetInt(wallDirection+"_Left", 0) != 0;
		wallPlacement.WallBack = PlayerPrefs.GetInt(wallDirection+"_Back", 0) != 0;
		return wallPlacement;
	}

	// This method is to check whether the player leaves the cell, where the task portal was located. Once the player leaves, the task portal reapperat again.
	void checkForEnteredTask(GameObject floor) {
		if (enteredTask != null) { // If it is not null, then it means, that the task portal was previously created
			if (floor.transform.position == enteredTask.transform.position && !enteredTask.activeSelf) {
				enteredTask.SetActive (true);
				enteredTask.GetComponent<Collider> ().enabled = true;
			}
		}
	}

	void initTaskPortal(Vector3 position, int index) {
		GameObject taskPortal = GameObject.CreatePrimitive (PrimitiveType.Sphere); // this is the mesh, by which means the player can enter the task scene.
		taskPortal.transform.position = new Vector3 (position.x, 0, position.z);
		taskPortal.GetComponent<Renderer> ().material.color = Color.cyan;
		taskPortal.name = "TaskPortal " + index.ToString();
		taskPortals.Add (taskPortal); // we have to keep track of spawned task portals, so later we can check conditions on whether the player steps the cell containing one of those task portals.
	}

	void Start () {
		mAudioSource = GetComponent<AudioSource> ();

		modalPanel = ModalPanel.Instance (); // This panel is required for Notifications

		myOkAction = new UnityAction (GoToTask); // We have to assign the function, once the "Ok" button is clicked on the Notification
		myCancelAction = new UnityAction (CancelTask); // The same applies to "Cancel"
	}

	void FixedUpdate () {

		/* This is to ensure that all data was saved after entering previous task. However, take a note, 
		that all data must be erased, when the player enters the labyrinth for the first time. 
		Otherwise, worst scenario might happen. */

		if (!gameHasStarted) {
			taskLevel = PlayerPrefs.GetInt ("taskLevel", 1); // If the player makes 6 turns in the maze, the new task with an appropriate level will be spawned. So this is required to record current task level.
			previousStep = PlayerPrefs.GetString ("previousStep", "firstStep"); // Take a look in FixedUpdate () about this variable.
			turnsCount = PlayerPrefs.GetInt ("turnsCount", 0);
			playerPosX = PlayerPrefs.GetInt ("playerPosX", 0);
			playerPosZ = PlayerPrefs.GetInt ("playerPosZ", 0);
			completedTasks = PlayerPrefs.GetInt ("CompletedTasks", 0);
			string startingFloorName = "Floor_Column" + playerPosX.ToString() + "_Row" + playerPosZ.ToString(); // It will get the player to the cell, where he was previously stopped, once after he entered to the task scene.
			GameObject startingFloor = GameObject.Find(startingFloorName);
			if (startingFloor != null) {
				transform.position = startingFloor.transform.position;
			}
			if (PlayerPrefs.GetInt ("RowsCount", 0) != 0 && PlayerPrefs.GetInt ("ColumnsCount", 0) != 0) {
				RowsCount = PlayerPrefs.GetInt ("RowsCount", 0);
				ColumnsCount = PlayerPrefs.GetInt ("ColumnsCount", 0);
			}
			gameHasStarted = true;

			// After the player returns to the maze once again, the same portals with the same previous locations will be spawned.
			for (int i = 1; i < taskLevel; i++) {
				string nameIdentifier = "TaskPortal " + i;
				initTaskPortal (new Vector3(PlayerPrefs.GetFloat (nameIdentifier + "_PosX", 0), 0, PlayerPrefs.GetFloat (nameIdentifier + "_PosZ", 0)), i);
				GameObject taskPortal = GameObject.Find (nameIdentifier);
				if (taskPortal != null && taskPortal.transform.position == transform.position) {
					enteredTask = taskPortal;
					enteredTask.SetActive (false); // We have to hide the task portal, if the player is spawned on the same location as the task portal.
					enteredTask.GetComponent<Collider> ().enabled = false; // and also turn off its collider, so ball won't bounce off, once hits it.
				}
			}
		}

		string wallDirection = "Wall_At_Column" + playerPosX.ToString() + "_Row" + playerPosZ.ToString();

		WallPlacement wallPlacement = getWallDirections(wallDirection);

		string floorName = "Floor_Column" + playerPosX.ToString() + "_Row" + playerPosZ.ToString();
		GameObject floor = GameObject.Find(floorName);

		if (floor != null) {

			//This snippet of code is required to identify whether the task is in the range of the current cell.

			foreach (GameObject taskPortal in taskPortals) {
				if (floor.transform.position == taskPortal.transform.position && taskPortal.activeSelf) {
					turnsCount = 0; // we have to nullify the turns count

					// This will get the length of TaskPortal, because once I named the mesh by this exact name that the player can go through to the next task,
					// and substring it in such way that it will receive the task level, that the player currently intends to play. For example TaskPortal1,
					// will leave just number '1', and the task 1 will be launched.
					taskToComplete = Int32.Parse(taskPortal.name.Substring ("TaskPortal".Length, taskPortal.name.Length - "TaskPortal".Length)); 
					taskPortal.SetActive (false); // We have to hide the task portal, if the player stays on the same location as the task portal.
					taskPortal.GetComponent<Collider> ().enabled = false; // and also turn off its collider, so ball won't bounce off, once hits it.
					enteredTask = taskPortal;
					
					// If the player enters the task portal, the notification will pop up, if ok button is clicked, it will proceed to the task.
					switch(taskToComplete) {
						case 1:
							NotificationOptions ("Would you like to play the Game Of Words?");
							break;
						case 2:
							NotificationOptions ("Would you like to play the Game #2?");
							break;
						case 3:
							NotificationOptions ("Would you like to play the Game #3?");
							break;
						case 4:
							NotificationOptions ("Would you like to play the Game #4?");
							break;
					}
					break;
				}
			}

			if (defaultFloorColor == null) {
				defaultFloorColor = floor.GetComponent<Renderer> ().material.color;
			}

			floor.GetComponent<Renderer> ().material.color = Color.green; // current staying floor color

			// the player can make his moves after each second

			timer -= Time.deltaTime; 

			if (allowMotion) {
				transform.position = Vector3.Lerp (transform.position, floor.transform.position, moveSpeed * Time.deltaTime); // this allows ball to move smoothly to the target
				if (timer <= 0) {
					allowMotion = false;
				}
				// The current location of the player must be recorded, so on the next session the player is spawned on the same previous location. The same applies to the previous made step and number of turns.
				PlayerPrefs.SetString ("previousStep", previousStep);
				PlayerPrefs.SetInt ("turnsCount", turnsCount);
				PlayerPrefs.SetInt ("playerPosX", playerPosX);
				PlayerPrefs.SetInt ("playerPosZ", playerPosZ);
			}

			if (timer <= 0 && !allowMotion) {

				// previousStep is required to record the two-based steps for the player, so by this we can know whether the player will make a "turn".
				// turnsCount records information about how much turns were made by the player.
				// The following turns are available by the player, the previous step will record the first turn, and will compare it with current step:
				// ↑ + → |-------| ↓ + → |-------| → + ↑ |-------| → + ↓
				// ↑ + ← |-------| ↓ + ← |-------| ← + ↑ |-------| ← + ↓

				if (previousStep == null) {
					previousStep = "firstStep";
				}
				Vector3 moveVector = (Vector3.back * joystick.Horizontal + Vector3.right * joystick.Vertical).normalized * moveSpeed;

				// The maze is defined in x and z manner. So z++ means the player goes up, z-- down, x++ right, x-- left.

				if (moveVector.x >= 5 & moveVector.x <= 10 && moveVector.z >= -3 && moveVector.z <= 3) { // The player moves joystick upwards
					if (playerPosZ + 1 < RowsCount && !wallPlacement.WallFront) { // If the player makes his move to upper cell, we must ensure, that no wall in front exists, and the boundary is kept, so the system won't throw an error.
						floor.GetComponent<Renderer> ().material.color = defaultFloorColor; // If the player moves to the next cell, the previous cell will change its color to its default.
						if (taskLevel <= maxAvailableTasks && previousStep != "firstStep" && previousStep != "up" && previousStep != "down") { // Take a look to all available turns of the player above. If and only the tasks are not completed the turns will be counted. "firstStep", iterative turns, reversed turns are not counted as a turn.
							turnsCount++;
						}
						previousStep = "up";
						playerPosZ++; // if the player makes his move up, so it will go to the upper cell
						if (completedTasks == maxAvailableTasks) { // Once all tasks are completed, the player will have to go to the exit, if he gets stuck the sound should play notifying him that this cell is the deadline.
							if (StuckInDeadline ("up")) { 
								Debug.Log ("You're stuck!"); // Here you stuck, and the sound should play
							}
						}
						allowMotion = true;
						timer = 1.0;
						checkForEnteredTask (floor);
					}
				} else if (moveVector.x >= -10 & moveVector.x <= -5 && moveVector.z >= -3 && moveVector.z <= 3) { // Downwards
					if (playerPosZ - 1 > -1 && !wallPlacement.WallBack) {
						floor.GetComponent<Renderer> ().material.color = defaultFloorColor;
						if (taskLevel <= maxAvailableTasks && previousStep != "firstStep" && previousStep != "down" && previousStep != "up") {
							turnsCount++;
						}
						previousStep = "down";
						playerPosZ--;
						if (completedTasks == maxAvailableTasks) {
							if (StuckInDeadline ("down")) {
								Debug.Log ("You're stuck!");
							}
						}
						allowMotion = true;
						timer = 1.0;
						checkForEnteredTask (floor);
					}
				}

				if (moveVector.x >= -3 & moveVector.x <= 3 && moveVector.z >= -10 && moveVector.z <= -5) { // Right
					if(playerPosZ == RowsCount -1 && playerPosX == ColumnsCount - 1) {
						PlayerPrefs.DeleteAll (); // Once we exit from the labyrinth, we ensure that all data is deleted
						SceneManager.LoadScene ("Exit"); // Go to the stage where final comics scene will be presented to the player
					}
					else if (playerPosX + 1 < ColumnsCount && !wallPlacement.WallRight) {
						floor.GetComponent<Renderer> ().material.color = defaultFloorColor;
						if (taskLevel <= maxAvailableTasks && previousStep != "firstStep" && previousStep != "right" && previousStep != "left") {
							turnsCount++;
						}
						previousStep = "right";
						playerPosX++;
						if (completedTasks == maxAvailableTasks) {
							if (StuckInDeadline ("right")) {
								Debug.Log ("You're stuck!");
							}
						}
						allowMotion = true;
						timer = 1.0;
						checkForEnteredTask (floor);
					}
				} else if (moveVector.x >= -3 & moveVector.x <= 3 && moveVector.z >= 5 && moveVector.z <= 10) { // Left
					if (playerPosX - 1 > -1 && !wallPlacement.WallLeft) {
						floor.GetComponent<Renderer> ().material.color = defaultFloorColor;
						if (taskLevel <= maxAvailableTasks && previousStep != "firstStep" && previousStep != "left" && previousStep != "right") {
							turnsCount++;
						}
						previousStep = "left";
						playerPosX--;
						if (completedTasks == maxAvailableTasks) {
							if (StuckInDeadline ("left")) {
								Debug.Log ("You're stuck!");
							}
						}
						allowMotion = true;
						timer = 1.0;
						checkForEnteredTask (floor);
					}
				}

				// this is where the new task is generated.
				if (turnsCount == 5) {
					string availableFloorName;
					int xOffset = 0, zOffset = 0; // these are required to generate mesh, in the cell next to the current player position.

					wallDirection = "Wall_At_Column" + playerPosX.ToString() + "_Row" + playerPosZ.ToString();
					wallPlacement = getWallDirections(wallDirection);

					if (previousStep == "up" || previousStep == "down") { // if the player made his previous move towards up or down, the mesh will be generated to the next appropriate direction.
						if (previousStep == "up" && !wallPlacement.WallFront) {
							zOffset = 1;
						} else if (previousStep == "down" && !wallPlacement.WallBack) {
							zOffset = -1;
						} else if (!wallPlacement.WallRight) {
							xOffset = 1;
						} else if (!wallPlacement.WallLeft) {
							xOffset = -1;
						}
					} else if (previousStep == "right" || previousStep == "left") {
						if (!wallPlacement.WallFront) {
							zOffset = 1;
						} else if (!wallPlacement.WallBack) {
							zOffset = -1;
						} else if (previousStep == "right" && !wallPlacement.WallRight) {
							xOffset = 1;
						} else if (previousStep == "left" && !wallPlacement.WallLeft) {
							xOffset = -1;
						}
					}

					availableFloorName = "Floor_Column" + (playerPosX + xOffset).ToString () + "_Row" + (playerPosZ + zOffset).ToString ();
					GameObject nextFloor = GameObject.Find(availableFloorName);

					// We have to check whether the task is not generated in the same place as the previous one.
					foreach(GameObject taskPortal in taskPortals) {
						if (taskPortal.transform.position == new Vector3 (nextFloor.transform.position.x, 0, nextFloor.transform.position.z)) {
							turnsCount--;
							break;
						}
					}

					if (turnsCount == 5) {
						turnsCount = 0;
						initTaskPortal (nextFloor.transform.position, taskLevel);
						GameObject taskPortal = taskPortals[taskPortals.Count-1]; // It will get the last created task portal, and record its location & taskLevel.
						taskLevel++;
						PlayerPrefs.SetFloat (taskPortal.name+"_PosX", taskPortal.transform.position.x);
						PlayerPrefs.SetFloat (taskPortal.name+"_PosZ", taskPortal.transform.position.z);
						PlayerPrefs.SetInt ("taskLevel", taskLevel);
					}
				}

			}

		}

		if (ViewCamera != null) {
			Vector3 direction = (Vector3.up*2+Vector3.back)*2;
			RaycastHit hit;
			Debug.DrawLine(viewCameraPosition, viewCameraPosition+direction,Color.red);
			ViewCamera.transform.position = new Vector3(viewCameraPosition.x, viewCameraPosition.y, viewCameraPosition.z);
			ViewCamera.transform.LookAt(viewCameraPosition); // this is how camera will look to the player position or any other defined position.
		}
	}

	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag.Equals ("Floor")) {
			mFloorTouched = true;
			if (mAudioSource != null && HitSound != null && coll.relativeVelocity.y > .5f) {
				mAudioSource.PlayOneShot (HitSound, coll.relativeVelocity.magnitude);
			}
		} else {
			if (mAudioSource != null && HitSound != null && coll.relativeVelocity.magnitude > 2f) {
				mAudioSource.PlayOneShot (HitSound, coll.relativeVelocity.magnitude);
			}
		}
	}

	void OnCollisionExit(Collision coll){
		if (coll.gameObject.tag.Equals ("Floor")) {
			mFloorTouched = false;
		}
	}

	public void NotificationOptions(string message) {
		modalPanel.Option(message, myOkAction, myCancelAction);
	}

	// If the player enters the mesh that was generated after turns made, he will go straight to the scene where the task will be presented.
	void GoToTask() {
		switch(taskToComplete) {
			case 1:
				SceneManager.LoadScene (Scenes.GAME_OF_WORDS_SCENE);
				break;
			case 2:
				//SceneManager.LoadScene (Scenes.GAME_OF_WORDS_SCENE);
				break;
			case 3:
				//SceneManager.LoadScene (Scenes.GAME_OF_WORDS_SCENE);
				break;
			case 4:
				//SceneManager.LoadScene (Scenes.GAME_OF_WORDS_SCENE);
				break;
		}
	}

	void CancelTask() {
		Debug.Log ("Canceled");
	}
}
