using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelExit : MonoBehaviour
{   
    [SerializeField] float time;
    [SerializeField] float levelLoadDelay = 1f;
     

    void OnTriggerEnter2D(Collider2D other)
    {   
        StartCoroutine(LoadNextLevel());
    }

    IEnumerator LoadNextLevel()
    {
        yield return new WaitForSecondsRealtime(levelLoadDelay);
        SceneManager.LoadScene(0);
    }



    
}
