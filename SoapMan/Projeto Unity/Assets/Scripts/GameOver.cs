using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
//		Debug.Log ("Seu Score foi: " + PlayerPrefs.GetInt ("yourscore").ToString ());
//		Debug.Log ("O maior Score : " + PlayerPrefs.GetInt("highscore").ToString());
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void backToGame()
	{
		Application.LoadLevel("Game");
	}
	
	void backToMenu()
	{
		Application.LoadLevel("Start");
	}

	void ResetScore()
	{
		PlayerPrefs.SetInt ("highscore", 0);
	}


	void OnGUI()
	{
		GUI.color = Color.Lerp(Color.magenta, Color.red, 5f);
		GUI.color = Color.magenta;
		
		
		DrawButtons ();
		
		
	}

	void DrawButtons()
	{

		GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
		GUILayout.FlexibleSpace();
		GUILayout.BeginHorizontal();
		GUILayout.EndHorizontal();

		GUILayout.FlexibleSpace();

		GUILayout.FlexibleSpace ();
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button ("Back to Game",  LoadStyleButton()))
		{
			backToGame ();
			
		}
		
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal();
		GUILayout.Space (3);
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (" Menu " , LoadStyleButton()))
		{
			backToMenu ();
		}
		
		
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal();
		GUILayout.Space (3);
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button ("Reset Score",  LoadStyleButton()))
		{
			ResetScore ();
			//audio.PlayOneShot(Sound);
		}
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();

		GUILayout.FlexibleSpace();
		GUILayout.EndArea();

	}

	GUIStyle LoadStyleButton()
	{	
		
		GUIStyle MyStyle;
		MyStyle = new GUIStyle (GUI.skin.button);
		MyStyle.fontSize = 15;
		// Load and set Font
		Font myFont = (Font)Resources.Load("Fonts/pixelli", typeof(Font));
		MyStyle.font = myFont;
		
		
		return MyStyle;
	}



}
