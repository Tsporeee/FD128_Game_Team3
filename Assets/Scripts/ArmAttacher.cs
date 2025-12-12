using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmAttacher : MonoBehaviour
{
     public Collectible arm;
     public GameObject newArm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   void Update()
    {
        if (arm.isCollected)
        {
            newArm.SetActive(true);
        }
    }
}
