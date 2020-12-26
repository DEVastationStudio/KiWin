using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed, jumpspeed;
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
        float movementInputX = playerControl.Animal.MoveX.ReadValue<float>();
        float movementInputZ = playerControl.Animal.MoveZ.ReadValue<float>();   
        //float jumpInput = playerControl.Animal.Jump.ReadValue<float>();

        Vector3 currentPosition = transform.position;
        currentPosition.x += movementInputX * speed * Time.deltaTime;
        currentPosition.z += movementInputZ * speed * Time.deltaTime;
        //currentPosition.y += jumpInput * speed * Time.deltaTime;
        transform.position = currentPosition;
    }
}
