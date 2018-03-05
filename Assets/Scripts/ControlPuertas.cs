using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPuertas : MonoBehaviour 
{
	public Animator anim;
	public GameObject panelPrincipal;

	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();
		anim.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void Abrir()
	{
		anim.enabled = true;
		panelPrincipal.SetActive (false);
	}

	public void Cerrar()
	{
		anim.SetBool ("Cerrar", true);
	}
		
}
