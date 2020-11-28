using UnityEngine;
using System.Collections;

public class EarthSpinScript : MonoBehaviour {
    public float speed = 10f;

    bool canRotate = true;

    public void StopRotation() {
        canRotate = false;
    }

    public void StartRotation() {
        canRotate = true;
    }

    void Update() {
        if (canRotate) {
            transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.World);
        }
    }
}