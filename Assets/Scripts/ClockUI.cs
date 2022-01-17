using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClockUI : MonoBehaviour
{
    
    public static ClockUI instance;
    
    public void Awake()
    {
        instance = this;
    }
    
    

    public TextMeshPro clockText;
    public TextMeshPro replayText;
    public float replayTimer = 0f;
    public bool replayBool = false;

    public AudioSource writeSound;
    public AudioSource loseSound;
    public AudioSource winSound;
    public AudioSource moneyPutSound;
    public AudioSource moneyInCashSound;
    public AudioSource trueTicketSound;
    public AudioSource wrongTicketSound;
    public AudioSource talkSound1;
    public AudioSource talkSound2;
    public AudioSource buttonClickSound;
    public AudioSource ticketCutSound;
    
    public int time = 9;
    public int time2 = 0;
    private float timer;

    public int dayCount = 1;
    public bool dayBool = false;

    public TextMeshPro daytext;
    public TextMeshPro moneyPanelText;

    private int totalMoneyCount = 50;

    private bool gamePaused = false;
    
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        daytext.text = "Day: " + dayCount;
        moneyPanelText.text = "Money: " + Case.instance.MoneyAmount + " / " + totalMoneyCount;
        timer += Time.deltaTime;

        if (replayBool)
        {
            replayTimer += Time.deltaTime;
            
            if (replayTimer >= 10f)
            {
                replayText.text = "";
                replayTimer = 0f;
                replayBool = false;
            }
        }
        
        //moneyPanelText.text = "Money: " + Case.instance.MoneyAmount + " / " + totalMoneyCount;

        if (time > 23)
        {
            time = 12;
        }

        if (timer >= 0.25f)
        {
            timer = 0f;

            if (time2 < 59)
            {
                time2++;
            }
            else
            {
                time2 = 0;
                time++;
            }
        }

        if (time2 < 10)
        {
            if (time < 10)
            {
                clockText.text = "0" + time + ":" + "0" + time2;
            }
            else
            {
                clockText.text = time + ":" + "0" + time2;
            }
        }
        else
        {
            if (time < 10)
            {
                clockText.text = "0" + time + ":" + time2;
            }
            else
            {
                clockText.text = time + ":" + time2;
            }
        }


        if (time == 23 && time2 >= 59 && !dayBool)
        {
            if (Case.instance.MoneyAmount >= totalMoneyCount && !dayBool)
            {
                dayCount++;
                dayBool = true;
                daytext.text = "Day: " + dayCount;
                Case.instance.MoneyAmount = 0;
                totalMoneyCount += 50;
                replayText.text = "NEXT DAY";
                replayBool = true;
                writeSound.Play();
                winSound.Play();
            }
            else
            {
                dayCount = 1;
                Case.instance.MoneyAmount = 0;
                totalMoneyCount = 50;
                replayText.text = "YOU LOSE";
                replayBool = true;
                writeSound.Play();
                loseSound.Play();
            }
            
        }
        
        if (time == 12 && time2 >= 00 && dayBool)
        {
            dayBool = false;
        }
        
    }

    public void OnCLick()
    {
        buttonClickSound.Play();
        Application.Quit();
    }
    
    public void GamePause()
    {
        //buttonClickSound.Play();
        
        if (!gamePaused)
        {
            Time.timeScale = 0f;
            gamePaused = true;
        }
        else
        {
            Time.timeScale = 1f;
            gamePaused = false;
        }
        
    }
    
    public void MuteGame()
    {
        if (SoundManager.instance.muted == false)
        {
            SoundManager.instance.masterGroupMute.TransitionTo(0.1f);
            SoundManager.instance.muted = true;
        }
        else
        {
            SoundManager.instance.masterGroupOpen.TransitionTo(0.1f);
            SoundManager.instance.muted = false;
        }
        
    }
}
