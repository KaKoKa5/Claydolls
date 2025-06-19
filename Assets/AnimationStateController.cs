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
    int isWalkRightHash;
    int isRunRightHash;
    int isWalkLeftHash;
    int isRunLeftHash;
    bool Talk = false;
    private float interactionRange = 2f;
    private int count = 0;
    void Start()
    {
        //DEVANT
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");

        // ARRIERE
        isBackWalkingHash = Animator.StringToHash("isBackWalking");
        isBackRunningHash = Animator.StringToHash("isBackRunning");

        //DROIT
        isWalkRightHash = Animator.StringToHash("isWalkRight");
        isRunRightHash = Animator.StringToHash("isRunRight");

        //GAUCHE
        isWalkLeftHash = Animator.StringToHash("isWalkLeft");
        isRunLeftHash = Animator.StringToHash("isRunLeft");


    }

    void Update()
    {
        //DEVANT
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isRunning = animator.GetBool(isRunningHash);

        //ARRIERE
        bool isBackRunning = animator.GetBool(isBackRunningHash);
        bool isBackWalking = animator.GetBool(isBackWalkingHash);

        //DROIT
        bool isWalkingRight = animator.GetBool(isWalkRightHash);
        bool isRunRight = animator.GetBool(isRunRightHash);

        //GAUCHE
        bool isWalkingLeft = animator.GetBool(isWalkLeftHash);
        bool isRunLeft = animator.GetBool(isRunLeftHash);

        //TOUCHE
        bool runPressed = Input.GetKey("left shift");
        bool forwardPressed = Input.GetKey("w");
        bool BackPressed = Input.GetKey("s");
        bool LEFTPressed = Input.GetKey("a");
        bool RIGHTPressed = Input.GetKey("d");

        //Animation de marche---------------------------------------------
        if (!isWalking && forwardPressed && Talk == false)
        {
            animator.SetBool(isWalkingHash, true);
        }

        if (isWalking && !forwardPressed && Talk == false)
        {
            animator.SetBool(isWalkingHash, false);
        }

        //Animation de marche arriere---------------------------------------------
        if (!isBackWalking && BackPressed && Talk == false)
        {
            animator.SetBool(isBackWalkingHash, true);
        }

        if (isBackWalking && !BackPressed && Talk == false)
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

        //DROIT
        if (!isWalkingRight && RIGHTPressed)
        {
            animator.SetBool(isWalkRightHash, true);
        }
        if (isWalkingRight && !RIGHTPressed)
        {
            animator.SetBool(isWalkRightHash, false);
        }
        //DROIT RUN
        if (!isRunRight && (RIGHTPressed && runPressed))
        {
            animator.SetBool(isRunRightHash, true);
        }
        if (isRunRight && (!RIGHTPressed || !runPressed))
        {
            animator.SetBool(isRunRightHash, false);
        }

        //GAUCHE
        if (!isWalkingLeft && LEFTPressed)
        {
            animator.SetBool("isWalkLeft", true);

        }
        if (isWalkingLeft && !LEFTPressed)
        {
            animator.SetBool(isWalkLeftHash, false);
        }
        //GAUCHE RUN
        if (!isRunLeft && (LEFTPressed && runPressed))
        {
            animator.SetBool(isRunLeftHash, true);

        }
        if (isRunLeft && (!LEFTPressed || !runPressed))
        {
            animator.SetBool(isRunLeftHash, false);
        }


    }
}

