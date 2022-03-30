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
    }

    // Update is called once per frame
    void Update()
    {

        MoverNave();

    }

    void MoverNave()
    {
        transform.Translate(Vector3.up * move.y * speedV * Time.deltaTime);
        transform.Translate(Vector3.right * move.x * speedH * Time.deltaTime);

        float posX = transform.position.x;
        float posY = transform.position.y;
        float desplX = move.x;
        float desplY = move.y;

        if ((posX > limitX && desplX > 0) || (posX < -limitX && desplX < 0))
        {
            speedH = 0;
        }
        else
        {
            speedH = speedDefault;
        }



        if ((posY > limitVT && desplY > 0) || (posY < limitVB && desplY < 0))
        {
            speedV = 0;
        }
        else
        {
            speedV = speedDefault;
        }
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
