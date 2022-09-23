using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum PlayerState 
    {
        IDLE,
        MOVING,
        RUNNING,
        SLIDING,
        JUMPING, 
        FIGHTING,
    }

    public PlayerState currentState, prevState;
    public int Health { get; set; }

    public bool IsGrounded { get; set; }

    public void UpdateState() 
    {
        if (prevState != currentState) 
        {
            switch (currentState) 
            {
                
            }

            prevState = currentState;
        }
    }

   

    public void Move(Vector3 direciton, float speed) 
    {

    }

}
