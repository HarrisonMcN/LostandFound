using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseclickTrigger : MonoBehaviour
{
    public enum ToggleType { turnOn, turnOff, toggle }
    public GameObject text;
    public float textLifetime;
    public GameObject Component;
    public ToggleType toggleType;
 


    void OnMouseDown()
    {
        text.SetActive(true);
        StartCoroutine(SelftToggleOff());

        Component.GetComponent<BoxCollider>().enabled = false;
        

        if (toggleType == ToggleType.turnOn)
            text.SetActive(true);
        else if (toggleType == ToggleType.turnOff)
            text.SetActive(false);
        else if (toggleType == ToggleType.toggle)
            text.SetActive(!text.activeSelf);

    }

    IEnumerator SelftToggleOff()
    {
        yield return new WaitForSeconds(textLifetime);
        text.SetActive(false);
    }   
}
