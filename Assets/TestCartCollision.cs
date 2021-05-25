using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCartCollision : MonoBehaviour
{
    public GameObject Cart1;
    public GameObject Cart2;
    public float Time2;
    public float CartDelay;
    public bool reset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Cart2.activeInHierarchy == false)
        {
            Time2 = Time2 + Time.deltaTime;
            if(Time2 > CartDelay)
            {
                Cart2.SetActive(true);
            }
        }
        if (Cart1.activeInHierarchy == false)
        {
            Cart1.SetActive(true);
        }
        if(reset == true)
        {
            Cart1.SetActive(false);
            Cart2.SetActive(false);
            Time2 = 0;
            reset = false;
        }
    }
    
}
