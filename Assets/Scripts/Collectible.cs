using UnityEngine;

public class Collectible : MonoBehaviour 
{
    public bool isCollected = false;
    private Vector3 rotationSpeed = new Vector3(0, 100, 0);

    private void OnTriggerEnter(Collider other)
    {
        // What should happen if something with the Player tag enters the trigger box?
        if (other.gameObject.tag == "Player")
        {
            Debug.Log($"Collect: {this.name}");
            isCollected = true;

            Destroy(this.gameObject);
        }
    }

    //Rotation
    private void Update()
    {
        if(isCollected == false)
        {
            transform.Rotate(rotationSpeed * Time.deltaTime);
        }
    }

    // Getter
    //public string getCollectableType()
    //{
    //    return collectableType;
    //}
}