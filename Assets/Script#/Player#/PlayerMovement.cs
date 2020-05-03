using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private PlayerState state;
    private float horizontalMove = 0.0f;
    private bool jump = false;
    private bool falling = false;
    private float floatingtimer;

    public CharacterController2D controller;
    public float runspeed = 10.0f;
    public float Tempreture = 0.0f;



    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        state = GetComponent<PlayerState>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;

        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
            floatingtimer = 1.5f;
        }

        if(state.GetPlayerState() == PlayerState.State.AIR  && controller.GetGrounded() == false)
        {
            Vector2 move = new Vector2(0, 1.0f * 380 * Time.deltaTime);
            rigidbody.AddForce(move);
        }

        if(floatingtimer > 0)
        {
            floatingtimer -= Time.deltaTime;
        }

        if(floatingtimer < 1.0)
        {
            falling = true;
        }

        if(floatingtimer <= 0)
        {
            falling = false;
        }

        if (Tempreture >= 100.0f)
        {
            state.Change_State(PlayerState.State.AIR);
        }

        if (Tempreture < 100.0f && Tempreture > 0)
        {
            state.Change_State(PlayerState.State.WATER);
        }

        if (Tempreture <= 0.0f)
        {
            state.Change_State(PlayerState.State.ICE);
        }

    }

    private void FixedUpdate()
    {
        if (state.GetPlayerState() != PlayerState.State.AIR)
        {
            controller.ChangeJumpForce(200);
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        }
        else
        {
            controller.ChangeJumpForce(110);
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        }
        jump = false;
    }

    public void ChangingTempreture(float f_temp)
    {
        Tempreture += f_temp;
    }
}
