using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public bool key;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Door"))
        {
            if (key)
            {
                Vector3 rotation = other.gameObject.transform.eulerAngles;
                rotation.y = -90;
                other.gameObject.transform.eulerAngles = rotation;
                Vector3 position = other.gameObject.transform.position;
                position.x = -3.17f;
                position.z = -2.95f;
                other.gameObject.transform.position = position;
            }
        }
        if (other.tag.Equals("Key"))
        {
            key = true;
            other.gameObject.SetActive(false);
        }
        if (other.tag.Equals("Bomb"))
        {
            Debug.Log("Boom!");
            other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }
 
}
