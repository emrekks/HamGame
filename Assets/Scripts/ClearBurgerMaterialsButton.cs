using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample
{
    public class ClearBurgerMaterialsButton : MonoBehaviour
    {
        public void OnButtonDown()
        {
            for (int i = OrderScripts.instance.sizeOfList; i > 0; i--)
            {
                foreach (var x in OrderScripts.instance.burgerMaterial)
                {
                    Destroy(x);
                }
                OrderScripts.instance.burgerMaterial.Clear();
            }
            OrderScripts.instance.altekmek = false;
            OrderScripts.instance.üstekmek = false;
            OrderScripts.instance.peynir = false;
            OrderScripts.instance.domates = false;
            OrderScripts.instance.azpismiset = false;
            OrderScripts.instance.cokpismiset = false;
            OrderScripts.instance.et = false;
            OrderScripts.instance.ortapismiset = false;
            OrderScripts.instance.yanmiset = false;
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