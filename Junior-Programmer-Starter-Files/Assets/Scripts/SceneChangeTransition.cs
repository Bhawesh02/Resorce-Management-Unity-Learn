using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeTransition : MonoBehaviour
{
    public Animator transition;
    public void StartNew()
    {
        StartCoroutine(LoadLevel(1));
    }

    IEnumerator LoadLevel(int levelIndex)

    {
        //Play animation
        transition.SetTrigger("Start");


        //wait for animation to get over
        yield return new WaitForSeconds(1);

        //Load newScene
        SceneManager.LoadScene(levelIndex);

    }
}
