using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartClock : MonoBehaviour
{
    public float CartTime;
    // Start is called before the first frame update
    void OnEnable()
    {
        CartTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CartTime = CartTime + Time.deltaTime; 
    }
}
