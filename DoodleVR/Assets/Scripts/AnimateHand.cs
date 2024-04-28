using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class AnimateHand : MonoBehaviour
{
    // Start is called before the first frame update

    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;

    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        animator.SetFloat("Trigger", triggerValue);

        float gripValue = gripAnimationAction.action.ReadValue<float>();
        animator.SetFloat("Grip", gripValue);
    }
}
