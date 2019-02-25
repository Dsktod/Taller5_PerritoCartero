using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flaplear : MonoBehaviour
{
   
    public float upForce = 200f;

    public float Speed;
    private Animator anim;
    private Rigidbody2D rb2d;
	public AudioSource sound;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
		//sound = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(upForce * Speed, upForce ));
                anim.SetTrigger("jump");
				sound.Play(0);
            }	
		
	}
	void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("piso"))
        {
            anim.SetTrigger("idle");

        }
		 if (other.gameObject.CompareTag("Finish"))
        {
             Application.LoadLevel("video2");
        }
	}

  
}
