using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

///<summary>Class that manages transitions between scenes.</summary>
public class FadeController : MonoBehaviour
{
    private string _targetScene = "SampleScene";
    public Animator animator;

    ///<summary>Starts the fade sequence, and changes the current scene to <paramref name="targetScene"/>.</summary>
    public void BeginFade(string targetScene)
    {
        _targetScene = targetScene;
        animator.SetTrigger("Fade");
    }

    ///<summary>Method called when the fadeOut animation finishes.</summary>
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(_targetScene);
    }
}
