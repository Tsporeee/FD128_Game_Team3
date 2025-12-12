using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpFeet : MonoBehaviour
{
    public Collectible feet;
    public FirstPersonController controller;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (feet.isCollected)
        {
            controller.enableJumping();
        }
    }
}
