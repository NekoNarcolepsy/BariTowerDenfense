using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerController : MonoBehaviour
{
    public float Initacceleration = 300.0f;
    public float MaxSpeed = 2.0f;
    public float Jump = 5.0f;
    public float Tempreture = 0.0f;
    private float acceleration = 300.0f;
    private Rigidbody2D rigidbody2d;
    private PlayerState PlayerState;
    private bool Land = true;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        acceleration = Initacceleration;
    }

    private void Update()
    {
        int i = 0;
        if (Tempreture >= 100.0f)
        {
            PlayerState.Change_State(PlayerState.State.AIR);
        }

        if (Tempreture < 100.0f && Tempreture > 0)
        {
            PlayerState.Change_State(PlayerState.State.WATER);
        }

        if (Tempreture <= 0.0f)
        {
            PlayerState.Change_State(PlayerState.State.ICE);
        }
    }

    private void FixedUpdate()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        if(inputY == 1 && Land == true)
        {
            Vector2 move = new Vector2(0, inputY * Jump * 1000 * Time.deltaTime);
            rigidbody2d.AddForce(move);
            Land = false;
        }

        if (inputX != 0 && rigidbody2d.velocity.x < MaxSpeed && rigidbody2d.velocity.x > -MaxSpeed)
        {
            Vector2 move = new Vector2(inputX * acceleration * Time.deltaTime, 0);

            rigidbody2d.AddForce(move);

        }


    }


   public float GetAcceleration()
    {
        return acceleration;
    }

    public void AddAcceleration(float add)
    {
        acceleration += add;
    }

    public void ResetAcceleration()
    {
        acceleration = Initacceleration;
    }

    public void Landed()
    {
        Land = true;
    }

    public void ChangingTempreture(float f_temp)
    {
        Tempreture += f_temp;
    }
}
