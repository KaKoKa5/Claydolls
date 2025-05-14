using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class AnimationStateController : MonoBehaviour
{
Animator animator;
int isWalkingHash;
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
    }

    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool forwardPressed = Input.GetKey("w");

        if (!isWalking && forwardPressed)
        {
            animator.SetBool(isWalkingHash,true);
        }

        if(isWalking && !forwardPressed)
        {
            animator.SetBool(isWalkingHash,false);
        }
        
    }
}
