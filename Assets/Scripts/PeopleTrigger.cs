using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleTrigger : MonoBehaviour
{

    #region Singleton


    public static PeopleTrigger instance;
    public void Awake()
    {
        instance = this;
    }

    #endregion
    
    

    [HideInInspector] public bool spotFull = false;
    
    
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
        if (other.gameObject.CompareTag("People"))
        {
            spotFull = true;
        }
        else
        {
            spotFull = false;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("People"))
        {
            spotFull = false;
        }
    }
}
