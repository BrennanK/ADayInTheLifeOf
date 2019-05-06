using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController myCharController;
    float speed;
    float mouseXSen;
    Camera myCamera;
    // Start is called before the first frame update
    void Start()
    {
        myCharController = GetComponent<CharacterController>();
        speed = .1f;
        mouseXSen = 1f;
        myCamera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir;
        Vector3 cameraYRot;

        transform.Rotate(0, Input.GetAxis("Mouse X") * mouseXSen, 0);
        moveDir = new Vector3(Input.GetAxis("Horizontal") * speed, -9.81f, Input.GetAxis("Vertical") * speed);
        myCamera.transform.Rotate(ClampRotation());
        myCharController.Move(transform.TransformDirection(moveDir));
    }

    Vector3 ClampRotation()
    {
        return new Vector3();
    }
}
