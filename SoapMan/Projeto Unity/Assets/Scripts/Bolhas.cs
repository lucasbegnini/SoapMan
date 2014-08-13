using UnityEngine;
using System.Collections;

public class Bolhas : MonoBehaviour {

	public GameObject bolhaPprefab;
	private GameObject bolhaP;

	public GameObject bolhaMprefab;
	private GameObject bolhaM;

	public GameObject bolhaGprefab;
	private GameObject bolhaG;

	public GameObject Maoprefab;
	private GameObject Mao;

	public GameObject Soapprefab;
	private GameObject Soap;
	
	private Vector2 velocidade = new Vector2 (0,3);
	private int sorteio;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("CriarBolhas", 1f, 1f); 
		Mao = GameObject.Instantiate(Maoprefab) as GameObject;
		Mao.transform.parent = this.transform;
		Soap = GameObject.Instantiate(Soapprefab) as GameObject;
		Soap.transform.parent = this.transform;
		
	}

	void OnMouseDown()
	{
		BroadcastMessage("MouseDown");

	}

	void OnMouseUp()
	{
		BroadcastMessage("MouseUp");
	}

	// Update is called once per frame
	void Update () {
		Input.GetKeyDown (KeyCode.Escape);

	}

	void CriarBolhas()
	{
		sorteio = Random.Range (1, 4);
		switch (sorteio)
		{
		case 1:
			bolhaP = GameObject.Instantiate(bolhaPprefab) as GameObject;
			bolhaP.transform.parent = this.transform;
			bolhaP.rigidbody2D.velocity = velocidade;
			//Debug.Log("criou p");

			break;
		
		case 2:
			bolhaM = GameObject.Instantiate(bolhaMprefab) as GameObject;
			bolhaM.transform.parent = this.transform;
			bolhaM.rigidbody2D.velocity = velocidade;
			//Debug.Log("criou M");

			break;

		case 3:
			bolhaM = GameObject.Instantiate(bolhaGprefab) as GameObject;
			bolhaM.transform.parent = this.transform;
			bolhaM.rigidbody2D.velocity = velocidade;
			//Debug.Log("criou G");

			break;
		}

	}
}
