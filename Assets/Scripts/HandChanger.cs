using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandChanger : MonoBehaviour
{
    public GameObject[] hands;
    public Collectible newHand;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (newHand.isCollected)
        {
            hands[0].SetActive(false);
            hands[1].SetActive(true);
        }
    }
}
