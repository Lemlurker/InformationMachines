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


        public string stringOutput;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            stringOutput = OPCUANodeMachine.Value;
            Text.text = stringOutput;

            
        }
    }
}

