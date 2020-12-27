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

    /** This region controls the logic behind the lobby wich makes players confirm that they are ready in order to play.
     * We can find 4 methods in this region: ReadyAnimalBtn, ReadyFrutaBtn, StartGame and Resetlobby.
     * ReadyMethods are called when the players push their coresponding ready button.
     * StartGame makes visible the button start game when all the players are ready to play.
     * ResetLobby is called when the lobby is exit so when coming back all the players are not ready and have to confirm that they are.
     */
    #region Lobby logic
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
    #endregion

}
