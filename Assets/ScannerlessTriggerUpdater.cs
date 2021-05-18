using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannerlessTriggerUpdater : MonoBehaviour
{
    public ServerControlMaster DevMode;
    public GameObject PreviousTrigger;
    public GameObject LightOn;
    public GameObject LightOff;
    public float DurationFromLastGate;
    public float DurationLit;
    public float CurrentTime;
    public float LitTime;
    public bool PreviousStationLit;
    public bool CurrentTimeTrue;
    public bool CurrentTimeTrueold;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //LitTime = LitTime + Time.deltaTime;
        if (DevMode.DeveloperMode == true)
        {
            if (PreviousTrigger.activeInHierarchy == true)
            {
                CurrentTime = 0;
                PreviousStationLit = true;
                

            }
           if(PreviousStationLit == true)
            {
                CurrentTime = CurrentTime + Time.deltaTime;
            }
           if ( CurrentTime > DurationFromLastGate)
            {
                LightOn.SetActive(true);
                LightOff.SetActive(false);
                
                LitTime = LitTime + Time.deltaTime;
                if(LitTime > DurationLit)
                {
                    LightOn.SetActive(false);
                    LightOff.SetActive(true);
                    CurrentTime = 0;
                    LitTime = 0;
                    PreviousStationLit = false;
                }

            }
        }
    }
}
