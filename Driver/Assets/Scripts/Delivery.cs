using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    #region METHODS
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Colliding");           
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        //If we trigger with package then print package picked up to the console
        if(other.tag == "Package")
        {
            Debug.Log("Package picked up");
        }
        else if(other.tag == "Customer")
        {
            Debug.Log("Package delivered");
        }   
    }
    #endregion
}
