using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {
	
	string stageNum = "one";
	string question = " ";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// ========================== Retry Question ==========================
		if (stageNum == "zero" ) {
			question = "Retry ";
			question += "\n [a] Okay";
			question += "\n [b] No";

			if (Input.GetKeyDown (KeyCode.A)) { 
				stageNum = "one";
			}
			else if (Input.GetKeyDown (KeyCode.B)) {
				stageNum = "zero";
			}
		}

		// ========================== 1st Question ==========================
		else if (stageNum == "one" ) {
			question = "Eric, did Evan build you? ";
			question += "\n [a] Yea, Why?";
			question += "\n [b] No";

			if (Input.GetKeyDown (KeyCode.A)) { 
				stageNum = "two";
			}
			else if (Input.GetKeyDown (KeyCode.B)) {
				stageNum = "zero";
			}
		}

		// ========================== 2nd Question ==========================
		else if (stageNum == "two" ) {
			question = "Do you know where he is? ";
			question += "\n [a] Yea, Why?";
			question += "\n [b] No";
			
			if (Input.GetKeyDown (KeyCode.A)) { 
				stageNum = "three";
			}
			else if (Input.GetKeyDown (KeyCode.B)) {
				stageNum = "zero";
			}
		}

		// ========================== 3rd Question ==========================
		else if (stageNum == "three" ) {
			question = "Do you think you can" ;
			question += "\nshow us the way?" ;
			question += "\n [a] Yea, Why?";
			question += "\n [b] No";
			
			if (Input.GetKeyDown (KeyCode.A)) { 
				stageNum = "conclusion1";
			}
			else if (Input.GetKeyDown (KeyCode.B)) {
				stageNum = "zero";
			}
		}

		// ========================== 3rd Question ==========================
		else if (stageNum == "conclusion1" ) {
			question = "I'll tell you why, we need";
			question += "\nEvan to bring back summer";
			question += "\n\nPress [space] to continue ";
			
			if (Input.GetKeyDown (KeyCode.Space)) { 
				stageNum = "conclusion2";
			}
		}
		else if (stageNum == "conclusion2" ) {
			question = "Eric: SUMMER... I don't know why";
			question += "\nbut I always loved the idea of summer";
			question += "\nand sun and all things warm";
			question += "\n\nPress [space] to continue ";

			if (Input.GetKeyDown (KeyCode.Space)) { 
				stageNum = "conclusion3";
			}
		}
		else if (stageNum == "conclusion3" ) {
			question = "\n\nCREDITS TO FROZEN";
		}

		GetComponent<TextMesh> ().text = question;
	
	}
}
