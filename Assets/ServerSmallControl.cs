using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using game4automation;

public class ServerSmallControl : MonoBehaviour
{
    public OPCUA_Interface Machine;
    public string MachineAddress;
    public OPCUA_Node MachineBool1;
    public string MachineBool1Address;
    public OPCUA_Node MachineString1;
    public string MachineString1Address;
    
    // Start is called before the first frame update
    void Awake()
    {
        Machine.Server = MachineAddress;
        MachineBool1.NodeId = MachineBool1Address;
        MachineString1.NodeId = MachineString1Address;
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
