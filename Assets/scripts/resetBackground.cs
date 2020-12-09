using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float resetWidth;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        resetWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - resetWidth)
        {
            transform.position = startPos;
        }
    }
}
