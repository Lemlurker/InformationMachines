using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine4BackupControl : MonoBehaviour
{
    public bool BackupMode;
    public GameObject PreviousTrigger;
    public float TimeFromPreviousTrigger;
    public bool TriggerActivated;
    public float TimeTrigger;
    public GameObject LightOn;
    public GameObject LightOff;
    public float LightOnTime;
    public float LightOnDuration;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(BackupMode == true)
        {
            if (PreviousTrigger.activeInHierarchy)
            {
                TimeTrigger = 0;
                TriggerActivated = true;
            }
            if (TriggerActivated == true)
            {
                TimeTrigger = TimeTrigger + Time.deltaTime;
                if(TimeTrigger > TimeFromPreviousTrigger)
                {
                    LightOn.SetActive(true);
                    LightOff.SetActive(false);
                    LightOnTime = 0;
                    TriggerActivated = false;
                }
            }
            if(LightOn.activeInHierarchy == true)
            {
                LightOnTime = LightOnTime + Time.deltaTime;

                if(LightOnTime > LightOnDuration)
                {
                    LightOn.SetActive(false);
                    LightOff.SetActive(true);
                }
            }

        }
    }
}
