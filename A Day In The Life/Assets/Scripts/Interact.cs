using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* Made by: Trahern Moews
 * 
 * Purpose: Control player interaction and camera zoom from here.
 */


public class Interact : MonoBehaviour
{
    //Used for camera positioning when stopping interaction
    public Transform cameraHome;
    //Used to look for camera inspection point on an interactable object
    Transform[] childTransforms;
    //Store camera target location
    Transform cameraTarget;
    //Main camera player uses
    Camera worldCamera;
    //Used to stop player movement when interacting
    PlayerMovement playerMoveRef;
    //Logic for when player is done interacting
    bool moveCameraBack;

    InteractiveText logBookRef;

    // Start is called before the first frame update
    void Start()
    {
        //Locks cursor and gathers refrences needed 
        Cursor.lockState = CursorLockMode.Locked;
        worldCamera = GetComponentInChildren<Camera>();
        playerMoveRef = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //Nested if's o.O
        if (Input.GetMouseButtonDown(0) && cameraTarget == null)
        {
            Ray ray = worldCamera.ViewportPointToRay(new Vector3(.5f, .5f, 0));
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 2))
            {
                //Interactable tag needed on objects meant to be interacted with
                if (hit.collider.CompareTag("Interactable"))
                {
                    childTransforms = hit.collider.GetComponentsInChildren<Transform>();

                    //Looks for a child object with tag CIP (Camera Inspection Point) tag
                    foreach(Transform temp in childTransforms)
                    {
                        if (temp.CompareTag("CIP"))
                        {
                            if (temp.GetComponentInParent<InteractiveGlow>())
                            {
                                temp.GetComponentInParent<InteractiveGlow>().ShutOffGlow();
                            }
                            if (temp.GetComponentInParent<InteractiveText>())
                            {
                                logBookRef = temp.GetComponentInParent<InteractiveText>();
                                logBookRef.Interacted(temp.GetComponentInParent<InteractiveText>().name);
                            }
                            cameraTarget = temp;
                            playerMoveRef.canMove = false;
                        }
                    }
                }
            }
        }
        //if the player is inspecting an object and the player clicks again the camera inspection point is 
        else if(Input.GetMouseButtonDown(0) && cameraTarget != null)
        {
            cameraTarget = null;
            moveCameraBack = true;
            logBookRef.StopInteration();
            logBookRef = null;
        }

        //Moves camera back to the face position
        if (moveCameraBack)
        {
            worldCamera.transform.position = Vector3.MoveTowards(worldCamera.transform.position, cameraHome.position, .06f);

            worldCamera.transform.rotation = Quaternion.Lerp(worldCamera.transform.rotation, cameraHome.rotation, 10f * Time.deltaTime);

            if(worldCamera.transform.position == cameraHome.transform.position && worldCamera.transform.rotation == cameraHome.rotation)
            {
                moveCameraBack = false;
                playerMoveRef.canMove = true;
            }
        }

        //If an object taged with CIP is found in the foreach loop. the camera with move to the Inspection point
        if(cameraTarget != null)
        {
            worldCamera.transform.position = Vector3.Lerp(worldCamera.transform.position, cameraTarget.position, 4f * Time.deltaTime);

            worldCamera.transform.rotation = Quaternion.Lerp(worldCamera.transform.rotation, cameraTarget.rotation, 4f * Time.deltaTime);
        }
    }
}
