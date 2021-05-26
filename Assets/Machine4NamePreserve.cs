using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Machine4NamePreserve : MonoBehaviour
{
    public GameObject ReleaseTrigger;
    public TextMeshPro Cart1Text;
    public GameObject Cart1;
    public GameObject Cart2;
    public TextMeshPro Cart2Text;
    public TextMeshPro CartOutputText;
    public GameObject CartActive;
    public GameObject CartBackupActive;
    public TextMeshPro CartOutputTextBackup;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ReleaseTrigger.activeInHierarchy == true)
        {
            if(Cart1.activeInHierarchy ==true && Cart2.activeInHierarchy == false )
            {
                CartOutputText.text = Cart1Text.text;
            }
            if(Cart1.activeInHierarchy == false && Cart2.activeInHierarchy == true )
            {
                CartOutputText.text = Cart2Text.text;
            }
            if(Cart1.activeInHierarchy == true && Cart2.activeInHierarchy == true )
            {
                CartOutputText.text = Cart1Text.text;
            }


         
        }
    }
}
