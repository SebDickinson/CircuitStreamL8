using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorLerp : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float interpolationAmount; //Value between 0 and 1
    [SerializeField] Color startColor;
    [SerializeField] Color endColor;
    
    void Start()
    {
        
    }

    void Update()
    {
        //If the interpolation amount is greater than 1...
        if(interpolationAmount > 1)
        {
            /// ... bring it back to 0
             interpolationAmount = 0;
        }

        // Increment by the speed value
        interpolationAmount += speed;

        //New Color
        Color newColor = Color.Lerp(startColor, endColor, interpolationAmount);

        // Get Mesh Material based on the lerp of the new color. 
        GetComponent<MeshRenderer>().material.color = newColor;
    }
}
