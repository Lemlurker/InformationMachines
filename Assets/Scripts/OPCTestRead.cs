using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using game4automation;
//using game4automation.OPCUA_Node;

namespace game4automation
{
    public class OPCTestRead : MonoBehaviour
    {

        public GameObject On;
        public GameObject Off;
        public GameObject Boolean1;
        public OPCUA_Node OPCUANode;
        public string nodeID;
        public string Value;
        public string AltValue;
        public ServerControlMaster Control;
        private bool IfIsTrue;
        private bool IfIsTrueOld;
        public bool ActivateNext;
        public OPCTestReadString LinkedScanner;
        public int LinkedScannerCurrent;
        public int LinkedScannerOld;
        public float BoolTrueTime;
        
        
        
        public string BooleanOutput;

        // Start is called before the first frame update
        void Start()
        {
            LinkedScannerOld = LinkedScanner.AltValue;
            AltValue = "False";
            Value = "false";

        }

        // Update is called once per frame
        void Update()
        {
            if(Control.DeveloperMode == false)
            {
                Value = OPCUANode.Value;
            }
            else
            {
                LinkedScannerCurrent = LinkedScanner.AltValue;
                Value = AltValue;
                if(LinkedScannerCurrent != LinkedScannerOld)
                {
                    AltValue = "True";
                    BoolTrueTime = BoolTrueTime + Time.deltaTime;
                    if (BoolTrueTime > 0.5)
                    {
                        LinkedScannerOld = LinkedScannerCurrent;
                        BoolTrueTime = 0;
                        AltValue = "False";
                    }

                }
            }


            if (Value == "True")
            {
                On.SetActive(true);
                Off.SetActive(false);
                IfIsTrue = true;
            }
            else
            {
                On.SetActive(false);
                Off.SetActive(true);
                
            }
            if(IfIsTrue != IfIsTrueOld)
            {
                ActivateNext = true;
                IfIsTrue = false;
                IfIsTrueOld = IfIsTrue;
            }
            else
            {
                ActivateNext = false;
            }
        }
    }
}
