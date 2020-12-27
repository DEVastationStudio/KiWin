using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables auxiliares
    [SerializeField] private float speed, jumpspeed;
    public PlayerScore score;

    //Player Inputs
    private PlayerControl playerControl;

    private void Awake()
    {
        playerControl = new PlayerControl();
    }

    private void onEnable()
    {
        playerControl.Enable();
    }

    private void onDisable()
    {
        playerControl.Disable();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        playerControl.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento derecha izquierda
        float movementInputX = playerControl.Animal.MoveX.ReadValue<float>();
        //Movimiento delante detras
        float movementInputZ = playerControl.Animal.MoveZ.ReadValue<float>();   

        //Posicion del jugador
        Vector3 currentPosition = transform.position;
        //Se suma el movimiento 
        currentPosition.x += movementInputX * speed * Time.deltaTime;
        currentPosition.z += movementInputZ * speed * Time.deltaTime;
        //Se actualiza la posicion
        transform.position = currentPosition;
    }
}
