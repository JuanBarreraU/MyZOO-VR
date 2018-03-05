using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlImagenes : MonoBehaviour
{
    private Vector3 originalScale;
    private Vector3 destinationScale;
	private int clics;

	// Use this for initialization
	void Start () 
	{
		clics = 0;
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		
	}

    public void MostrarInformacion()
    {
		if (clics == 1) 
		{
			StartCoroutine (ScaleOverTime (1));
		}
    }

    public void MostrarInformacion2()
    {
		if (clics == 1) 
		{
			StartCoroutine (ScaleOverTime2 (1));
		}
    }

    IEnumerator ScaleOverTime(float time)
    {
        originalScale = this.transform.localScale;
        destinationScale = new Vector3(4.0f, 16.0f, 4.0f);

        float currentTime = 0.0f;

        do
        {
            this.transform.localScale = Vector3.Lerp(originalScale, destinationScale, currentTime / time);
            currentTime += Time.deltaTime;
            yield return null;
        }
        while (currentTime <= time);

        this.transform.localScale = destinationScale;
    }

    IEnumerator ScaleOverTime2(float time)
    {
        originalScale = this.transform.localScale;
        destinationScale = new Vector3(4.0f, 4.0f, 4.0f);

        float currentTime = 0.0f;

        do
        {
            this.transform.localScale = Vector3.Lerp(originalScale, destinationScale, currentTime / time);
            currentTime += Time.deltaTime;
            yield return null;
        }
        while (currentTime <= time);

        this.transform.localScale = destinationScale;
    }

    public void OcultarInformacion()
    {
		if (clics == 2) 
		{
			this.transform.localScale = originalScale;
			clics = 0;
		}
    }
		

	public void DarClic()
	{
		clics += 1;
	}
}
