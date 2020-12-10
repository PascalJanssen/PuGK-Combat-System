using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private int speed = 1;

    [SerializeField]
    private Animator animator;

    public void Move(Vector3 direction)
    {
        transform.position += direction * Time.deltaTime * speed;
        animator.SetFloat("Move", direction.z);
    }
}
