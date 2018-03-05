using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAudios : MonoBehaviour 
{
	public GameObject[] playPoints;
	public GameObject[] audios;
	public AudioSource audioFondo;


	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void OnTriggerEnter(Collider col)
	{
		if (col.tag == "PlayPoint") 
		{
			for (int i = 0; i < playPoints.Length; i++) 
			{
				audios [i].SetActive (false);
				if (col.name == playPoints [i].name) 
				{
					audios [i].SetActive (true);
						
				}
			}
		}
	}


}
