using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    #region VARIABLES
    bool hasPackage;
    [SerializeField] float destroyDelay = 0.5f;
    #endregion
    #region METHODS
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Colliding");           
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        //If we trigger with package then print package picked up to the console
        if(other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }
        else if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage = false;
        }   
    }
    #endregion
}
