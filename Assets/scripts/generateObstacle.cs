using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateObstacle : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private playerController playercontrol;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Gobstacle", 1.0f, 1.5f);
        playercontrol = GameObject.Find("player").GetComponent<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Gobstacle()
    {
        if (playercontrol.gameOver == false)
        {
            Instantiate(obstaclePrefab, new Vector3(22, 0, 0), obstaclePrefab.transform.rotation);
        }
    }
}
