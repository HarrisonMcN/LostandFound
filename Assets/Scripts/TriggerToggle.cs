﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerToggle : MonoBehaviour {

	public enum ToggleType{ turnOn, turnOff, toggle }

	public GameObject toggleObject;
	public ToggleType toggleType;
	public float textLifetime;
	
	

	void OnTriggerEnter (Collider other)
	{
	    GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag ("AI");
 
        foreach(GameObject go in gameObjectArray)
        {
            go.SetActive (false);
        }

		if (other.tag == "Player")
		{
			if (toggleType == ToggleType.turnOn)
				toggleObject.SetActive (true);
			else if (toggleType == ToggleType.turnOff)
				toggleObject.SetActive (false);
			else if (toggleType == ToggleType.toggle)
				toggleObject.SetActive (!toggleObject.activeSelf);

			StartCoroutine(SelfToggleOff());

			gameObject.GetComponent<BoxCollider>().enabled = false;
		}
		
	}

	IEnumerator SelfToggleOff()
    {
		yield return new WaitForSeconds(textLifetime);
		toggleObject.SetActive(false);
    }
}
