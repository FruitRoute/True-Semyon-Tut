using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLVL;
    public GameObject score;
    public void EndGame()
    {
        Invoke("Restart", restartDelay);
     //   if (gameHasEnded == false)
      //  {
      //      gameHasEnded = true;
       //    
       // }
    }
   public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GG()
    {
        Debug.Log("GGGG");
        completeLVL.SetActive(true);
        score.SetActive(false);
    }
    
}
