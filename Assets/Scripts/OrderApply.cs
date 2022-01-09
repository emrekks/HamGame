using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample
{
    public class OrderApply : MonoBehaviour
    {
        public void OnButtonDown()
        {
            ColorSelf(Color.cyan);
            if (OrderScripts.instance.altekmek && OrderScripts.instance.üstekmek && OrderScripts.instance.et && OrderScripts.instance.domates && OrderScripts.instance.burgerMaterial[0] == OrderScripts.instance.altekmek)
            {
                OrderScripts.instance.hamburger1 = true;
                OrderScripts.instance.hamburger2 = false;
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
                OrderScripts.instance.et = false;
            }

            if (OrderScripts.instance.altekmek && OrderScripts.instance.üstekmek && OrderScripts.instance.et && OrderScripts.instance.peynir && OrderScripts.instance.burgerMaterial[0] == OrderScripts.instance.altekmek)
            {
                OrderScripts.instance.hamburger1 = false;
                OrderScripts.instance.hamburger2 = true;
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
                OrderScripts.instance.et = false;
            }

            else
            {
                if (OrderScripts.instance.üstekmek)
                {
                    Case.instance.MoneyAmount -= 5;
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
                    OrderScripts.instance.et = false;
                }
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


