using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatingComments : MonoBehaviour
{
    public float amplitude = 0.3f;
    public float frequency = 1f;

    Vector3 posOffSet = new Vector3();
    Vector3 tempPos = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        posOffSet = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        tempPos = posOffSet;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        gameObject.transform.position = tempPos;
    }
}
