using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour
{
    public float _spinSpeed = 180.0f;
    public float _motionMagnitude = 0.1f;
    public bool _doSpin = true;
    public bool _doMotion = false;

    void Update()
    {
        if (_doSpin)
        {
            //rotate around y-axis
            gameObject.transform.Rotate(Vector3.up * _spinSpeed * Time.deltaTime);
        }

        if (_doMotion)
        {
            //move up & down 
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * _motionMagnitude);
        }
        
    }
}
