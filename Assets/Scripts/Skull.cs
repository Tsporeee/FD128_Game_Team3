using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull : MonoBehaviour
{
    public Collectible skull;
    public GameObject skullScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (skull.isCollected)
        {
            skullScreen.SetActive(true);
        }
    }
}
