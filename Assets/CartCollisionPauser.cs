using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartCollisionPauser : MonoBehaviour
{
    Animator m_Animator;
    public CartClock ClockToHold;
    public bool AnimationPaused;
    private bool AnimationPausedOld;
    public float HoldTime;
    public GameObject ReleaseTrigger;
    private bool ReleaseTriggerOld;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (AnimationPaused != AnimationPausedOld)
        {
            HoldTime = ClockToHold.CartTime;
            AnimationPausedOld = AnimationPaused;
        }
        if (AnimationPaused == true && AnimationPaused == AnimationPausedOld)
        {
            m_Animator.speed = 0;
            ClockToHold.CartTime = HoldTime;

        }
        else
        {
            m_Animator.speed = 1;
        }
        if(ReleaseTrigger.activeInHierarchy != ReleaseTriggerOld)
        {
            ReleaseTriggerOld = ReleaseTrigger.activeInHierarchy;
        }
        if(ReleaseTrigger.activeInHierarchy == true && ReleaseTrigger.activeInHierarchy == ReleaseTriggerOld)
        {
            AnimationPaused = false;
            
        }

    }
    private void OnTriggerStay(Collider other)
    {
        AnimationPaused = true;
    }
  
    
}
