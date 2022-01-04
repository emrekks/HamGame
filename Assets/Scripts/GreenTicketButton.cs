using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample
{
    public class GreenTicketButton : MonoBehaviour
    {
        public GameObject GreenPrefab;

        public TextMeshPro ticketText;
        public int ticketCount = 0;

        public void OnButtonDown(Hand fromHand)
        {

            fromHand.TriggerHapticPulse(1000);
            Debug.Log("work");
            Instantiate(GreenPrefab, new Vector3(10.06333f, 3.659114f, 5.168297f), Quaternion.Euler(0f, 31f, 0f));
            ticketCount++;
            ticketText.text = Convert.ToString(ticketCount);
            ClockUI.instance.buttonClickSound.Play();
            ClockUI.instance.ticketCutSound.PlayDelayed(1f);
        }

        public void OnButtonUp(Hand fromHand)
        {
            //ColorSelf(Color.white);
        }

        private void ColorSelf(Color newColor)
        {
            Renderer[] renderers = this.GetComponentsInChildren<Renderer>();
            for (int rendererIndex = 0; rendererIndex < renderers.Length; rendererIndex++)
            {
                renderers[rendererIndex].material.color = newColor;
            }
        }
    }
}


