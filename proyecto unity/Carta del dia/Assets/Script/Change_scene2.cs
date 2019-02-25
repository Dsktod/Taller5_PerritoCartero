using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_scene2 : MonoBehaviour
{
   private void Start(){
     StartCoroutine(WaitAndLoad(28f, "door1"));
 }
 
 private IEnumerator WaitAndLoad(float value, string door1) {
     yield return new WaitForSeconds(value);
     Application.LoadLevel(door1);
 }
}
