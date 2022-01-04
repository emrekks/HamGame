using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public GameObject[] Customer;
    public GameObject[] CustomerPrefab;
    public Transform Ref;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Customer = GameObject.FindGameObjectsWithTag("People");
        if (Customer.Length < 3)
        {
            int randomNumber = Random.Range(0, 4);
            if(randomNumber == 0)
            {
                Instantiate(CustomerPrefab[0], Ref.position, Quaternion.identity);
            }
            if (randomNumber == 1)
            {
                Instantiate(CustomerPrefab[1], Ref.position, Quaternion.identity);
            }
            if (randomNumber == 2)
            {
                Instantiate(CustomerPrefab[2], Ref.position, Quaternion.identity);
            }
            if (randomNumber == 3)
            {
                Instantiate(CustomerPrefab[3], Ref.position, Quaternion.identity);
            }
        }
    }
}
