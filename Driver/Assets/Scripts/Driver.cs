using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    #region VARIABLES
    [SerializeField] float rotationSpeed = 1f;
    [SerializeField] float moveSpeed = 0.01f;
    #endregion

    #region EVENTS
    void Start()
    {
       
    }

    void Update()
    {
        float rotationAmount = Input.GetAxis("Horizontal") * rotationSpeed;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;
        transform.Rotate(0, 0, -rotationAmount);
        transform.Translate(0, moveAmount, 0); 
    }
    #endregion

    #region METHODS

    #endregion
}
