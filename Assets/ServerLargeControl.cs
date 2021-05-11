using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using game4automation;

public class ServerLargeControl : MonoBehaviour
{
    public OPCUA_Interface Machine;
    public string MachineAddress;
    public OPCUA_Node MachineBool1;
    public string MachineBool1Address;
    public OPCUA_Node MachineBool2;
    public string MachineBool2Address;
    public OPCUA_Node MachineString1;
    public string MachineString1Address;
    public OPCUA_Node MachineString2;
    public string MachineString2Address;
    // Start is called before the first frame update
    void Awake()
    {
        Machine.Server = MachineAddress;
        MachineBool1.NodeId = MachineBool1Address;
        MachineBool2.NodeId = MachineBool2Address;
        MachineString1.NodeId = MachineString1Address;
        MachineString2.NodeId = MachineString2Address;
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
