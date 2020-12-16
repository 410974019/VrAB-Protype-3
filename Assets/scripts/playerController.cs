using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody playerrig;
    private Animator playerani;

    public ParticleSystem smoke;
    public ParticleSystem dirt;

    public float gravityoffset = 10;
    public float speed = 12;
    private bool onGround = true;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        playerrig = GetComponent<Rigidbody>();
        playerani = GetComponent<Animator>();

        Physics.gravity *= gravityoffset;
    }

    // Update is called once per frame
    void Update()
    {
        //detec space key
        if (Input.GetKeyDown(KeyCode.Space) && onGround) 
        {
            playerrig.AddForce(Vector3.up * speed, ForceMode.Impulse);
            onGround = false;
            playerani.SetTrigger("Jump_trig");
            dirt.Stop();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //onGround = true;

        if (collision.gameObject.CompareTag("ground") && gameOver == false)
        {
            onGround = true;
            dirt.Play();
        }
        else if (collision.gameObject.CompareTag("ob"))
        {
            gameOver = true;
            playerani.SetBool("Death_b", true);
            playerani.SetInteger("DeathType_int", 1);
            smoke.Play();
            dirt.Stop();
            Debug.Log("Game over");
        }
    }
}
