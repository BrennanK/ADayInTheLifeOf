using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    Camera worldCamera;

    // Start is called before the first frame update
    void Start()
    {
        worldCamera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = worldCamera.ViewportPointToRay(new Vector3(.5f, .5f, 0));
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 2))
            {
                print(hit.collider.name);
            }
        }
    }
}
