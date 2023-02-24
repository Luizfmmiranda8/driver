using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    #region METHODS
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Colliding");           
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("Passing through");   
    }
    #endregion
}
