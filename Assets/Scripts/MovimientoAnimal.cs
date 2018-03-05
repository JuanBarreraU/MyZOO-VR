using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAnimal : MonoBehaviour
{
    public GameObject[] target;
    public float speed;
    private GameObject targetD;

	// Use this for initialization
	void Start ()
    {
        targetD = target[0];
	}
	
	// Update is called once per frame
	void Update ()
    {
        Moverse();

    }

    public void Moverse()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetD.transform.position, step);
        if (targetD != null)
        {

            this.gameObject.transform.LookAt(targetD.transform);
        }

    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Target0")
        {
            targetD = target[1];
        }

        if(col.tag == "Target1")
        {
            targetD = target[2];
        }

        if(col.tag == "Target2")
        {
            targetD = target[0];
        }
    }

}
