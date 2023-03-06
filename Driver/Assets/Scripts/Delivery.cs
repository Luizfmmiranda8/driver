using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    #region VARIABLES
    bool hasPackage;
    SpriteRenderer spriteRenderer;
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);
    #endregion
    #region EVENTS
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
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
            spriteRenderer.color = hasPackageColor;
        }
        else if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }   
    }
    #endregion
}
