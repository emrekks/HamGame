using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class AI : MonoBehaviour
{

    #region Singleton


    public static AI instance;
    public void Awake()
    {
        instance = this;
    }

    #endregion


    public GameObject _standReferance;
    public GameObject ref2;
    //public GameObject referance;
    public bool frontFull = false;
    private NavMeshAgent _agent;
    private float peopleSpeed;
    public bool inLine = false;
    public float radius;
    private Animator anim;

    public GameObject money1;
    public GameObject money5;
    public GameObject money10;

    private Vector3 collision;

    public int rndBurgerLvl1;


    private bool canGo = false;

    public bool moneyGave = true;
    private TextMeshPro panelText;
    public bool losemoney = false;
    public GameObject moneyAreaRef;


    // Start is called before the first frame update
    void Start()
    {
        moneyAreaRef = GameObject.FindGameObjectWithTag("moneyRef");
        _standReferance = GameObject.FindGameObjectWithTag("ref");
        ref2 = GameObject.FindGameObjectWithTag("ref1");
        anim = GetComponent<Animator>();
        peopleSpeed = 2f;
        _agent = GetComponent<NavMeshAgent>();
        _agent.speed = peopleSpeed;
        if(ClockUI.instance.dayCount == 1)
        {
            rndBurgerLvl1 = Random.Range(0, 4);
        }
        if (ClockUI.instance.dayCount == 2)
        {
            rndBurgerLvl1 = Random.Range(4, 8);
        }
        if (ClockUI.instance.dayCount == 3)
        {
            rndBurgerLvl1 = Random.Range(8, 12);
        }
        panelText = GameObject.FindGameObjectWithTag("PeopleTalkText").GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("speed", _agent.speed);
        anim.SetBool("line", inLine);
        anim.SetBool("front", frontFull);


 
            if (!canGo)
            {
                _agent.SetDestination(_standReferance.transform.position);
            }
            else
            {
                _agent.SetDestination(ref2.transform.position);
                losemoney = false;
            }
        

        

        if (inLine)
        {
            PeopleInLine();
        }
        
        

        if (Mathf.Abs(Vector3.Distance(_standReferance.transform.position, transform.position)) < 2f)
        {
            inLine = true;
        }
        else
        {
            inLine = false;
        }

        if (frontFull)
        {
            _agent.enabled = false;
            //_agent.speed = 0f;
            //_agent.Stop();
            //gameObject.GetComponent<NavMeshAgent>().enabled = false;
        }
        else
        {
            _agent.enabled = true;
            //_agent.speed = peopleSpeed;
            //_agent.Resume();
            //gameObject.GetComponent<NavMeshAgent>().enabled = true;
        }



        RaycastHit hit;

        //Vector3 p1 = transform.position;
        float distanceToObstacle = 0;

        // Cast a sphere wrapping character controller 10 meters forward
        // to see if it is about to hit anything.
        if (Physics.SphereCast(transform.position, radius, transform.forward, out hit, 1f))
        {
            distanceToObstacle = hit.distance;
            collision = hit.point;

            if (distanceToObstacle < radius && hit.collider.CompareTag("People"))
            {
                frontFull = true;
            }
        }
        else
        {
            frontFull = false;
        }
    }

       private void PeopleInLine()
       {
            if (rndBurgerLvl1 == 0)
            {
                panelText.text = "Orta Pismis, Domates";
            }

            if (rndBurgerLvl1 == 1)
            {
                panelText.text = "Orta Pismis, Sadece Peynirli Hamburger";
            }

            if (rndBurgerLvl1 == 2)
            {
                panelText.text = "Orta Pismis, Marul Domates Hamburger";
            }

            if (rndBurgerLvl1 == 3)
            {
                panelText.text = "Orta Pismis Karisik Hamburger";
            }
            if(rndBurgerLvl1 == 4)
            {
                panelText.text = "Az Pismis Karisik Hamburger";
            }
            if (rndBurgerLvl1 == 5)
            {
                panelText.text = "Az Pismis, Peynir Soğan Hamburger";
            }
            if (rndBurgerLvl1 == 6)
            {
                panelText.text = "Az Pismis, Soğanlı Domatesli Hamburger";
            }

            if (rndBurgerLvl1 == 7)
            {
                panelText.text = "Az Pismis, Sadece Peynirli Hamburger";
            }
            if (rndBurgerLvl1 == 8)
            {
                panelText.text = "Cok Pismis Karisik Hamburger";
            }
            if (rndBurgerLvl1 == 9)
            {
                panelText.text = "Cok Pismis, Marul ve soğanlı Hamburger";
            }
            if (rndBurgerLvl1 == 10)
            {
                panelText.text = "Cok Pismis, Domates Soğan Marul Hamburger";
            }

            if (rndBurgerLvl1 == 11)
            {
                panelText.text = "Cok Pismis, Peynir ve Marullu Hamburger";
            }



        if (rndBurgerLvl1 == 0 && moneyGave && OrderScripts.instance.hamburger0)
            {
                //ClockUI.instance.talkSound1.Play();
                Instantiate(money10, moneyAreaRef.transform.position, Quaternion.Euler(-90f, 0f, 0f));
                canGo = true;
                OrderScripts.instance.hamburger0 = false;
                ClockUI.instance.trueTicketSound.Play();
                //ClockUI.instance.writeSound.Play();
                //ClockUI.instance.moneyPutSound.PlayDelayed(5f);
                moneyGave = false;

                if (!moneyGave)
                {
                    return;
                }
            }


            if (rndBurgerLvl1 == 1 && moneyGave && OrderScripts.instance.hamburger1)
            {
                //ClockUI.instance.talkSound2.Play();
                Instantiate(money5, moneyAreaRef.transform.position, Quaternion.Euler(-90f, 0f, 0f));
                canGo = true;
                OrderScripts.instance.hamburger1 = false;
                ClockUI.instance.trueTicketSound.Play();
                moneyGave = false;

                if (!moneyGave)
                {
                    //ClockUI.instance.writeSound.Play();
                    //ClockUI.instance.moneyPutSound.PlayDelayed(5f);
                    return;
                }
            }

        if (rndBurgerLvl1 == 2 && moneyGave && OrderScripts.instance.hamburger2)
        {
            //ClockUI.instance.talkSound2.Play();
            Instantiate(money5, moneyAreaRef.transform.position, Quaternion.Euler(-90f, 0f, 0f));
            canGo = true;
            OrderScripts.instance.hamburger2 = false;
            ClockUI.instance.trueTicketSound.Play();
            moneyGave = false;

            if (!moneyGave)
            {
                //ClockUI.instance.writeSound.Play();
                //ClockUI.instance.moneyPutSound.PlayDelayed(5f);
                return;
            }
        }

        if (rndBurgerLvl1 == 3 && moneyGave && OrderScripts.instance.hamburger3)
        {
            //ClockUI.instance.talkSound2.Play();
            Instantiate(money5, moneyAreaRef.transform.position, Quaternion.Euler(-90f, 0f, 0f));
            canGo = true;
            OrderScripts.instance.hamburger3 = false;
            ClockUI.instance.trueTicketSound.Play();
            moneyGave = false;

            if (!moneyGave)
            {
                //ClockUI.instance.writeSound.Play();
                //ClockUI.instance.moneyPutSound.PlayDelayed(5f);
                return;
            }
        }
        if (rndBurgerLvl1 == 4 && moneyGave && OrderScripts.instance.hamburger4)
        {
            //ClockUI.instance.talkSound2.Play();
            Instantiate(money5, moneyAreaRef.transform.position, Quaternion.Euler(-90f, 0f, 0f));
            canGo = true;
            OrderScripts.instance.hamburger4 = false;
            ClockUI.instance.trueTicketSound.Play();
            moneyGave = false;

            if (!moneyGave)
            {
                //ClockUI.instance.writeSound.Play();
                //ClockUI.instance.moneyPutSound.PlayDelayed(5f);
                return;
            }
        }
        if (rndBurgerLvl1 == 5 && moneyGave && OrderScripts.instance.hamburger5)
        {
            //ClockUI.instance.talkSound2.Play();
            Instantiate(money5, moneyAreaRef.transform.position, Quaternion.Euler(-90f, 0f, 0f));
            canGo = true;
            OrderScripts.instance.hamburger5 = false;
            ClockUI.instance.trueTicketSound.Play();
            moneyGave = false;

            if (!moneyGave)
            {
                //ClockUI.instance.writeSound.Play();
                //ClockUI.instance.moneyPutSound.PlayDelayed(5f);
                return;
            }
        }
        if (rndBurgerLvl1 == 6 && moneyGave && OrderScripts.instance.hamburger6)
        {
            //ClockUI.instance.talkSound2.Play();
            Instantiate(money5, moneyAreaRef.transform.position, Quaternion.Euler(-90f, 0f, 0f));
            canGo = true;
            OrderScripts.instance.hamburger6 = false;
            ClockUI.instance.trueTicketSound.Play();
            moneyGave = false;

            if (!moneyGave)
            {
                //ClockUI.instance.writeSound.Play();
                //ClockUI.instance.moneyPutSound.PlayDelayed(5f);
                return;
            }
        }
        if (rndBurgerLvl1 == 7 && moneyGave && OrderScripts.instance.hamburger7)
        {
            //ClockUI.instance.talkSound2.Play();
            Instantiate(money5, moneyAreaRef.transform.position, Quaternion.Euler(-90f, 0f, 0f));
            canGo = true;
            OrderScripts.instance.hamburger7 = false;
            ClockUI.instance.trueTicketSound.Play();
            moneyGave = false;

            if (!moneyGave)
            {
                //ClockUI.instance.writeSound.Play();
                //ClockUI.instance.moneyPutSound.PlayDelayed(5f);
                return;
            }
        }
        if (rndBurgerLvl1 == 8 && moneyGave && OrderScripts.instance.hamburger8)
        {
            //ClockUI.instance.talkSound2.Play();
            Instantiate(money5, moneyAreaRef.transform.position, Quaternion.Euler(-90f, 0f, 0f));
            canGo = true;
            OrderScripts.instance.hamburger8 = false;
            ClockUI.instance.trueTicketSound.Play();
            moneyGave = false;

            if (!moneyGave)
            {
                //ClockUI.instance.writeSound.Play();
                //ClockUI.instance.moneyPutSound.PlayDelayed(5f);
                return;
            }
        }
        if (rndBurgerLvl1 == 9 && moneyGave && OrderScripts.instance.hamburger9)
        {
            //ClockUI.instance.talkSound2.Play();
            Instantiate(money5, moneyAreaRef.transform.position, Quaternion.Euler(-90f, 0f, 0f));
            canGo = true;
            OrderScripts.instance.hamburger9 = false;
            ClockUI.instance.trueTicketSound.Play();
            moneyGave = false;

            if (!moneyGave)
            {
                //ClockUI.instance.writeSound.Play();
                //ClockUI.instance.moneyPutSound.PlayDelayed(5f);
                return;
            }
        }
        if (rndBurgerLvl1 == 10 && moneyGave && OrderScripts.instance.hamburger10)
        {
            //ClockUI.instance.talkSound2.Play();
            Instantiate(money5, moneyAreaRef.transform.position, Quaternion.Euler(-90f, 0f, 0f));
            canGo = true;
            OrderScripts.instance.hamburger10 = false;
            ClockUI.instance.trueTicketSound.Play();
            moneyGave = false;

            if (!moneyGave)
            {
                //ClockUI.instance.writeSound.Play();
                //ClockUI.instance.moneyPutSound.PlayDelayed(5f);
                return;
            }
        }
        if (rndBurgerLvl1 == 11 && moneyGave && OrderScripts.instance.hamburger11)
        {
            //ClockUI.instance.talkSound2.Play();
            Instantiate(money5, moneyAreaRef.transform.position, Quaternion.Euler(-90f, 0f, 0f));
            canGo = true;
            OrderScripts.instance.hamburger11 = false;
            ClockUI.instance.trueTicketSound.Play();
            moneyGave = false;

            if (!moneyGave)
            {
                //ClockUI.instance.writeSound.Play();
                //ClockUI.instance.moneyPutSound.PlayDelayed(5f);
                return;
            }
        }

    }


        private void OnDrawGizmosSelected()
        {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(collision, radius);
        }
}
