using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    InputController inputController;

    Vector2 move;

    //Velocidad de desplazamiento
    [SerializeField] float speedH;
    [SerializeField] float speedV;
    [SerializeField] float speedDefault;

    //Limite despl
    float limitX = 6f;
    float limitVT = 6f;
    float limitVB = 0.5f;

    //Boolenas que permitirán el movimiento
    bool movingH;

    //Posición inicial, para el suavizado
    Vector3 currentPos;
    Vector3 smoothInputVelocity; //Necesitamos esta variable para el suavizado
    [SerializeField] float SmoothVelocity = 0.4f; //Cantidad de suavizado en el movimiento

    //Lo mismo para la rotación
    Vector3 currentRot;
    Vector3 smoothInputRotVelocity; //Necesitamos esta variable para el suavizado
    [SerializeField] float RotateVelocity = 0.2f;
    [SerializeField] float maxAng = 70f; //Máximo ángulo de rotación


    private void Awake()
    {
        inputController = new InputController();

        inputController.PlayerMove.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        inputController.PlayerMove.Move.canceled += _ => move = Vector2.zero;


    }

    // Start is called before the first frame update
    void Start()
    {
        speedDefault = 6f;

        currentPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        MoverNave();

    }

    void MoverNave()
    {
        

        float posX = transform.position.x;
        float posY = transform.position.y;
        float desplX = move.x;
        float desplY = move.y;

        if ((posX > limitX && desplX > 0) || (posX < -limitX && desplX < 0))
        {
            speedH = 0f;
            SmoothVelocity = 0f;
        }
        else
        {
            speedH = speedDefault;
            SmoothVelocity = 0.2f;
        }



        if ((posY > limitVT && desplY > 0) || (posY < limitVB && desplY < 0))
        {
            speedV = 0;
        }
        else
        {
            speedV = speedDefault;
        }

        //Movemos la nave, pero vamos a suavizar el vector hacia el que se mueve
        currentPos = Vector3.SmoothDamp(currentPos, move, ref smoothInputVelocity, SmoothVelocity);

        //El movimiento que sea realitivo a las coordenadas del mundo, para poder rotar la nave
        transform.Translate(Vector3.up * currentPos.y * speedV * Time.deltaTime, Space.World);
        transform.Translate(Vector3.right * currentPos.x * speedH * Time.deltaTime, Space.World);

        //Vamos a girar pero también suavizado
        Vector3 vectorRot = new Vector3(move.y * -45f, 0, -maxAng * move.x);
        currentRot = Vector3.SmoothDamp(currentRot, vectorRot, ref smoothInputRotVelocity, RotateVelocity);

        transform.eulerAngles = currentRot;
    }


    private void OnEnable()
    {
        inputController.Enable();
    }

    private void OnDisable()
    {
        inputController.Disable();
    }
}
