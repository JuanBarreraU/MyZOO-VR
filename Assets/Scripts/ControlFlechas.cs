using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControlFlechas : MonoBehaviour 
{
	public GameObject[] flechas;
	public GameObject[] playPoints;
	public GameObject[] flechasReversa;
	public GameObject[] playPointsReversa;
	public bool retrocediendo;

	// Use this for initialization
	void Start () 
	{
		retrocediendo = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void OnTriggerEnter(Collider col)
	{
		if (col.tag == "PlayPoint") 
		{
			if (retrocediendo == false) 
			{
				for (int i = 0; i < playPoints.Length; i++) 
				{
					if (col.name == playPoints [i].name) 
					{
						flechas [i].SetActive (true);
					}
				}
			}

			if (retrocediendo == true) 
			{
				for (int i = 0; i < playPointsReversa.Length; i++) 
				{
					if (col.name == playPointsReversa [i].name) 
					{
						flechasReversa [i].SetActive (true);
					}
				}
			}
		}


	}



	public void DesactivarFlechas()
	{
		for (int i = 0; i < flechas.Length; i++) 
		{
			flechas [i].SetActive (false);

		}
		for (int i = 0; i < flechasReversa.Length; i++) 
		{
			
			flechasReversa [i].SetActive (false);
		}
	}

	public void Retroceder()
	{
		retrocediendo = true;
	}

	public void Avanzar()
	{
		retrocediendo = false;
	}


		


		
}
