using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using game4automation;

public class ServerControlMaster : MonoBehaviour
{
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
    public string Bool1NodeID;
    public string Bool2NodeID;
    public string String1NodeID;
    public string String2NodeID;
    //All Machine Interfaces
    [HideInInspector]
    public OPCUA_Interface Machine1Interface;//
    [HideInInspector]
    public OPCUA_Interface Machine2Interface;//
    [HideInInspector]
    public OPCUA_Interface Machine3Interface;//
    [HideInInspector]
    public OPCUA_Interface Machine4Interface;//
    [HideInInspector]
    public OPCUA_Interface Machine5Interface;//
    [HideInInspector]
    public OPCUA_Interface Machine6Interface;//
    [HideInInspector]
    public OPCUA_Interface Machine7Interface;//
    [HideInInspector]
    public OPCUA_Interface Machine8Interface;//
    [HideInInspector]
    public OPCUA_Interface Machine9Interface;//
    //machine1 Nodes
    [HideInInspector]
    public OPCUA_Node Machine1Bool1;
    [HideInInspector]
    public OPCUA_Node Machine1Bool2;
    [HideInInspector]
    public OPCUA_Node Machine1String1;
    [HideInInspector]
    public OPCUA_Node Machine1String2;
    //machine2 Nodes
    [HideInInspector]
    public OPCUA_Node Machine2Bool1;
    [HideInInspector]
    public OPCUA_Node Machine2Bool2;
    [HideInInspector]
    public OPCUA_Node Machine2String1;
    [HideInInspector]
    public OPCUA_Node Machine2String2;
    //machine3 Nodes
    [HideInInspector]
    public OPCUA_Node Machine3Bool1;
    [HideInInspector]
    public OPCUA_Node Machine3Bool2;
    [HideInInspector]
    public OPCUA_Node Machine3String1;
    [HideInInspector]
    public OPCUA_Node Machine3String2;
    //machine4 Nodes
    [HideInInspector]
    public OPCUA_Node Machine4Bool1;
    [HideInInspector]
    public OPCUA_Node Machine4String1;
    //machine5 Nodes
    [HideInInspector]
    public OPCUA_Node Machine5Bool1;
    [HideInInspector]
    public OPCUA_Node Machine5String1;
    //machine6 Nodes
    [HideInInspector]
    public OPCUA_Node Machine6Bool1;
    [HideInInspector]
    public OPCUA_Node Machine6String1;
    //machine7 Nodes
    [HideInInspector]
    public OPCUA_Node Machine7Bool1;
    [HideInInspector]
    public OPCUA_Node Machine7String1;
    //machine8 Nodes
    [HideInInspector]
    public OPCUA_Node Machine8Bool1;
    [HideInInspector]
    public OPCUA_Node Machine8String1;
    //machine9 Nodes
    [HideInInspector]
    public OPCUA_Node Machine9Bool1;
    [HideInInspector]
    public OPCUA_Node Machine9String1;
    // Start is called before the first frame update
    void Awake()
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
        Machine1Bool1.NodeId = Bool1NodeID;
        Machine1Bool2.NodeId = Bool2NodeID;
        Machine1String1.NodeId = String1NodeID;
        Machine1String2.NodeId = String2NodeID;
        //machine2
        Machine2Bool1.NodeId = Bool1NodeID;
        Machine2Bool2.NodeId = Bool2NodeID;
        Machine2String1.NodeId = String1NodeID;
        Machine2String2.NodeId = String2NodeID;
        //Machine3
        Machine3Bool1.NodeId = Bool1NodeID;
        Machine3Bool2.NodeId = Bool2NodeID;
        Machine3String1.NodeId = String1NodeID;
        Machine3String2.NodeId = String2NodeID;
        //Machine4
        Machine4Bool1.NodeId = Bool1NodeID;
        Machine4String1.NodeId = String1NodeID;
        //Machine5
        Machine5Bool1.NodeId = Bool1NodeID;
        Machine5String1.NodeId = String1NodeID;
        //Machine6
        Machine6Bool1.NodeId = Bool1NodeID;
        Machine6String1.NodeId = String1NodeID;
        //Machine7
        Machine7Bool1.NodeId = Bool1NodeID;
        Machine7String1.NodeId = String1NodeID;
        //Machine8
        Machine8Bool1.NodeId = Bool1NodeID;
        Machine8String1.NodeId = String1NodeID;
        //Machine9
        Machine9Bool1.NodeId = Bool1NodeID;
        Machine9String1.NodeId = String1NodeID;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
