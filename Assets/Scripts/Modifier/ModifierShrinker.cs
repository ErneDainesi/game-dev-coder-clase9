using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifierShrinker : MonoBehaviour
{
    private bool wasShrinked = false;

    private void OnTriggerEnter(Collider other)
    {
        Transform playerTransform = other.gameObject.transform;
        if (!wasShrinked)
        {
            var newScale = playerTransform.localScale / 2;
            other.gameObject.transform.localScale = newScale;
            wasShrinked = true;
        }
        else
        {
            var newScale = playerTransform.localScale * 2;
            other.gameObject.transform.localScale = newScale;
            wasShrinked = false;
        }
    }
}
