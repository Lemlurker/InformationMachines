using UnityEngine;
using TMPro;
namespace game4automation
{
    public class MonsterCarriageControlScript : MonoBehaviour
    {
        public ServerControlMaster DevMode;
        //Machine4
        //public GameObject Machine4ThroughCart;
        //public GameObject Machine4ThroughCartBackup;
        //public float Machine4ThroughDuration;
        //private float Machine4ThroughTime;
        //private float Machine4ThroughTimeBackup;

        //Machine
        public string MachineID;
        public GameObject MachineCart;
        public GameObject MachineBackupCart;
        public OPCTestReadString MachineValueReader;
        public TextMeshPro MachineText;
        public TextMeshPro MachineBackupText;
        public float MachineToNextDuration;
        public CartClock CartClock1;
        public CartClock CartClock2;
        public GameObject MachineReleaseTrigger;
        
        public bool MachineTriggered;
        public JustChanged MachineJustChanged;
        public bool MachineTriggeredStatus;
        public bool MachineTriggeredBackup;
        public GameObject NextMachineTrigger;
        public bool WorkDoneAtNext;
        

        private bool MachineCartArrived;
        private bool MachineCartBackupArrived;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (DevMode.DeveloperMode == false)
            {


                if(MachineJustChanged.StateChanged == true)
                {
                    MachineTriggered = true;
                }
                else
                {
                    MachineTriggered = false;
                }
                

                /*if (MachineReleaseTrigger.activeInHierarchy == true )
                {

                    if (Machine4ThroughTime > Machine4ThroughDuration && Machine4ThroughCart.activeInHierarchy == true)
                    {
                        Machine4ThroughCart.SetActive(false);
                    }
                    if (Machine4ThroughTimeBackup > Machine4ThroughDuration && Machine4ThroughCartBackup.activeInHierarchy == true)
                    {
                        Machine4ThroughCartBackup.SetActive(false);
                    }

                }*/
                

                if (MachineTriggered == true && MachineCart.activeInHierarchy == false)
                {
                    MachineCart.SetActive(true);
                    MachineText.text = MachineValueReader.stringOutput;
                    
                    
                    /*if(Machine4ThroughCart.activeInHierarchy == true && Machine4ThroughTime > Machine4ThroughDuration)
                    {
                        Machine4ThroughCart.SetActive(false);
                    }
                    if (Machine4ThroughCartBackup.activeInHierarchy == true && Machine4ThroughTimeBackup > Machine4ThroughDuration)
                    {
                        Machine4ThroughCart.SetActive(false);
                    }*/

                }
                if (MachineCart.activeInHierarchy == true)
                {
                    
                    
                    if (CartClock1.CartTime > MachineToNextDuration)
                    {
                        MachineCartArrived = true;
                    }
                }
                
                if (MachineTriggered == true && MachineCart.activeInHierarchy == true && CartClock1.CartTime > 5)
                {
                    MachineBackupCart.SetActive(true);
                    MachineBackupText.text = MachineValueReader.stringOutput;
                    
                    MachineTriggered = false;
                }
                if(MachineBackupCart.activeInHierarchy == true)
                {
                    
                    if(CartClock2.CartTime > MachineToNextDuration)
                    {
                        MachineCartBackupArrived = true;
                    }
                }
                if(MachineCartArrived == true && NextMachineTrigger.activeInHierarchy == true)
                {
                    MachineCart.SetActive(false);
                    MachineCartArrived = false;
                }
                if(MachineCartBackupArrived == true && NextMachineTrigger.activeInHierarchy == true)
                {
                    MachineBackupCart.SetActive(false);
                    MachineCartBackupArrived = false;
                }
                //if(MachineCart.activeInHierarchy == true && MachineRunTime > MachineToNextDuration + 3)
                //{
                //    WorkDoneAtNext = true;
                //}




            }
        }
    }
}
