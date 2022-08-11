using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    [SerializeField] float speed;
    void Start() {

    }

    void Update() {
        Move();
    }

    private void Move() {
        if (Input.GetKey(KeyCode.W)) {
            MovePlayer(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S)) {
            MovePlayer(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A)) {
            MovePlayer(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D)) {
            MovePlayer(Vector3.right);
        }
    }

    private void MovePlayer(Vector3 direction) {
        transform.Translate(speed * Time.deltaTime * direction);
    }
}
