using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace game4automation
{


    public class CartControlScript : MonoBehaviour
    {
        public bool Arrived;
        public float RunTime;
        public float CurrentTime;
        public OPCTestReadString CurrentValue;
        private string CurrentValueOld;
        public ServerControlMaster ServerControl;
        
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        { 
            if(ServerControl.DeveloperMode == true)
            {
                CurrentTime = CurrentTime + Time.deltaTime;
                if (CurrentTime > RunTime)
                {
                    Arrived = true;
                }
            }
            
            if (ServerControl.DeveloperMode == false)
            {
                if(CurrentValue.stringOutput != CurrentValueOld)
                {
                    Arrived = true;
                    CurrentValueOld = CurrentValue.stringOutput;
                }
            }

        }
    }
}
