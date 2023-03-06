using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    #region VARIABLES
    [SerializeField] GameObject carToFollow;
    #endregion

    #region EVENTS
    //Camera position should be the same as the car's position
    void LateUpdate()
    {
       transform.position =  carToFollow.transform.position + new Vector3(0,0,-10);
    }
    #endregion
}
