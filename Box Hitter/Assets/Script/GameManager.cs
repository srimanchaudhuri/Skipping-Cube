using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    bool gameEnd = false;
    [SerializeField] private float restartDelay = 1f;
    [SerializeField] private GameObject CompleteLevelUI;
    public void EndGame ()
    {
        if(gameEnd == false)
        {
            gameEnd = true;
            Invoke("Restart", restartDelay);
        }
       
    }

    public void CompleteLevel()
    {
        Debug.Log("End Game");
        CompleteLevelUI.SetActive(true);
    }

    void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
