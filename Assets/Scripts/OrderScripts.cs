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
    public GameObject AzPismisEt;
    public GameObject OrtaPismisEt;
    public GameObject CokPismisEt;
    public GameObject YanmisEt;
    public GameObject Marul;
    public GameObject Sogan;
    public GameObject VisneliSoda;
    public GameObject KarpuzluGazoz;
    public GameObject Cola;
    public GameObject UzumluSoda;
    public List<GameObject> burgerMaterial = new List<GameObject>();
    public Transform Referans;
    private GameObject makeChild;
    public int sizeOfList;


    //order
    public bool hamburger0 = false;
    public bool hamburger1 = false;
    public bool hamburger2 = false;
    public bool hamburger3 = false;
    public bool hamburger4 = false;
    public bool hamburger5 = false;
    public bool hamburger6 = false;
    public bool hamburger7 = false;
    public bool hamburger8 = false;
    public bool hamburger9 = false;
    public bool hamburger10 = false;
    public bool hamburger11 = false;


    //materials
    public bool altekmek = false;
    public bool üstekmek = false;
    public bool peynir = false;
    public bool domates = false;
    public bool et = false;
    public bool azpismiset = false;
    public bool ortapismiset = false;
    public bool cokpismiset = false;
    public bool yanmiset = false;
    public bool marul = false;
    public bool sogan = false;
    public bool cola = false;
    public bool uzumlusoda = false;
    public bool visnelisoda = false;
    public bool karpuzlugazoz = false;


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
        ClockUI.instance.tepsi.Play();
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

        if (other.gameObject.CompareTag("AzPismisEt") && !üstekmek && !azpismiset)
        {
            Destroy(other.gameObject);
            makeChild = Instantiate(AzPismisEt, Referans.position + new Vector3(0, 0.15f, 0), Quaternion.identity);
            azpismiset = true;
            burgerMaterial.Add(makeChild);
        }

        if (other.gameObject.CompareTag("OrtaPismisEt") && !üstekmek && !ortapismiset)
        {
            Destroy(other.gameObject);
            makeChild = Instantiate(OrtaPismisEt, Referans.position + new Vector3(0, 0.15f, 0), Quaternion.identity);
            ortapismiset = true;
            burgerMaterial.Add(makeChild);
        }

        if (other.gameObject.CompareTag("CokPismisEt") && !üstekmek && !cokpismiset)
        {
            Destroy(other.gameObject);
            makeChild = Instantiate(CokPismisEt, Referans.position + new Vector3(0, 0.15f, 0), Quaternion.identity);
            cokpismiset = true;
            burgerMaterial.Add(makeChild);
        }

        if (other.gameObject.CompareTag("Marul") && !üstekmek && !marul)
        {
            Destroy(other.gameObject);
            makeChild = Instantiate(Marul, Referans.position + new Vector3(0, 0.15f, 0), Quaternion.identity);
            marul = true;
            burgerMaterial.Add(makeChild);
        }

        if (other.gameObject.CompareTag("Sogan") && !üstekmek && !sogan)
        {
            Destroy(other.gameObject);
            makeChild = Instantiate(Sogan, Referans.position + new Vector3(0, 0.15f, 0), Quaternion.identity);
            sogan = true;
            burgerMaterial.Add(makeChild);
        }
        if (other.gameObject.CompareTag("YanmisEt") && !üstekmek && !yanmiset)
        {
            Destroy(other.gameObject);
            makeChild = Instantiate(YanmisEt, Referans.position + new Vector3(0, 0.15f, 0), Quaternion.identity);
            yanmiset = true;
            burgerMaterial.Add(makeChild);
        }
        if (other.gameObject.CompareTag("VisneliSoda")&& !visnelisoda)
        {
            Destroy(other.gameObject);
            makeChild = Instantiate(VisneliSoda, Referans.position + new Vector3(0, -0.10f, 0), Quaternion.identity);
            visnelisoda = true;
            burgerMaterial.Add(makeChild);
        }
        if (other.gameObject.CompareTag("KarpuzluGazoz")&& !karpuzlugazoz)
        {
            Destroy(other.gameObject);
            makeChild = Instantiate(KarpuzluGazoz, Referans.position + new Vector3(0, -0.10f, 0), Quaternion.identity);
            karpuzlugazoz = true;
            burgerMaterial.Add(makeChild);
        }
        if (other.gameObject.CompareTag("Cola") && !cola)
        {
            Destroy(other.gameObject);
            makeChild = Instantiate(Cola, Referans.position + new Vector3(0, -0.10f, 0), Quaternion.identity);
            cola = true;
            burgerMaterial.Add(makeChild);
        }
        if (other.gameObject.CompareTag("UzumluSoda") && !uzumlusoda)
        {
            Destroy(other.gameObject);
            makeChild = Instantiate(UzumluSoda, Referans.position + new Vector3(0, -0.10f, 0), Quaternion.identity);
            uzumlusoda = true;
            burgerMaterial.Add(makeChild);
        }
    }
}
