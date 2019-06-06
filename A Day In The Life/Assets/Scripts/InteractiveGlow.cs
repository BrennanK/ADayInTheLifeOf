using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractiveGlow : MonoBehaviour
{
    Color baseColor;
    Color glowColor;
    
    float r, g, b;
    float rIncrease = .5f, gIncrease = .5f, bIncrease = .5f;

    bool inspected;

    private void Start()
    {
        baseColor = GetComponent<Renderer>().material.GetColor("_EmissionColor");
    }

    // Update is called once per frame
    void Update()
    {
        if (!inspected)
        {
            r += rIncrease * Time.deltaTime;
            g += gIncrease * Time.deltaTime;
            b += bIncrease * Time.deltaTime;

            glowColor = new Color(Mathf.PingPong(r, .5f), Mathf.PingPong(g, .5f), Mathf.PingPong(b, .5f), 1);
            GetComponent<Renderer>().material.SetColor("_EmissionColor", glowColor);
        }
        else
        {
            GetComponent<Renderer>().material.SetColor("_EmissionColor", baseColor);
            Destroy(this);
        }
    }

    public void ShutOffGlow()
    {
        inspected = true;
    }
}
