using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrutaController : MonoBehaviour
{
    //Variables auxiliares
    [SerializeField] private float speed, jumpspeed;

    //Player Inputs
    private PlayerControl playerControl;

    private Renderer ren;

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
        float movementInputX = playerControl.Fruta.MoveX.ReadValue<float>();
        //Movimiento delante detras
        float movementInputZ = playerControl.Fruta.MoveZ.ReadValue<float>();   
        
        //Posicion del jugador
        Vector3 currentPosition = transform.position;
        //Se suma el movimiento
        currentPosition.x += movementInputX * speed * Time.deltaTime;
        currentPosition.z += movementInputZ * speed * Time.deltaTime;
        //Se actualiza posicion
        transform.position = currentPosition;
    }

    void OnCollisionEnter(Collision collision)
    {
        ren = GetComponent<Renderer>();
        ren.material.SetColor("_Color", Color.green);
    }
}
