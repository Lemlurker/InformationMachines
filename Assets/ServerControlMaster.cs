using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using game4automation;

public class ServerControlMaster : MonoBehaviour
{
    public bool DeveloperMode;
    public SimulationServer SimulationScript;
    public GameObject Machines;
    //All Server Addresses
    public string serverAddress1;//
    public string serverAddress2;//
    public string serverAddress3;//
    public string serverAddress4;//
    public string serverAddress5;//
    public string serverAddress6;//
    public string serverAddress7;//
    public string serverAddress8;//
    public string serverAddress9;//
    //Standard Node IDs
    public string SmallBoolNodeID;
    public string SmallStringNodeID;
    //Machine1
    public string Machine1Bool1NodeID;
    public string Machine1Bool2NodeID;
    public string Machine1ID1NodeID;
    public string Machine1ID2NodeID;
    //Machine2
    public string Machine2Bool1NodeID;
    public string Machine2Bool2NodeID;
    public string Machine2Bool3NodeID;
    public string Machine2ID1NodeID;
    public string Machine2ID2NodeID;
    //Machine3
    public string Machine3Bool1NodeID;
    public string Machine3Bool2NodeID;
    public string Machine3Bool3NodeID;
    public string Machine3ID1NodeID;
    public string Machine3ID2NodeID;
    //Machine4
    public string Machine4Bool1NodeID;
    public string Machine4Bool2NodeID;
    public string Machine4Bool3NodeID;
    public string Machine4Bool4NodeID;
    public string Machine4ID1NodeID;
    
    //All Machine Interfaces
    //[HideInInspector]
    public OPCUA_Interface Machine1Interface;//
    //[HideInInspector]
    public GameObject Machine1OPCUARoot;//
    //[HideInInspector]
    public OPCUA_Interface Machine2Interface;//
    //[HideInInspector]
    public GameObject Machine2OPCUARoot;//
    //[HideInInspector]
    public OPCUA_Interface Machine3Interface;//
    //[HideInInspector]
    public GameObject Machine3OPCUARoot;//
    //[HideInInspector]
    public OPCUA_Interface Machine4Interface;//
    //[HideInInspector]
    public GameObject Machine4OPCUARoot;//
    //[HideInInspector]
    public OPCUA_Interface Machine5Interface;//
    //[HideInInspector]
    public GameObject Machine5OPCUARoot;//
    //[HideInInspector]
    public OPCUA_Interface Machine6Interface;//
    //[HideInInspector]
    public GameObject Machine6OPCUARoot;//
    //[HideInInspector]
    public OPCUA_Interface Machine7Interface;//
    //[HideInInspector]
    public GameObject Machine7OPCUARoot;//
    //[HideInInspector]
    public OPCUA_Interface Machine8Interface;//
    //[HideInInspector]
    public GameObject Machine8OPCUARoot;//
    //[HideInInspector]
    public OPCUA_Interface Machine9Interface;//
    //[HideInInspector]
    public GameObject Machine9OPCUARoot;//
    //machine1 Nodes
    //[HideInInspector]
    public OPCUA_Node Machine1Bool1;
    //[HideInInspector]
    public OPCUA_Node Machine1Bool2;
    //[HideInInspector]

    public OPCUA_Node Machine1String1;
    //[HideInInspector]
    public OPCUA_Node Machine1String2;
    //machine2 Nodes
    //[HideInInspector]
    public OPCUA_Node Machine2Bool1;
    //[HideInInspector]
    public OPCUA_Node Machine2Bool2;
    //[HideInInspector]
    public OPCUA_Node Machine2Bool3;
    //[HideInInspector]
    public OPCUA_Node Machine2String1;
    //[HideInInspector]
    public OPCUA_Node Machine2String2;
    //machine3 Nodes
    //[HideInInspector]
    public OPCUA_Node Machine3Bool1;
    //[HideInInspector]
    public OPCUA_Node Machine3Bool2;
    //[HideInInspector]
    public OPCUA_Node Machine3Bool3;
    //[HideInInspector]
    public OPCUA_Node Machine3String1;
    //[HideInInspector]
    public OPCUA_Node Machine3String2;
    //machine4 Nodes
    //[HideInInspector]
    public OPCUA_Node Machine4Bool1;
    //[HideInInspector]
    public OPCUA_Node Machine4Bool2;
     //[HideInInspector]
    public OPCUA_Node Machine4Bool3;
    //[HideInInspector]
    public OPCUA_Node Machine4Bool4;
    //[HideInInspector]
    public OPCUA_Node Machine4String1;
    //machine5 Nodes
    //[HideInInspector]
    public OPCUA_Node Machine5Bool1;
    //[HideInInspector]
    public OPCUA_Node Machine5String1;
    //machine6 Nodes
    //[HideInInspector]
    public OPCUA_Node Machine6Bool1;
    //[HideInInspector]
    public OPCUA_Node Machine6String1;
    //machine7 Nodes
    //[HideInInspector]
    public OPCUA_Node Machine7Bool1;
    //[HideInInspector]
    public OPCUA_Node Machine7String1;
    //machine8 Nodes
    //[HideInInspector]
    public OPCUA_Node Machine8Bool1;
    //[HideInInspector]
    public OPCUA_Node Machine8String1;
    //machine9 Nodes
    //[HideInInspector]
    public OPCUA_Node Machine9Bool1;
    //[HideInInspector]
    public OPCUA_Node Machine9String1;
    // Start is called before the first frame update
    void Awake()
    {
        if (DeveloperMode == false)
        {


            //Set Interface to ServerIDs
            Machine1Interface.Server = serverAddress1;
            Machine2Interface.Server = serverAddress2;
            Machine3Interface.Server = serverAddress3;
            Machine4Interface.Server = serverAddress4;
            Machine5Interface.Server = serverAddress5;
            Machine6Interface.Server = serverAddress6;
            Machine7Interface.Server = serverAddress7;
            Machine8Interface.Server = serverAddress8;
            Machine9Interface.Server = serverAddress9;
            //Set Machine Nodes to NodeIDs
            //machine1
            Machine1Bool1.NodeId = Machine1Bool1NodeID;
            Machine1Bool2.NodeId = Machine1Bool2NodeID;
            Machine1String1.NodeId = Machine1ID1NodeID;
            Machine1String2.NodeId = Machine1ID2NodeID;
            //machine2
            Machine2Bool1.NodeId = Machine2Bool1NodeID;
            Machine2Bool2.NodeId = Machine2Bool2NodeID;
            Machine2Bool3.NodeId = Machine2Bool3NodeID;
            Machine2String1.NodeId = Machine2ID1NodeID;
            Machine2String2.NodeId = Machine2ID2NodeID;
            //Machine3
            Machine3Bool1.NodeId = Machine3Bool1NodeID;
            Machine3Bool2.NodeId = Machine3Bool2NodeID;
            Machine3Bool3.NodeId = Machine3Bool3NodeID;
            Machine3String1.NodeId = Machine3ID1NodeID;
            Machine3String2.NodeId = Machine3ID2NodeID;
            //Machine4
            Machine4Bool1.NodeId = Machine4Bool1NodeID;
            Machine4Bool2.NodeId = Machine4Bool2NodeID;
            Machine4Bool3.NodeId = Machine4Bool3NodeID;
            Machine4Bool4.NodeId = Machine4Bool3NodeID;
            Machine4String1.NodeId = Machine4ID1NodeID;

            //Machine5
            Machine5Bool1.NodeId = SmallBoolNodeID;
            Machine5String1.NodeId = SmallStringNodeID;
            //Machine6
            Machine6Bool1.NodeId = SmallBoolNodeID;
            Machine6String1.NodeId = SmallStringNodeID;
            //Machine7
            Machine7Bool1.NodeId = SmallBoolNodeID;
            Machine7String1.NodeId = SmallStringNodeID;
            //Machine8
            Machine8Bool1.NodeId = SmallBoolNodeID;
            Machine8String1.NodeId = SmallStringNodeID;
            //Machine9
            Machine9Bool1.NodeId = SmallBoolNodeID;
            Machine9String1.NodeId = SmallStringNodeID;
        }
        else
        {
            //Set Interface to ServerIDs
            Machine1Interface.Server = "DevMode";
            Machine2Interface.Server = "DevMode";
            Machine3Interface.Server = "DevMode";
            Machine4Interface.Server = "DevMode";
            Machine5Interface.Server = "DevMode";
            Machine6Interface.Server = "DevMode";
            Machine7Interface.Server = "DevMode";
            Machine8Interface.Server = "DevMode";
            Machine9Interface.Server = "DevMode";
            //Set Machine Nodes to NodeIDs
            //machine1
            Machine1Bool1.NodeId = "DevMode";
            Machine1Bool2.NodeId = "DevMode";
            Machine1String1.NodeId = "DevMode";
            Machine1String2.NodeId = "DevMode";
            //machine2
            Machine2Bool1.NodeId = "DevMode";
            Machine2Bool2.NodeId = "DevMode";
            Machine2Bool3.NodeId = "DevMode";
            Machine2String1.NodeId = "DevMode";
            Machine2String2.NodeId = "DevMode";
            //Machine3
            Machine3Bool1.NodeId = "DevMode";
            Machine3Bool2.NodeId = "DevMode";
            Machine3Bool3.NodeId = "DevMode";
            Machine3String1.NodeId = "DevMode";
            Machine3String2.NodeId = "DevMode";
            //Machine4
            Machine4Bool1.NodeId = "DevMode";
            Machine4Bool2.NodeId = "DevMode";
            Machine4Bool3.NodeId = "DevMode";
            Machine4Bool4.NodeId = "DevMode";
            Machine4String1.NodeId = "DevMode";

            //Machine5
            Machine5Bool1.NodeId = "DevMode";
            Machine5String1.NodeId = "DevMode";
            //Machine6
            Machine6Bool1.NodeId = "DevMode";
            Machine6String1.NodeId = "DevMode";
            //Machine7
            Machine7Bool1.NodeId = "DevMode";
            Machine7String1.NodeId = "DevMode";
            //Machine8
            Machine8Bool1.NodeId = "DevMode";
            Machine8String1.NodeId = "DevMode";
            //Machine9
            Machine9Bool1.NodeId = "DevMode";
            Machine9String1.NodeId = "DevMode";

            Machine1OPCUARoot.SetActive(false);
            Machine2OPCUARoot.SetActive(false);
            Machine3OPCUARoot.SetActive(false);
            Machine4OPCUARoot.SetActive(false);
            Machine5OPCUARoot.SetActive(false);
            Machine6OPCUARoot.SetActive(false);
            Machine7OPCUARoot.SetActive(false);
            Machine8OPCUARoot.SetActive(false);
            Machine9OPCUARoot.SetActive(false);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
