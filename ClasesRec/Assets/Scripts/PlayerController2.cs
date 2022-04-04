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

    private void Awake()
    {
        inputs = new InputController();

        inputs.PlayerMove.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        inputs.PlayerMove.Move.canceled += _ => move = Vector2.zero;
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();


        Invoke("EstoyHarto", Random.Range(4,9));
    }

    private void Update()
    {
        animator.SetFloat("Walk", move.y);

        if(move.y > 0 && cansado == true)
        {
            cansado = false;
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
