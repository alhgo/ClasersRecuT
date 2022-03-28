using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    InputController controller;

    Vector2 playerMove;

    Animator animator;

    bool correr = false;

    private void Awake()
    {

        controller = new InputController();

        controller.PlayerMove.Move.performed += ctx => playerMove = ctx.ReadValue<Vector2>();
        controller.PlayerMove.Move.canceled += _ => playerMove = Vector2.zero;

        controller.PlayerMove.Run.started += _ => { correr = true; };
        controller.PlayerMove.Run.canceled += _ => { correr = false; };

    }
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        print(playerMove);

        animator.SetFloat("Walk", playerMove.y);

        animator.SetBool("Run", correr);
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
