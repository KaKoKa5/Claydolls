using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class AnimationStateController : MonoBehaviour
{
Animator animator;
int isBackWalkingHash;
int isWalkingHash;
int isRunningHash;
int isBackRunningHash;
int isSideRunningHash;
int isSideWalkHash;
int isSideRunningHashR;
int isSideWalkHashR;

    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");

        isBackWalkingHash = Animator.StringToHash("isBackWalking");
        isBackRunningHash = Animator.StringToHash("isBackRunning");

        isSideWalkHash = Animator.StringToHash("SideCACA");
        isSideRunningHash = Animator.StringToHash("SideRunning");
        isSideWalkHashR = Animator.StringToHash("SSideWalk");
        isSideRunningHashR = Animator.StringToHash("SSideRUN");
      
    }

    void Update()
    {

        bool isWalking = animator.GetBool(isWalkingHash);
        bool isRunning = animator.GetBool(isRunningHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        bool isBackRunning = animator.GetBool(isBackRunningHash);
        bool isBackWalking = animator.GetBool(isBackWalkingHash);
        bool BackPressed = Input.GetKey("s");

        bool isSideWalkR = animator.GetBool(isSideWalkHashR);
        bool isSideRunningR = animator.GetBool(isSideRunningHashR);
        bool isSideWalk = animator.GetBool(isSideWalkHash);
        bool isSideRunning = animator.GetBool(isSideRunningHash);
        bool SidePressed = Input.GetKey("q");
        bool SideRPressed = Input.GetKey("d");

        //Animation de marche---------------------------------------------
        if (!isWalking && forwardPressed)
        {
            animator.SetBool(isWalkingHash, true);
        }

        if (isWalking && !forwardPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }

        //Animation de marche arriere---------------------------------------------
        if (!isBackWalking && BackPressed)
        {
            animator.SetBool(isBackWalkingHash, true);
        }

        if (isBackWalking && !BackPressed)
        {
            animator.SetBool(isBackWalkingHash, false);
        }

        //animation Run-----------------------------

        if (!isRunning && (forwardPressed && runPressed))
        {
            animator.SetBool("isRunning", true);
        }

        if (isRunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool("isRunning", false);
        }

        //Animation course arriere
        if (!isBackRunning && (BackPressed && runPressed))
        {
            animator.SetBool("isBackRunning", true);
        }

        if (isBackRunning && (!BackPressed || !runPressed))
        {
            animator.SetBool("isBackRunning", false);
        }

        //AnimationRUNSideR
        if (!isSideRunningR && (SideRPressed && runPressed))
        {
            animator.SetBool(isSideRunningHashR, true);
        }

        if (isSideRunningR && (!SideRPressed || !runPressed))
        {
            animator.SetBool(isSideRunningHashR, false);
        }

        //animation côté R
        if (!isSideWalk && SideRPressed)
        {
            animator.SetBool("SideCACA", true);
        }

        if (isSideWalk && !SideRPressed)
        {
            animator.SetBool("SideCACA", false);
        }

        //animation côté L
        if (!isSideWalkR && SidePressed)
        {
            animator.SetBool("SSideWalk", true);
        }

        if (isSideWalkR && !SidePressed)
        {
            animator.SetBool("SSideWalk", false);
        }

        //AnimationRUNSideL
        if (!isSideRunning && (SidePressed && runPressed))
        {
            animator.SetBool("SSideRUN", true);
        }

        if (isSideRunning && (!SidePressed || !runPressed))
        {
            animator.SetBool("SSideRUN", false);
        }
        
       
    }
}
