using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace game4automation
{
    public class MachineCartTracker : MonoBehaviour
    {
        public string MachineName;
        public GameObject ReleaseTrigger;

        public bool ReleaseTriggerOld;
        public GameObject AlternateRouteTrigger;

        public GameObject Cart;
        public CartControlScript CartControl;
        public GameObject BackupCart;
        public CartControlScript BackupCartControl;
        public GameObject OldCart1;
        public CartControlScript OldCart1Script;
        public GameObject OldCart2;
        public CartControlScript OldCart2Script;
        public bool CartArrived;
        public float RunTime;
        public float CurrentTime;




        // Start is called before the first frame update
        void Start()
        {
            Cart.SetActive(false);

        }

        // Update is called once per frame
        void Update()
        {
            CurrentTime = CurrentTime + Time.deltaTime;
            if (ReleaseTrigger.activeInHierarchy == true && ReleaseTriggerOld != ReleaseTrigger.activeInHierarchy && AlternateRouteTrigger.activeInHierarchy == true)
            {
                Cart.SetActive(true);
                
                if (CartControl.Arrived == false)
                {
                    //BackupCart.SetActive(true);
                }
                CurrentTime = 0;

                if (OldCart1Script.Arrived == true)
                {
                    OldCart1.SetActive(false);
                    OldCart1Script.CurrentTime = 0;
                    OldCart1Script.Arrived = false;
                }
                if (OldCart2Script.Arrived == true)
                {
                    OldCart2.SetActive(false);
                    OldCart2Script.CurrentTime = 0;
                    OldCart2Script.Arrived = false;
                }
                if (BackupCartControl.Arrived == true)
                {
                    BackupCart.SetActive(false);
                    BackupCartControl.CurrentTime = 0;
                    BackupCartControl.Arrived = false;
                }

                ReleaseTriggerOld = ReleaseTrigger.activeInHierarchy;
                CartArrived = false;


            }

            if (CurrentTime > RunTime)
            {


                CurrentTime = 0;
                ReleaseTriggerOld = ReleaseTrigger.activeInHierarchy;
            }

            /*while(ReleaseTrigger.activeInHierarchy == true && ReleaseTriggerOld!= ReleaseTrigger.activeInHierarchy)
            {
                Cart.SetActive(true);
                CurrentTime = 0;
                ReleaseTriggerOld = ReleaseTrigger.activeInHierarchy;
                CartArrived = false;
            }
            if (CurrentTime > RunTime)
            {


                CurrentTime = 0;
                ReleaseTriggerOld = ReleaseTrigger.activeInHierarchy;

            }*/
        }
    }
}
