using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeController : MonoBehaviour
{
    private string _targetScene = "SampleScene";
    public Animator animator;

    public void BeginFade(string targetScene)
    {
        _targetScene = targetScene;
        animator.SetTrigger("Fade");
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(_targetScene);
    }
}
