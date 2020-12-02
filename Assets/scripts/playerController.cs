using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody playerrig;

    // Start is called before the first frame update
    void Start()
    {
        playerrig = GetComponent<Rigidbody>();
        playerrig.AddForce(Vector3.up * 750);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
