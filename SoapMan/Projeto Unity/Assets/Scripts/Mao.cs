using UnityEngine;
using System.Collections;

public class Mao : MonoBehaviour {

	public Sprite MaoAberta;
	public Sprite MaoFechada;
	// Use this for initialization
	private GameObject hand;
	private GameObject soap;

	public static int score;

	private bool click;

	void Start () {
	
		hand = GameObject.FindGameObjectWithTag ("Hand");
		soap = GameObject.FindGameObjectWithTag ("Soap");
		click = false;
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void MouseDown()
	{
		Vector3 position = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Vector3 curScreenPoint = new Vector3 (position.x, -1.5f, 0f);
		transform.position = curScreenPoint;
		//AnimarMaoAberta ();
		//VerificaColisao ();
		click = true;
	}

	void MouseUp()
	{
		AnimarMaoFechada ();
		click = false;
	}

	void AnimarMaoAberta()
	{
		SpriteRenderer r = renderer as SpriteRenderer;
		r.sprite = MaoFechada;

	}

	void AnimarMaoFechada()
	{
		SpriteRenderer r = renderer as SpriteRenderer;
		r.sprite = MaoAberta;

	}



	void OnTriggerEnter2D(Collider2D obj)
	{
		float VeloX;
		float VeloY;
		if (obj.CompareTag ("Soap") ) {
			score++;
			AnimarMaoAberta ();
			Invoke ("AnimarMaoFechada",0.5f);
			//VeloX = -1;
			//VeloY = 8;
			VeloX = Random.Range(-1f,1f);
			VeloY = Random.Range(6f, 10f);


			if(soap.GetComponent<Transform>().position.x < -1.8f)
			{

				VeloX = Random.Range(0f,2f);

			}

			if(soap.GetComponent<Transform>().position.x > 1.8f)
			{
				
				VeloX = Random.Range(-2f,0f);

			}


			Vector2 velocidade = new Vector2(VeloX,VeloY);
			soap.GetComponent<Rigidbody2D>().velocity = velocidade;
		}
	}
	

}
