using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    //Input System
    InputController inputs;
    Vector2 move;

    Animator animator;

    bool cansado = true;

    //variables para el salto
    [SerializeField] float jumpSpeed = 5.0F;  //Fuerza del salto
    [SerializeField] float gravity = 9.8F; //Fuerza de la gravedad
    Vector3 fallDirection = new Vector3();  //Vector que nos empujará hacia abajo

    //Componente del character controler
    CharacterController cc;

    private void Awake()
    {
        inputs = new InputController();

        inputs.PlayerMove.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        inputs.PlayerMove.Move.canceled += _ => move = Vector2.zero;

        //Cuando saltamos ejecutamos el método Saltar
        inputs.PlayerMove.Jump.started += _ => Saltar();
    }

    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();

        //Componente de Character Controler
        cc = GetComponent<CharacterController>();

        
        Invoke("EstoyHarto", Random.Range(4,9));
    }

    private void Update()
    {
        animator.SetFloat("Walk", move.y);

        if(move.y > 0 && cansado == true)
        {
            cansado = false;
        }

        Vector3 moveDirection = transform.TransformDirection(Vector3.forward);

        //GRAVEDAD//
        //En todo momento empujamos a nuestro personaje hacia abajo
        fallDirection.y -= gravity * Time.deltaTime;
        cc.Move(fallDirection * Time.deltaTime);

    }

    //Método que aplica un movimiento hacia arriba
    void Saltar()
    {
        //Comprobamos que está tocando el suelo para evitar doble salto
        if(cc.isGrounded)
        {
            fallDirection.y = jumpSpeed;
        }
        
    }

    void EstoyHarto()
    {
        if(cansado)
        {
            animator.SetTrigger("Harto");
            cansado = false;
        }
            
    }







    private void OnEnable()
    {
        inputs.Enable();
    }

    private void OnDisable()
    {
        inputs.Disable();
    }
}
