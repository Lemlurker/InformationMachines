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
        
        
        public string BooleanOutput;

        // Start is called before the first frame update
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {
            Value = OPCUANode.Value;


            if (Value == "True")
            {
                On.SetActive(true);
                Off.SetActive(false);
            }
            else
            {
                On.SetActive(false);
                Off.SetActive(true);
            }
        }
    }
}
