using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_secene3 : MonoBehaviour
{
     private void Start(){
     StartCoroutine(WaitAndLoad(20f, "carta"));
 }
 
 private IEnumerator WaitAndLoad(float value, string carta) {
     yield return new WaitForSeconds(value);
     Application.LoadLevel(carta);
 }
}
