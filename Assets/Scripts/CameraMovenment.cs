using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovenment : MonoBehaviour
{
    public float speed;
    public FixedJoystick Joystick;
    public Transform camera_transform;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //Vector3 direction = 1.41f * Joystick.Vertical * transform.forward + Joystick.Horizontal * transform.right;
        Vector3 direction = 1.41f * Joystick.Vertical * camera_transform.forward + Joystick.Horizontal * camera_transform.right;

        direction.y = 0;
        rb.AddForce(speed * Time.fixedDeltaTime * direction, ForceMode.VelocityChange);

        //transform.position += direction * speed;
    }

}
