using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    public float speed = 10f;
    private playerController playercontrol;

    // Start is called before the first frame update
    void Start()
    {
        playercontrol = GameObject.Find("player").GetComponent <playerController> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (playercontrol.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
