using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightScript : MonoBehaviour
{
    public InputActionReference action;
    public new Light light;
    private bool isOn = true;

    void Start()
    {
        light = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (isOn)
            {
                light.color = Color.red;
            }
        };
    }
}