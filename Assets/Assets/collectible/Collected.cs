using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collected : MonoBehaviour
{

    private void Update()
    {
        //transform.localRotation = Quaternion.Euler(0f, Time.time * 100f, 0);
        if(gameObject.tag == "Collectible")
        {
        transform.localRotation = Quaternion.Euler(Time.time * 100f, Time.time * 100f, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
