using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample
{
    public class PurpleTicketButton : MonoBehaviour
    {
        public GameObject PurplePrefab;

        public TextMeshPro ticketText;
        public GreenTicketButton purpleTicketButton;

        public void OnButtonDown(Hand fromHand)
        {
            //ColorSelf(Color.cyan);
            fromHand.TriggerHapticPulse(1000);
            Instantiate(PurplePrefab, new Vector3(9.744582f, 3.659114f, 4.671125f), Quaternion.Euler(0f, 31f, 0f));
            purpleTicketButton.ticketCount++;
            ticketText.text = Convert.ToString(purpleTicketButton.ticketCount);
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
