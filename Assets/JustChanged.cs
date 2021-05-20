using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustChanged : MonoBehaviour
{
    public bool StateChanged;
    public float StateDuration;
    public float statetime;
    // Start is called before the first frame update
    void OnEnable()
    {
        StateChanged = true;
        statetime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (StateChanged == true )
        {
            statetime = statetime + Time.deltaTime;
            if (statetime > StateDuration)
            {
                StateChanged = false;
                statetime = 0;
            }
            
        }
    }
}
