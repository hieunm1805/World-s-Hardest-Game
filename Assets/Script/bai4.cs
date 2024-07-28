using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class bai4 : MonoBehaviour
{
    public float rotationSpeed = 60f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateObject();
    }

    private void RotateObject(){
        float currentAngle = transform.rotation.eulerAngles.z;

        float newAngle = currentAngle + (rotationSpeed * Time.deltaTime);

        Quaternion newRotation = Quaternion.Euler(0f, 0f, newAngle);

        transform.rotation = newRotation;
    }
}
