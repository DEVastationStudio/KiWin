using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Posicion del jugador
    public Transform PlayerTransform;

    //Valores de la camara
    private Vector3 _camerOffset;

    [Range(0.01f,1.0f)]
    public float SmoothFactor = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        _camerOffset = transform.position - PlayerTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //La camara sigue al personaje
        Vector3 newPos = PlayerTransform.position + _camerOffset;

        transform.position = Vector3.Slerp(transform.position, newPos,SmoothFactor);
    }
}
