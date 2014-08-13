using UnityEngine;
using System.Collections;

public class StarGame : MonoBehaviour {

	public Texture2D play;


	void OnGUI()
	{
		GUI.color = Color.black;
		DrawButtons ();
	}
	
	void Update()
	{
		Input.GetKeyDown (KeyCode.Escape);
	}
	
	
	void DrawButtons()
	{
		GUI.color = Color.white;
		GUIStyle ButtonStyle;
		ButtonStyle = LoadStyleButton ();
		
		GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
		GUILayout.FlexibleSpace();
		
		//GUILayout.FlexibleSpace();
		GUILayout.BeginHorizontal ();
		GUILayout.Space(80);
		GUILayout.FlexibleSpace();
		//GUILayout.Label (logo);
		GUILayout.EndHorizontal ();
		GUILayout.FlexibleSpace();
		GUILayout.BeginHorizontal();
		GUI.color = Color.white;
		GUI.backgroundColor = new Color (0, 0, 0, 0);
		GUILayout.FlexibleSpace();
		
		if (GUILayout.Button (play))
			GoToGame ();
		
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		GUI.color = Color.magenta;
		if (GUILayout.Button ("Creditos",ButtonStyle))
			GoToCreditos ();
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		
		if (GUILayout.Button ("Quit",ButtonStyle))
			GoToOut ();
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		
		GUILayout.FlexibleSpace();
		GUILayout.EndArea();
	}
	
	void GoToGame()
	{
		Application.LoadLevel ("Game");
	}
	
	void GoToCreditos()
	{
		Application.LoadLevel ("Creditos");
	}
	
	void GoToOut()
	{
		Application.Quit ();
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
