using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class AnimationStateController : MonoBehaviour
{
Animator animator;
int isBackWalkingHash;
int isWalkingHash;
int isRunningHash;

    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isBackWalkingHash = Animator.StringToHash("isBackWalking");
        
      
    }

    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isRunning = animator.GetBool(isRunningHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        bool isBackWalking = animator.GetBool(isBackWalkingHash);
        bool BackPressed = Input.GetKey("s");
        
        //Animation de marche---------------------------------------------
        if (!isWalking && forwardPressed)
        {
            animator.SetBool(isWalkingHash,true);
        }

        if(isWalking && !forwardPressed)
        {
            animator.SetBool(isWalkingHash,false);
        }

        //Animation de marche---------------------------------------------
        if (!isBackWalking && BackPressed)
        {
            animator.SetBool(isBackWalkingHash,true);
        }

        if(isBackWalking && !BackPressed)
        {
            animator.SetBool(isBackWalkingHash,false);
        }

        //animation Run

        if(!isRunning&&(forwardPressed && runPressed))
        {
            animator.SetBool("isRunning",true);
        }

        if(isRunning&&(!forwardPressed || !runPressed))
        {
            animator.SetBool("isRunning",false);
        }        
    }
}
