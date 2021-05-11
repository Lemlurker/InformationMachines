using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayServerStart : MonoBehaviour
{
    public float time;
    public GameObject Machines;
    public int TimeToStart;
    // Start is called before the first frame update
    void Start()
    {
        Machines.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time > TimeToStart)
        {
            Machines.SetActive(true);
        }
    }
}
