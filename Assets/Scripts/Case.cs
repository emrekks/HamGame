using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Case : MonoBehaviour
{
    #region Singleton

    public static Case instance;
    private void Awake()
    {
        instance = this;
    }

    #endregion
    
    public int MoneyAmount = 10;

    public TextMeshPro moneyText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = MoneyAmount + "$";
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == 8)
        {

            ClockUI.instance.moneyInCashSound.Play();

            if (collision.gameObject.CompareTag("Money1"))
            {
                MoneyAmount += 1;
            }
            if (collision.gameObject.CompareTag("Money5"))
            {
                MoneyAmount += 5;
            }
            if (collision.gameObject.CompareTag("Money10"))
            {
                MoneyAmount += 10;
            }
            Destroy(collision.gameObject);
        }
    }

}
