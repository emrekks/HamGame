﻿using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class AI : MonoBehaviour
{

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
    private bool losemoney = false;
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
        rndBurgerLvl1 = Random.Range(0, 2);
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
        //if (rndBurgerLvl1 == 0)
        //{
        //    if (OrderScripts.instance.hamburger1)
        //    {

        //    } 
        //}

        //if (rndBurgerLvl1 == 1)
        //{
        //    if (OrderScripts.instance.hamburger2)
        //    {

        //    }
        //}

        if (rndBurgerLvl1 == 0 && moneyGave)
        {
            //ClockUI.instance.talkSound1.Play();
            Instantiate(money10, moneyAreaRef.transform.position, Quaternion.identity);


            panelText.text = "Customer Wants Burger0";
            //ClockUI.instance.writeSound.Play();
            //ClockUI.instance.moneyPutSound.PlayDelayed(5f);
            moneyGave = false;

            if (!moneyGave)
            {
                return;
            }
        }

        if (rndBurgerLvl1 == 1 && moneyGave)
        {
            //ClockUI.instance.talkSound2.Play();
            Instantiate(money5, moneyAreaRef.transform.position, Quaternion.identity);


            moneyGave = false;
            if (!moneyGave)
            {
                panelText.text = "Customer Wants Burger1";
                //ClockUI.instance.writeSound.Play();
                //ClockUI.instance.moneyPutSound.PlayDelayed(5f);
                return;
            }
        }

        if (OrderScripts.instance.hamburger1)
        {
            if (rndBurgerLvl1 == 0 && !losemoney)
            {
                Case.instance.MoneyAmount -= 5;
                losemoney = true;
                ClockUI.instance.wrongTicketSound.Play();
            }

            else if (rndBurgerLvl1 == 1)
            {
                canGo = true;
                OrderScripts.instance.hamburger1 = false;
                ClockUI.instance.trueTicketSound.Play();
            }
        }

        if (OrderScripts.instance.hamburger2)
        {
            if (rndBurgerLvl1 == 0)
            {
                canGo = true;
                OrderScripts.instance.hamburger2 = false;
                ClockUI.instance.trueTicketSound.Play();
            }

            else if (rndBurgerLvl1 == 1 && !losemoney)
            {
                Case.instance.MoneyAmount -= 5;
                losemoney = true;
                ClockUI.instance.wrongTicketSound.Play();
            }
        }

    }


        private void OnDrawGizmosSelected()
        {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(collision, radius);
        }
}