using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandVisuals : MonoBehaviour
{
    [SerializeField] Animator handAnim;
    [SerializeField] string gripButton;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        //When pressing the button
        if (Input.GetButtonDown(gripButton))
        {
            // Gripped label true
            handAnim.SetBool("Gripped", true);
        }

        //When releasing the button
        if (Input.GetButtonUp(gripButton))
        {
            // Gripped label false
            handAnim.SetBool("Gripped", false);
        }
    }
}
