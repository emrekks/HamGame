using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
public class OrderScripts : MonoBehaviour
{
    #region Singleton


    public static OrderScripts instance;
    public void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject AltEkmek;
    public GameObject UstEkmek;
    public GameObject Domates;
    public GameObject Et;
    public GameObject Peynir;
    public List<GameObject> burgerMaterial = new List<GameObject>();
    public Transform Referans;
    private GameObject makeChild;
    public int sizeOfList;


    //order
    public bool hamburger1 = false;
    public bool hamburger2 = false;

    //materials
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
        sizeOfList = burgerMaterial.Count;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AltEkmek") && !altekmek)
        {
            Destroy(other.gameObject);
            makeChild = Instantiate(AltEkmek, Referans.position + new Vector3(0, 0, 0), Quaternion.identity);
            altekmek = true;
            burgerMaterial.Add(makeChild);
        }

        if (other.gameObject.CompareTag("Domates") && !üstekmek && !domates)
        {
            Destroy(other.gameObject);
            makeChild = Instantiate(Domates, Referans.position + new Vector3(0, 0.15f, 0), Quaternion.identity);
            domates = true;
            burgerMaterial.Add(makeChild);
        }

        if (other.gameObject.CompareTag("Peynir") && !üstekmek && !peynir)
        {
            Destroy(other.gameObject);
            makeChild = Instantiate(Peynir, Referans.position + new Vector3(0, 0.15f, 0), Quaternion.identity);
            peynir = true;
            burgerMaterial.Add(makeChild);
        }

        if (other.gameObject.CompareTag("Et") && !üstekmek && !et)
        {
            Destroy(other.gameObject);
            makeChild = Instantiate(Et, Referans.position + new Vector3(0, 0.15f, 0), Quaternion.identity);
            et = true;
            burgerMaterial.Add(makeChild);
        }

        if (other.gameObject.CompareTag("UstEkmek") && !üstekmek)
        {
            Destroy(other.gameObject);
            makeChild = Instantiate(UstEkmek, Referans.position + new Vector3(0, 0.15f, 0), Quaternion.identity);
            üstekmek = true;
            burgerMaterial.Add(makeChild);
        }

    }
}
