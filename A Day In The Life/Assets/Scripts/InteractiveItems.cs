using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveItems : MonoBehaviour
{
    //color used for the glow of the object
    Color glowColor;
    // RGB channels for the glow
    float r;
    float g;
    float b;
    //Amount of glow increase perframe. Whole numbers result in fast blinks
    float rIncrease;
    float gIncrease;
    float bIncrease;

    InteractiveGlow[] allInteractables;
    // Start is called before the first frame update
    void Start()
    {
        //Gathers all the Collectable items in the scene.
        //All items must have the InteraciveGlow script on them. 
        allInteractables = new InteractiveGlow[FindObjectsOfType<InteractiveGlow>().Length];
        allInteractables = FindObjectsOfType<InteractiveGlow>();
        rIncrease = .5f;
        gIncrease = .5f;
        bIncrease = .5f;
    }

    // Update is called once per frame
    void Update()
    {
        
        r += rIncrease * Time.deltaTime;
        g += gIncrease * Time.deltaTime;
        b += bIncrease * Time.deltaTime;


        glowColor = new Color(Mathf.PingPong(r, .5f), Mathf.PingPong(g, .5f), Mathf.PingPong(b, .5f), 1);
        
        for(int i = 0; i < allInteractables.Length; i++)
        {
            allInteractables[i].SetGlowColor(glowColor);
        }
    }
}
