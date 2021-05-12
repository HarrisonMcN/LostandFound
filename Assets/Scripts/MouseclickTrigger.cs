using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseclickTrigger : MonoBehaviour
{
    public GameObject text;
    public float textLifetime;


    void OnMouseDown()
    {
        text.SetActive(true);
        StartCoroutine(SelftToggleOff());
    }

    IEnumerator SelftToggleOff()
    {
        yeild return new WaitForSeconds(textLifetime);
        toggleObject.SetActive(false);
    }   
}
