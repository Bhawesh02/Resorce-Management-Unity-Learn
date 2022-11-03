using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeTransition : MonoBehaviour
{
    public Animator transition;
    public int sceneIndex;
    public void StartNew()
    {
        StartCoroutine(LoadLevel(sceneIndex));
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
