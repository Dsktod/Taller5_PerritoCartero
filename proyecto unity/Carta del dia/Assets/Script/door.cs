using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
   public float time = 0f;
    private Animator anim;
    public AudioSource sound;

    private void Start()
    {
        anim = GetComponent<Animator>();
		time = 8f;

    }
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                anim.SetTrigger("left");
				sound.Play(0);
            }	
		if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                anim.SetTrigger("right");
            }	
		else
		{
		       anim.SetTrigger("stay");
		
		}
		if(time > 0)
		{
        time-=Time.deltaTime;
        }
	    else
		{
          Application.LoadLevel("video3");
		}
		
	}
}
	

