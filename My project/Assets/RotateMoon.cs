using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMoon : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate( 0.0f, 1.0f, 0.0f* Time.deltaTime);
    }
}
