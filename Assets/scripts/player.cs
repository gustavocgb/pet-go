using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private CharacterController controller;
    private Animator anim;

    public float speed;
    public float gravit;
    public float rotSpeed;
    
    private float rot;
    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        if(controller.isGrounded)
        {
            if(Input.GetKey(KeyCode.W))
            {
                moveDirection = Vector3.forward * speed;
                anim.SetInteger("transicao",1);
            }
            if(Input.GetKeyUp(KeyCode.W))
            {
                moveDirection = Vector3.zero;
                anim.SetInteger("transicao",0);
            }
            if(Input.GetKey(KeyCode.Q))
            {
                moveDirection = Vector3.forward * (speed+10);
                anim.SetInteger("transicao",2);
            }
            if(Input.GetKeyUp(KeyCode.Q))
            {
                moveDirection = Vector3.zero;
                anim.SetInteger("transicao",0);
            }
            if(Input.GetKey(KeyCode.M))
            {
                moveDirection = Vector3.forward * 0;
                anim.SetInteger("transicao",3);
            }
            if(Input.GetKeyUp(KeyCode.M))
            {
                moveDirection = Vector3.zero;
                anim.SetInteger("transicao",0);
            }
        }

        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);

        moveDirection.y -= gravit * Time.deltaTime;
        moveDirection = transform.TransformDirection(moveDirection);

        controller.Move(moveDirection * Time.deltaTime);
    }
}
