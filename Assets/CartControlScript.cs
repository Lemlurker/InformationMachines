using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartControlScript : MonoBehaviour
{
    public bool Arrived;
    public float RunTime;
    public float CurrentTime;
    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = CurrentTime + Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime = CurrentTime + Time.deltaTime;
        if (CurrentTime > RunTime)
        {
            Arrived = true;
        }
    }
}
