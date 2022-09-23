using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : Player
{
    // Start is called before the first frame update
    void Start()
    {
        Health = 100;
        IsGrounded = false;
        currentState = PlayerState.IDLE;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
