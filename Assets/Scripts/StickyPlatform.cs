using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    // Start is called before the first frame update
     public void OnCollisionEnter(Collision collision)
    {
        //here we want to check if this platform is colliding with the player and this info is stored in this collision variable which passed as parameter
        if(collision.gameObject.name=="Player")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);//we unparent it from the moving platform
        }
    }
}
