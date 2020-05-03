using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    private Animator animator;
    public enum State
    {
        ICE,
        WATER,
        AIR
    }
    public State Player_State = State.ICE;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Change_State(State s)
    {
        Player_State = s;
        Debug.Log("State" + Player_State);
        animator.SetInteger("State", (int)Player_State);
    }

    public State GetPlayerState()
    {
        return Player_State;
    }
}
