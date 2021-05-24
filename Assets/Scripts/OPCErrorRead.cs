using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using game4automation;

namespace game4automation
{
    public class OPCErrorRead : MonoBehaviour
    {
        public OPCUA_Node ErrorBool;
        public string NodeValue;
        public bool AlarmIsActive;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            NodeValue = ErrorBool.Value;
            if(NodeValue == "False")
            {
                AlarmIsActive = true;
            }
            else
            {
                AlarmIsActive = false;
            }
        }
    }
}
