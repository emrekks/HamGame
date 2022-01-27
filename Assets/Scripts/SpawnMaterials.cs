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
                Instantiate(materials[0], new Vector3(8.6f, 3.285f, 0.716f), Quaternion.Euler(0f, 0f, 0f));
            }

            if (SpawnObject == 2)
            {
                Instantiate(materials[1], new Vector3(8.6f, 3.285f, 2.126f), Quaternion.Euler(0f, 0f, 0f));
            }

            if (SpawnObject == 3)
            {
                Instantiate(materials[2], new Vector3(8.6f, 3.285f, 1.386f), Quaternion.Euler(0f, 0f, 0f));
            }

            if (SpawnObject == 4)
            {
                Instantiate(materials[3], new Vector3(8.6f, 3.285f, 2.663f), Quaternion.Euler(0f, 0f, 0f));
            }

            if (SpawnObject == 5)
            {
                Instantiate(materials[4], new Vector3(8.6f, 3.285f, 3.369f), Quaternion.Euler(0f, 0f, 0f));
            }

            if (SpawnObject == 6)
            {
                Instantiate(materials[5], new Vector3(8.6f, 3.285f, 3.948f), Quaternion.Euler(0f, 0f, 0f));
            }

            if (SpawnObject == 7)
            {
                Instantiate(materials[6], new Vector3(8.6f, 3.285f, 0.2443507f), Quaternion.Euler(0f, 0f, 0f));
            }

            if (SpawnObject == 8)
            {
                Instantiate(materials[7], new Vector3(11.36f, 3.251f, 7.826f), Quaternion.Euler(0f, 0f, 90f));
            }

            if (SpawnObject == 9)
            {
                Instantiate(materials[8], new Vector3(11.36f, 3.251f, 7.826f), Quaternion.Euler(0f, 0f, 90f));
            }

            if (SpawnObject == 10)
            {
                Instantiate(materials[9], new Vector3(11.36f, 3.251f, 7.826f), Quaternion.Euler(0f, 0f, 90f));
            }

            if (SpawnObject == 11)
            {
                Instantiate(materials[10], new Vector3(11.36f, 3.251f, 7.826f), Quaternion.Euler(0f, 0f, 90f));
            }
        }

        public void OnButtonUp()
        {
            ColorSelf(Color.white);
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


