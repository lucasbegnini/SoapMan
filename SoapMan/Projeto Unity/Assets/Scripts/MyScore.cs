using UnityEngine;
using System.Collections;

public class MyScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		GetComponent<TextMesh> ().text =  PlayerPrefs.GetInt("yourscore").ToString();
	}
}
