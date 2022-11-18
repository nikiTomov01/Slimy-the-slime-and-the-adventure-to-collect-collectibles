using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PlayerStats : MonoBehaviour
{

    public int maxHealth = 3;
    public int currentHealth;
    public int coins;

    public UnityEvent<PlayerStats> OnCoinCollected;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    coins++;
        //}
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void CollectCoin(Collider other)
    {
        if (other.gameObject.tag == "Collectible")
        {
            //Debug.Log("COLLECTED");
            coins++;
            OnCoinCollected.Invoke(this);
        }
        if (other.gameObject.tag == "circleCollectible")
        {
            //Debug.Log("COLLECTED");
            coins--;
            OnCoinCollected.Invoke(this);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        CollectCoin(other);
    }
}
