using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public Transform kutununkonumu;
    Vector3 fark;
    void Start()
    {
        fark = transform.position - kutununkonumu.position;
    }

    
    void Update()
    {
        if(kutuhareketi.düştü_mü == false)
        {
            transform.position = kutununkonumu.position + fark;
        }
        
    }
}
