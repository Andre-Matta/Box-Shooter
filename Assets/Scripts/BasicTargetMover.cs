using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour
{
    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;

    public bool doSpin = true;
    public bool doMotion = false;
    // Update is called once per frame
    void Update()
    {
        // Stops rotaion if desired
        if(doSpin)
        {
            // Rotate around the y-axis in the game object
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }

        // Stops motion if desired
        if (doMotion)
        {
            // Move up and down over time
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
        }

    }
}
