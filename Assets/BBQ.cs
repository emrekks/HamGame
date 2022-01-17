using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BBQ : MonoBehaviour
{
    public GameObject Hamburger;
    public GameObject[] Et;
    public Transform ref_;
    private bool doOnce = false;
    private bool etCooking1 = false;
    private bool etCooking2 = false;
    private bool etCooking3 = false;
    private bool etCooking4 = false;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(etCooking1 == true && timer <= 5)
        {
            timer += Time.deltaTime;
            if(timer >= 5 && doOnce)
            {
                timer = 5;
                Destroy(Hamburger);
                Instantiate(Et[1], Hamburger.transform.position, Quaternion.Euler(0f, 0f, 0f));
                doOnce = false;
                etCooking1 = false;
            }
        }

        if (etCooking2 == true && timer <= 10)
        {
            timer += Time.deltaTime;
            if (timer >= 10 && doOnce)
            {
                timer = 10;
                Destroy(Hamburger);
                Instantiate(Et[2], Hamburger.transform.position, Quaternion.Euler(0f, 0f, 0f));
                doOnce = false;
                etCooking2 = false;
            }
        }

        if (etCooking3 == true && timer <= 15)
        {
            timer += Time.deltaTime;
            if (timer >= 15 && doOnce)
            {
                timer = 15;
                Destroy(Hamburger);
                Instantiate(Et[3], Hamburger.transform.position, Quaternion.Euler(0f, 0f, 0f));
                doOnce = false;
                etCooking3 = false;
            }
        }

        if (etCooking4 == true && timer <= 20)
        {
            timer += Time.deltaTime;
            if (timer >= 20 && doOnce)
            {
                timer = 20;
                Destroy(Hamburger);
                Instantiate(Et[4], Hamburger.transform.position, Quaternion.Euler(0f, 0f, 0f));
                doOnce = false;
                etCooking4 = false;
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Et") && !doOnce)
        {
            timer = 0;
            etCooking1 = true;
            Hamburger = other.gameObject;
            doOnce = true;
        }

        if (other.gameObject.CompareTag("AzPismisEt") && !doOnce)
        {
            timer = 5;
            etCooking2 = true;
            Hamburger = other.gameObject;
            doOnce = true;
        }

        if (other.gameObject.CompareTag("OrtaPismisEt") && !doOnce)
        {
            timer = 10;
            etCooking3 = true;
            Hamburger = other.gameObject;
            doOnce = true;
        }

        if (other.gameObject.CompareTag("CokPismisEt") && !doOnce)
        {
            timer = 15;
            etCooking4 = true;
            Hamburger = other.gameObject;
            doOnce = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        etCooking1 = false;
        etCooking2 = false;
        etCooking3 = false;
        etCooking4 = false;
        doOnce = false;
    }

}
