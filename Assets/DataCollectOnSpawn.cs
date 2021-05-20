using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


namespace game4automation
{
    public class DataCollectOnSpawn : MonoBehaviour
    {
        public OPCTestReadString StringRead;
        public TextMeshPro CarriageText;
        public string OutputValue;
        public GameObject ThisObject;
        public bool ThisObjectOld;
        // Start is called before the first frame update
        void Start()
        {
            OutputValue = StringRead.stringOutput;
            CarriageText.text = OutputValue;
        }

        // Update is called once per frame
        void Update()
        {
            OutputValue = StringRead.stringOutput;

            if(ThisObject.activeInHierarchy != ThisObjectOld)
            {

                CarriageText.text = OutputValue;
                ThisObjectOld = ThisObject.activeInHierarchy;
            }
        }
    }
}
