using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ModifierPosition : MonoBehaviour
{
    private float timeInWall = 0f;
    private float cooldown = 2f;
    [SerializeField] private Transform[] respawnPoints;
    private void OnCollisionStay(Collision collisionInfo)
    {
        timeInWall += Time.deltaTime;
        int randomIndex = Random.Range(0, respawnPoints.Length);
        if (timeInWall >= cooldown)
        {
            Vector3 randomRespawnPoint = respawnPoints[randomIndex].position;
            collisionInfo.gameObject.transform.position = randomRespawnPoint;
            timeInWall = 0;
        }
    }
}
