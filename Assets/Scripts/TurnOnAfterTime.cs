using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnAfterTime : MonoBehaviour {

	

    public GameObject toggleObject;
    public float textBegintime;
	public float textLifetime;

    void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player")
		{
			
			StartCoroutine(SelfToggleOn());
			StartCoroutine(SelfToggleOff());
			
		}
		
	}


	IEnumerator SelfToggleOn()
    {
		yield return new WaitForSeconds(textBegintime);
		toggleObject.SetActive(true);
    }

	IEnumerator SelfToggleOff()
    {
		yield return new WaitForSeconds(textLifetime);
		toggleObject.SetActive(false);
    }
}
