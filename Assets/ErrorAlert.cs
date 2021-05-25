using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace game4automation
{
    public class ErrorAlert : MonoBehaviour
    {
        public string MachineID;
        public GameObject MachineWarningBox;
        public GameObject ErrorText;
        public TextMeshPro ErrorOutput;
        public OPCErrorRead ErrorBool;
        public float AlarmTime;
        private float AlarmCycleTime;
        public bool AlarmIsActive;
        public string AlarmText;
        public bool AlarmTest;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(ErrorBool.AlarmIsActive == true)
            {
                AlarmIsActive = true;
                ErrorText.SetActive(true);
                
            }
            else
            {
                AlarmIsActive = false;
                ErrorText.SetActive(false);
                MachineWarningBox.SetActive(false);
            }

            if(AlarmIsActive == true || AlarmTest == true )
            {
                //AlarmCycleTime = 0;
                AlarmCycleTime = AlarmCycleTime + Time.deltaTime;
                ErrorOutput.text = AlarmText;
                if(AlarmCycleTime > AlarmTime / 2)
                {
                    MachineWarningBox.SetActive(true);
                    if(AlarmCycleTime > AlarmTime)
                    {
                        MachineWarningBox.SetActive(false);
                        AlarmCycleTime = 0;
                    }
                }
            }
        }
    }
}
