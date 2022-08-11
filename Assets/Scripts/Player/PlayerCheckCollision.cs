using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Portal" && collision.gameObject.GetComponent<ModifierShrinker>())
        {
           Debug.Log("Collision with portal that has shrinker component detected"); 
        }
        Debug.Log("Collision with " + collision.gameObject.name);
    }
}
