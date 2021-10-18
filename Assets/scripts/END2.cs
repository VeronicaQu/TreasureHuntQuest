using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class END2 : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
   {
       if(collision.gameObject.name == "player")
       {
           CompleteLevel();
       }
   }

   private void CompleteLevel()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
   }

}
