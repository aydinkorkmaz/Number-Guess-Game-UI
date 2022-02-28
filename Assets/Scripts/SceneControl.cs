using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
  public void NextScene(){
      int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
      SceneManager.LoadScene(CurrentSceneIndex+1);
  }
  public void GameScene(){
      SceneManager.LoadScene(1);
  }
  public void QuitGame(){
      Application.Quit();
  }
}
