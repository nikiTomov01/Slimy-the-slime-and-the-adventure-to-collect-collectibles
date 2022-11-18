using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerStats playerStats;
    public int damage;
    private bool hasHit = false;

    private void OnCollisionEnter(Collision collision)
    {
        foreach(ContactPoint hitPos in collision.contacts)
        {
            //Debug.Log("Enemy Collision: " + hitPos.normal);
            if(hitPos.normal.y < 0 && collision.gameObject.tag == "Player")
            {
                playerStats.TakeDamage(0);
            }
            else if (hitPos.normal.y == 0 && collision.gameObject.tag == "Player" && hasHit == false)
            {
                playerStats.TakeDamage(damage);
                hasHit = true;
            }
        }

        //if(collision.gameObject.tag == "Player")
        //{
        //    playerStats.TakeDamage(damage);
        //}
    }

    private void OnCollisionExit(Collision collision)
    {
        hasHit = false;
    }
}
