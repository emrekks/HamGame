using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample
{
    public class SpawnMaterials : MonoBehaviour
    {
        public int SpawnObject;
        public GameObject[] materials;
        public void OnButtonDown()
        {
            
            if (SpawnObject == 1)
            {
                ClockUI.instance.buttonClickSound.Play();
                Instantiate(materials[0], new Vector3(8.6f, 3.285f, 0.716f), Quaternion.Euler(0f, 0f, 0f));
            }

            if (SpawnObject == 2)
            {
                ClockUI.instance.buttonClickSound.Play();
                Instantiate(materials[1], new Vector3(8.6f, 3.285f, 2.126f), Quaternion.Euler(0f, 0f, 0f));
            }

            if (SpawnObject == 3)
            {
                ClockUI.instance.buttonClickSound.Play();
                Instantiate(materials[2], new Vector3(8.6f, 3.285f, 1.386f), Quaternion.Euler(0f, 0f, 0f));
            }

            if (SpawnObject == 4)
            {
                ClockUI.instance.buttonClickSound.Play();
                Instantiate(materials[3], new Vector3(8.6f, 3.285f, 2.663f), Quaternion.Euler(0f, 0f, 0f));
            }

            if (SpawnObject == 5)
            {
                ClockUI.instance.buttonClickSound.Play();
                Instantiate(materials[4], new Vector3(8.6f, 3.285f, 3.369f), Quaternion.Euler(0f, 0f, 0f));
            }

            if (SpawnObject == 6)
            {
                ClockUI.instance.buttonClickSound.Play();
                Instantiate(materials[5], new Vector3(8.6f, 3.285f, 3.948f), Quaternion.Euler(0f, 0f, 0f));
            }

            if (SpawnObject == 7)
            {
                ClockUI.instance.buttonClickSound.Play();
                Instantiate(materials[6], new Vector3(8.6f, 3.285f, 0.2443507f), Quaternion.Euler(0f, 0f, 0f));
            }

            if (SpawnObject == 8)
            {
                ClockUI.instance.otomat.Play();
                Instantiate(materials[7], new Vector3(11.36f, 3.251f, 7.826f), Quaternion.Euler(0f, 0f, 90f));
            }

            if (SpawnObject == 9)
            {
                ClockUI.instance.otomat.Play();
                Instantiate(materials[8], new Vector3(11.36f, 3.251f, 7.826f), Quaternion.Euler(0f, 0f, 90f));
            }

            if (SpawnObject == 10)
            {
                ClockUI.instance.otomat.Play();
                Instantiate(materials[9], new Vector3(11.36f, 3.251f, 7.826f), Quaternion.Euler(0f, 0f, 90f));
            }

            if (SpawnObject == 11)
            {
                ClockUI.instance.otomat.Play();
                Instantiate(materials[10], new Vector3(11.36f, 3.251f, 7.826f), Quaternion.Euler(0f, 0f, 90f));
            }
        }

        public void OnButtonUp()
        {
            
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


