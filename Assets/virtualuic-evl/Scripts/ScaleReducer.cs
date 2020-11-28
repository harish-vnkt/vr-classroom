using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class ScaleReducer : MonoBehaviour
{
    bool scaleDown = false;
    SDK_InputSimulator inputSimulator;
    // Start is called before the first frame update
    void Start()
    {
        inputSimulator = GetComponent<SDK_InputSimulator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) {
            if (!scaleDown) {
                transform.localScale = new Vector3(0.08f, 0.08f, 0.08f);
                scaleDown = true;
                inputSimulator.playerMoveMultiplier = 2;
                inputSimulator.handMoveMultiplier = 0.1f;
            }
            else {
                transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
                scaleDown = false;
                inputSimulator.playerMoveMultiplier = 5;
                inputSimulator.handMoveMultiplier = 0.1f;
            }
        }
    }
}
