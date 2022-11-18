using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transparentGround : MonoBehaviour
{
    public PlayerStats playerStats;
    Collider m_Collider;
    Material m_Material;
    Color color;
    private bool active;

    private void Start()
    {
        m_Collider = GetComponent<Collider>();
        m_Collider.enabled = !m_Collider.enabled;

        m_Material = GetComponent<Renderer>().material;
        color = m_Material.color;
        active = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerStats.coins == 10 && active == false)
        {
            int whatIsGroundLayer = LayerMask.NameToLayer("whatIsGround");
            gameObject.layer = whatIsGroundLayer;
            m_Collider.enabled = !m_Collider.enabled;
            color.a = 1;
            m_Material.color = color;
            active = true;
        }
    }
}
