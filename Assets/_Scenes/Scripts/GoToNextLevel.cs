using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToNextLevel : MonoBehaviour
{
   public GameObject _obj;
   public GameManager _manager;
   public Text _EndTotalScore;
   private void OnTriggerEnter2D(Collider2D collision) 
   {
       if(collision.CompareTag("Player"))
       {
           UnLockLevel();
       }
   }

   public void UnLockLevel()
   {
       _EndTotalScore.text = _manager._score.ToString();
        Time.timeScale = 0f;
        _obj.SetActive(true);
   }
}
