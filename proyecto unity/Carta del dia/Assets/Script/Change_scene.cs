using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_scene : MonoBehaviour
{
     private void Start(){
     StartCoroutine(WaitAndLoad(33f, "Flappy"));
 }
 
 private IEnumerator WaitAndLoad(float value, string Flappy) {
     yield return new WaitForSeconds(value);
     Application.LoadLevel(Flappy);
 }
}
