using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
public class OrderScripts : MonoBehaviour
{
    public GameObject AltEkmek;
    public GameObject UstEkmek;
    public GameObject Domates;
    public GameObject Et;
    public GameObject Peynir;
    public List<GameObject> burgerMaterial = new List<GameObject>();
    public Transform Referans;
    public bool altekmek = false;
    public bool üstekmek = false;
    public bool peynir = false;
    public bool domates = false;
    public bool et = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AltEkmek") && !altekmek)
        {
            burgerMaterial.Add(other.gameObject);
            other.gameObject.transform.position = Referans.position;
            altekmek = true;
            Destroy(other.GetComponent<Throwable>());
            Destroy(other.GetComponent<Interactable>());
            Destroy(other.GetComponent<VelocityEstimator>());
        }
        if (altekmek && other.gameObject.CompareTag("Domates") && !üstekmek && !domates)
        {
            burgerMaterial.Add(other.gameObject);
            other.gameObject.transform.position = Referans.position + new Vector3(0, 0.2f, 0);
            domates = true;
            Destroy(other.GetComponent<Throwable>());
            Destroy(other.GetComponent<Interactable>());
            Destroy(other.GetComponent<VelocityEstimator>());
        }
        if (altekmek && other.gameObject.CompareTag("Peynir") && !üstekmek && !peynir)
        {
            burgerMaterial.Add(other.gameObject);
            other.gameObject.transform.position = Referans.position + new Vector3(0, 0.4f, 0);
            peynir = true;
            Destroy(other.GetComponent<Throwable>());
            Destroy(other.GetComponent<Interactable>());
            Destroy(other.GetComponent<VelocityEstimator>());
        }
        if (altekmek && other.gameObject.CompareTag("Et") && !üstekmek && !et)
        {
            burgerMaterial.Add(other.gameObject);
            other.gameObject.transform.position = Referans.position + new Vector3(0, 0.6f, 0);
            et = true;
            Destroy(other.GetComponent<Throwable>());
            Destroy(other.GetComponent<Interactable>());
            Destroy(other.GetComponent<VelocityEstimator>());
        }
        if (altekmek && other.gameObject.CompareTag("UstEkmek") && !üstekmek)
        {
            burgerMaterial.Add(other.gameObject);
            other.gameObject.transform.position = Referans.position + new Vector3(0, 0.8f, 0);
            üstekmek = true;
            Destroy(other.GetComponent<Throwable>());
            Destroy(other.GetComponent<Interactable>());
            Destroy(other.GetComponent<VelocityEstimator>());
        }

    }
}
