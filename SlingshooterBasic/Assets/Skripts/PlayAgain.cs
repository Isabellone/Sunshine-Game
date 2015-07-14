using UnityEngine;
using System.Collections;

public class PlayAgain : MonoBehaviour {

	void OnGUI () {

		if (GUI.Button (new Rect (Screen.width / 2.5f, Screen.height / 1.7f, Screen.width / 5, Screen.height / 10), "Replay")) {

			Application.LoadLevel ("SlingshooterScene");

		}
		
	}
}
