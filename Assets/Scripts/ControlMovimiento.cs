using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMovimiento : MonoBehaviour 
{
	public Animator anim;
	


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

	public void IniciarRecorrido()
	{
		anim.enabled = true;

	}

	public void ContinuarRecorrido()
	{
		anim.SetBool ("Avanzar", true);
	}

    public void ContinuarAvanzando()
    {
        anim.SetBool("ContinuarAvanzando", true);
    }

	public void DetenerRecorrido()
	{
		
		anim.SetBool ("Avanzar", false);
		anim.SetBool ("GirarIzquierda", false);
		anim.SetBool ("GirarDerecha", false);
        anim.SetBool("ContinuarAvanzando", false);

    }

	public void GirarIzquierda()
	{
		anim.SetBool ("GirarIzquierda", true);
	}

	public void GirarDerecha()
	{
		anim.SetBool ("GirarDerecha", true);
	}

	public void OnTriggerEnter(Collider col)
	{
		if(col.tag == "PlayPoint")
		{
			DetenerRecorrido ();
		}
	}
			
}
