using UnityEngine;
using System.Collections;

public class Bolha : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (transform.position.y  > 4) 
		{
			Object.Destroy(this.gameObject);
			//Debug.Log("Destruiu Bolha");
		}
	}
}
