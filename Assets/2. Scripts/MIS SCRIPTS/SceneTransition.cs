using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
   public string nextScene;


   private void OnTriggerEnter(Collider other) {
    
    if (other.CompareTag("NPC")){

        SceneManager.LoadScene(0);
    }

   }



}
