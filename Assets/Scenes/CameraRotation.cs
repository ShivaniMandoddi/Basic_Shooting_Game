using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        transform.rotation = transform.rotation * Quaternion.Euler(0, mouseX * rotationSpeed, 0);
        Camera cam = GetComponentInChildren<Camera>();
        cam.transform.localRotation = Quaternion.Euler(-mouseY, 0, 0) * cam.transform.localRotation;
    }
}