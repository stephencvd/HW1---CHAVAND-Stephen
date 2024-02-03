using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BreakOut : MonoBehaviour
{
    public InputActionReference action;
    private bool isOutsideRoom = false;

    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (isOutsideRoom)
            {
                transform.position = new Vector3(0, 0, 0);
            }
            else
            {
                transform.position = new Vector3(51, 0, 49);
            }

            isOutsideRoom = !isOutsideRoom;
        };
    }
}