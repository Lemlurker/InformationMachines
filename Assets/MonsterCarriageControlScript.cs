using UnityEngine;
using TMPro;
namespace game4automation
{
    public class MonsterCarriageControlScript : MonoBehaviour
    {
        public ServerControlMaster DevMode;
        //Machine4
        public GameObject Machine4ThroughCart;
        public GameObject Machine4ThroughCartBackup;
        public float Machine4ThroughDuration;
        private float Machine4ThroughTime;
        private float Machine4ThroughTimeBackup;

        //Machine5
        public GameObject Machine5Cart;
        public GameObject Machine5BackupCart;
        public OPCTestReadString Machine5ValueReader;
        public TextMeshPro Machine5Text;
        public TextMeshPro Machine5BackupText;
        public float Machine5To6Duration;
        private float Machine5RunTime;
        private float Machine5RunTimeBackup;
        public GameObject Machine5ReleaseTrigger;
        public GameObject Machine5HoldTrigger;
        public bool Machine5Triggered;
        public JustChanged Machine5JustChanged;
        public bool Machine5TriggeredStatus;
        public bool Machine5TriggeredBackup;
        public GameObject Machine6ArrivedTrigger;

        private bool Machine5CartArrived;
        private bool Machine5CartBackupArrived;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (DevMode.DeveloperMode == false)
            {


                if(Machine5JustChanged.StateChanged == true)
                {
                    Machine5Triggered = true;
                }
                else
                {
                    Machine5Triggered = false;
                }
                

                if (Machine5ReleaseTrigger.activeInHierarchy == true )
                {

                    if (Machine4ThroughTime > Machine4ThroughDuration && Machine4ThroughCart.activeInHierarchy == true)
                    {
                        Machine4ThroughCart.SetActive(false);
                    }
                    if (Machine4ThroughTimeBackup > Machine4ThroughDuration && Machine4ThroughCartBackup.activeInHierarchy == true)
                    {
                        Machine4ThroughCartBackup.SetActive(false);
                    }

                }
                

                if (Machine5Triggered == true && Machine5Cart.activeInHierarchy == false)
                {
                    Machine5Cart.SetActive(true);
                    Machine5Text.text = Machine5ValueReader.stringOutput;
                    
                    Machine5RunTime = 0;
                    if(Machine4ThroughCart.activeInHierarchy == true && Machine4ThroughTime > Machine4ThroughDuration)
                    {
                        Machine4ThroughCart.SetActive(false);
                    }
                    if (Machine4ThroughCartBackup.activeInHierarchy == true && Machine4ThroughTimeBackup > Machine4ThroughDuration)
                    {
                        Machine4ThroughCart.SetActive(false);
                    }

                }
                if (Machine5Cart.activeInHierarchy == true)
                {
                    Machine5RunTime = Machine5RunTime + Time.deltaTime;
                    
                    if (Machine5RunTime > Machine5To6Duration)
                    {
                        Machine5CartArrived = true;
                    }
                }
                
                if (Machine5Triggered == true && Machine5Cart.activeInHierarchy == true && Machine5RunTime > 5)
                {
                    Machine5BackupCart.SetActive(true);
                    Machine5BackupText.text = Machine5ValueReader.stringOutput;
                    Machine5RunTimeBackup = 0;
                    Machine5Triggered = false;
                }
                if(Machine5BackupCart.activeInHierarchy == true)
                {
                    Machine5RunTimeBackup = Machine5RunTimeBackup + Time.deltaTime;
                    if(Machine5RunTimeBackup > Machine5To6Duration)
                    {
                        Machine5CartBackupArrived = true;
                    }
                }
                if(Machine5CartArrived == true && Machine6ArrivedTrigger.activeInHierarchy == true)
                {
                    Machine5Cart.SetActive(false);
                    Machine5CartArrived = false;
                }
                if(Machine5CartBackupArrived == true && Machine6ArrivedTrigger.activeInHierarchy == true)
                {
                    Machine5BackupCart.SetActive(false);
                    Machine5CartBackupArrived = false;
                }




            }
        }
    }
}
