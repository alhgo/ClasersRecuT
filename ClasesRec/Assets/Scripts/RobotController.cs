using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{

    InputController controller;

    Animator animator;

    //Correr
    bool corriendo = false;
    bool estoyCorriendo = false;

    //Andar
    float caminar;


    private void Awake()
    {
        controller = new InputController();

        controller.RobotMove.Jump.started += _ => Saltar();

        controller.RobotMove.Run.performed += _ => { corriendo = true; };
        controller.RobotMove.Run.canceled += _ => { corriendo = false; };

        controller.RobotMove.Walk.performed += ctx => caminar = ctx.ReadValue<float>();
        controller.RobotMove.Walk.canceled += _ => caminar = 0f;


    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("IsGrounded", true);
    }

    // Update is called once per frame
    void Update()
    {
        Correr();

        print(caminar);
        animator.SetFloat("Walk", caminar);
    }

    void Correr()
    {
        if (!estoyCorriendo && corriendo)
        {
            animator.SetBool("Running", true);
            estoyCorriendo = true;
            print("He comenzado a correr");
        }
        else if (!corriendo && estoyCorriendo)
        {
            animator.SetBool("Running", false);
            estoyCorriendo = false;
            print("He dejado de correr");
        }
    }

    //Método para hacer que salte
    void Saltar()
    {
        print("Estoy saltando");
        animator.SetTrigger("Jump");
       
    }


    private void OnEnable()
    {
        controller.Enable();
    }

    private void OnDisable()
    {
        controller.Disable();
    }
}
