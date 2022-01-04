using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineTrigger : MonoBehaviour
{

    #region Singleton


    public static LineTrigger instanceLine;
    public void Awake()
    {
        instanceLine = this;
    }

    #endregion
    
    
    
    public bool frontFull = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Floor") || other.gameObject.CompareTag("People"))
        {
            frontFull = true;
        }
        else
        {
            frontFull = false;
        }
    }
}
