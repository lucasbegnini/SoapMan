using UnityEngine;
using System.Collections;

public class Soap : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.y  < -4) 
		{
			Object.Destroy(this.gameObject);
			FimdeJogo();
		}
		
	}

	void FimdeJogo()
	{
		StoreHighscore (Mao.score);
		Application.LoadLevel("GameOver");

	}

	void StoreHighscore(int newHighscore)
	{
		int oldHighscore = PlayerPrefs.GetInt("highscore", 0);  
		if (newHighscore > oldHighscore) {
			PlayerPrefs.SetInt ("highscore", newHighscore);
			PlayerPrefs.SetInt("yourscore", newHighscore);
		} else {
			PlayerPrefs.SetInt("yourscore",newHighscore);		
		}
	}
}

