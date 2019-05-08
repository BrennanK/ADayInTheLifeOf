using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Made by: Trahern Moews
 * 
 * Purpose: Player Movement 
 *          Camera rotation
 *          
 * Chopped together code for player movement and camera rotation.
 * Player rotation is done by spinning the whole player model 
 * Requires camera to be child of player object
*/
public class PlayerMovement : MonoBehaviour
{
    CharacterController myCharController;
    Camera myCamera;

    float speed;
    float mouseXSen;
    float mouseYSen;

    Vector3 moveDir;
    Vector3 bodyXRot;
    Vector3 cameraPitch;

    // Start is called before the first frame update
    void Start()
    {
        //Need for moving
        myCharController = GetComponent<CharacterController>();
        //Need for camera rotation
        myCamera = GetComponentInChildren<Camera>();

        //Initial set for speed, whole numbers are really fast
        speed = .1f;
        //numbers for sensitivity settings
        mouseXSen = 1f;
        mouseYSen = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        

        //gather all variable data
        bodyXRot = new Vector3(0, Input.GetAxis("Mouse X") * mouseXSen, 0);
        cameraPitch = new Vector3(-Input.GetAxis("Mouse Y") * mouseYSen, 0, 0);
        moveDir = new Vector3(Input.GetAxis("Horizontal") * speed, -9.81f, Input.GetAxis("Vertical") * speed);

        //Assign all variables
        //rotates the players whole body
        transform.Rotate(bodyXRot);
        //rotates the camera around the X axis for up and down movement 
        myCamera.transform.Rotate(cameraPitch);
        //moves character based on WASD and a manual Gravity setting
        myCharController.Move(transform.TransformDirection(moveDir));
    }
    
}
