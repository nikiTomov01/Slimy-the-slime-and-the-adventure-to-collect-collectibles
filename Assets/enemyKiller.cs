using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyKiller : MonoBehaviour
{
    //working dmg to enemies
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            var enemy = other.gameObject.GetComponent<enemyKill>();
            enemy.Kill();
        }
    }

    // over engineered dmg to enemies
    /*
    private void OnCollisionEnter(Collision collision)
    {
        foreach(ContactPoint hitPos in collision.contacts)
        {
            //Debug.Log(hitPos.normal);
            if(hitPos.normal.y > 0 && collision.gameObject.CompareTag("enemy"))
            {
                var enemy = collision.gameObject.GetComponent<enemyKill>();
                enemy.Kill();
                //Debug.Log("Hit the top:" + hitPos.normal);
            }
        }
    } */
}
