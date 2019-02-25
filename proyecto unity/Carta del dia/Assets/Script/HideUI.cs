using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideUI : MonoBehaviour
{
    public Text txt;

	void awake()
    {
        txt.enabled = false;
		 
	}
	void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            txt.enabled = true;

        }
		
	}
	
}
