using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyControllerScript : MonoBehaviour
{

    [SerializeField] private Button StartBtn;
    [SerializeField] private Image ReadyAnimal;
    [SerializeField] private Image ReadyFruta;

    private bool isAnimalReady;
    private bool isFrutaReady;

    public void Start()
    {
        StartBtn.gameObject.SetActive(false);
        ReadyFruta.gameObject.SetActive(false);
        ReadyAnimal.gameObject.SetActive(false);
    }

    public void ReadyAnimalBtn() 
    {
        isAnimalReady = !isAnimalReady;
        ReadyAnimal.gameObject.SetActive(isAnimalReady);
        startGame();
    }

    public void ReadyFrutaBtn()
    {
        isFrutaReady = !isFrutaReady;
        ReadyFruta.gameObject.SetActive(isFrutaReady);
        startGame();
    }

    private void startGame() 
    {
        StartBtn.gameObject.SetActive(isAnimalReady && isFrutaReady);
    }

    public void ResetLobby() 
    {
        isAnimalReady = false;
        isFrutaReady = false;
        ReadyAnimal.gameObject.SetActive(false);
        ReadyFruta.gameObject.SetActive(false);
        StartBtn.gameObject.SetActive(false);
    }

}
