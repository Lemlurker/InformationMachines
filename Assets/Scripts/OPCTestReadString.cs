using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;




namespace game4automation
{
    public class OPCTestReadString : MonoBehaviour
    {

        public TextMeshPro Text;
        public OPCUA_Node OPCUANodeMachine;
        public ServerControlMaster Control;
        public int AltValue;
        public float InterGateTime;
        public float CurrentTime;
        public OPCTestRead PreviousBool;
        private bool ActivateNextBeenActive;


        public string stringOutput;

        // Start is called before the first frame update
        void Start()
        {
            AltValue = 1;
        }

        // Update is called once per frame
        void Update()
        {
            if (Control.DeveloperMode == false)
            {
                stringOutput = OPCUANodeMachine.Value;
                Text.text = stringOutput;
            }
            else
            {
                stringOutput = AltValue.ToString();
                Text.text = stringOutput;
                CurrentTime = CurrentTime + Time.deltaTime;
                
                if( PreviousBool.ActivateNext == true)
                {
                    CurrentTime = 0;
                    ActivateNextBeenActive = true;
                }
                if (CurrentTime > InterGateTime && ActivateNextBeenActive == true)
                {
                    AltValue = AltValue + 1;
                    ActivateNextBeenActive = false;
                    if(AltValue > 10)
                    {
                        AltValue = 1;
                    }
                }

            }
            
            

            
        }
    }
}

