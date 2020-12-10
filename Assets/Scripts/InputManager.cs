using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private MovementInput Player;
    private float lastWalkTime;
    public float walkSpeed = 5;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if(lastWalkTime > Time.fixedTime - 0.5f)
            {
                Player.Velocity = 3 + walkSpeed * ((Time.fixedTime - lastWalkTime) / 0.5f);
                Player.anim.SetFloat("Blend", 1 + walkSpeed * ((Time.fixedTime - lastWalkTime) / 0.5f));
            }
            else
            {
                Player.Velocity = walkSpeed;
                Player.anim.SetFloat("Blend", 1 + walkSpeed);
            }

        }
        else
        {
            Player.Velocity = 3;
            lastWalkTime = Time.fixedTime;
        }
        //MovementInputs();
    }

    private void MovementInputs()
    {
        Vector3 direction = new Vector3();

        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }

        //Player.Move(direction);
    }
}
