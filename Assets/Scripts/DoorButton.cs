using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{
    public Animator doorAnimator;

    void OnMouseDown()
    {
        Debug.Log("Door Open");
        doorAnimator.SetBool("Door Open", true);

        Debug.Log("Shutter Open");
        doorAnimator.SetBool("Shutter Open", true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
