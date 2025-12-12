using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackWhite : MonoBehaviour
{

    public Collectible eyes;
    public GameObject obstruction;
    public bool on = true;

    
    public void Update()
    {
        if (eyes.isCollected)
        {
             obstruction.SetActive(false);
        }
    }


}
