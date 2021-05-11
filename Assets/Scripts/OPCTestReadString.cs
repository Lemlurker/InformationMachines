using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;




namespace game4automation
{
    public class OPCTestReadString : MonoBehaviour
    {

        public TextMeshPro Text;
        public OPCUA_Node OPCUANode;


        public string stringOutput;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            stringOutput = OPCUANode.Value;
            Text.text = stringOutput;

            
        }
    }
}

