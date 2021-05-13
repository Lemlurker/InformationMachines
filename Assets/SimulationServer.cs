using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulationServer : MonoBehaviour
{
    public float GlobalTime;
    //machine1outputs
    public int Machine1CartID1 = 1;//front
    private int Machine1CartID1Old;
    public int Machine1CartID2 = 1 ;//rear
    private int Machine1CartID2Old;
    public bool Machine1Stop1;//front
    public bool Machine1Stop2;//rear
    public float Machine1Time;//Time
    public float Machine1Stopper1Time;
    public float Machine1Stopper2Time;
    //machine2outputs
    public int Machine2CartID1 = 1;//front
    private int Machine2CartID1Old;
    public int Machine2CartID2 = 1; //rear
    private int Machine2CartID2Old;
    public bool Machine2Stop1; //front
    public bool machine2Stop2; //rear
    public bool machine2Stop3; //intake
    public bool Flipper; //RedirectTool

    //machine3outputs
    public int Machine3CartID1 = 1;//front
    private int Machine3CartID1Old;
    public int Machine3CartID2 = 1; //rear divertion
    private int Machine3CartID2Old;
    public bool Machine3Stop1; //front
    public bool machine3Stop2; //rear diversionm
    public bool machine3Stop3; //hold for rejoin

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        



    }
}
