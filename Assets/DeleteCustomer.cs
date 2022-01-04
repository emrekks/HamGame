using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteCustomer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("People"))
        {
            Destroy(other.gameObject);
        }
    }
}
