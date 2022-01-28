using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample
{
    public class OrderApply : MonoBehaviour
    {
        public void OnButtonDown()
        {
            ClockUI.instance.zilsound.Play();
            ColorSelf(Color.green);
            if (OrderScripts.instance.altekmek && OrderScripts.instance.üstekmek && OrderScripts.instance.ortapismiset && OrderScripts.instance.domates && OrderScripts.instance.burgerMaterial[0] == OrderScripts.instance.altekmek && !OrderScripts.instance.peynir && !OrderScripts.instance.azpismiset && !OrderScripts.instance.cokpismiset && !OrderScripts.instance.et && !OrderScripts.instance.marul && !OrderScripts.instance.sogan)
            {
                OrderScripts.instance.hamburger0 = true;
                OrderScripts.instance.hamburger1 = false;
                OrderScripts.instance.hamburger2 = false;
                OrderScripts.instance.hamburger3 = false;
                OrderScripts.instance.hamburger4 = false;
                OrderScripts.instance.hamburger5 = false;
                OrderScripts.instance.hamburger6 = false;
                OrderScripts.instance.hamburger7 = false;
                OrderScripts.instance.hamburger8 = false;
                OrderScripts.instance.hamburger9 = false;
                OrderScripts.instance.hamburger10 = false;
                OrderScripts.instance.hamburger11 = false;

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
                OrderScripts.instance.marul = false;
                OrderScripts.instance.sogan = false;
                OrderScripts.instance.uzumlusoda = false;
                OrderScripts.instance.cola = false;
                OrderScripts.instance.visnelisoda = false;
                OrderScripts.instance.karpuzlugazoz = false;
            }

            if (OrderScripts.instance.altekmek && OrderScripts.instance.üstekmek && OrderScripts.instance.ortapismiset && OrderScripts.instance.peynir && OrderScripts.instance.burgerMaterial[0] == OrderScripts.instance.altekmek && !OrderScripts.instance.domates && !OrderScripts.instance.azpismiset && !OrderScripts.instance.cokpismiset && !OrderScripts.instance.et && !OrderScripts.instance.marul && !OrderScripts.instance.sogan)
            {
                OrderScripts.instance.hamburger0 = false;
                OrderScripts.instance.hamburger1 = true;
                OrderScripts.instance.hamburger2 = false;
                OrderScripts.instance.hamburger3 = false;
                OrderScripts.instance.hamburger4 = false;
                OrderScripts.instance.hamburger5 = false;
                OrderScripts.instance.hamburger6 = false;
                OrderScripts.instance.hamburger7 = false;
                OrderScripts.instance.hamburger8 = false;
                OrderScripts.instance.hamburger9 = false;
                OrderScripts.instance.hamburger10 = false;
                OrderScripts.instance.hamburger11 = false;

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
                OrderScripts.instance.marul = false;
                OrderScripts.instance.sogan = false;
                OrderScripts.instance.uzumlusoda = false;
                OrderScripts.instance.cola = false;
                OrderScripts.instance.visnelisoda = false;
                OrderScripts.instance.karpuzlugazoz = false;
            }

            if (OrderScripts.instance.altekmek && OrderScripts.instance.üstekmek && OrderScripts.instance.ortapismiset && OrderScripts.instance.domates && OrderScripts.instance.marul && OrderScripts.instance.burgerMaterial[0] == OrderScripts.instance.altekmek && !OrderScripts.instance.azpismiset && !OrderScripts.instance.cokpismiset && !OrderScripts.instance.et && !OrderScripts.instance.yanmiset && !OrderScripts.instance.peynir && !OrderScripts.instance.sogan)
            {
                OrderScripts.instance.hamburger0 = false;
                OrderScripts.instance.hamburger1 = false;
                OrderScripts.instance.hamburger2 = true;
                OrderScripts.instance.hamburger3 = false;
                OrderScripts.instance.hamburger4 = false;
                OrderScripts.instance.hamburger5 = false;
                OrderScripts.instance.hamburger6 = false;
                OrderScripts.instance.hamburger7 = false;
                OrderScripts.instance.hamburger8 = false;
                OrderScripts.instance.hamburger9 = false;
                OrderScripts.instance.hamburger10 = false;
                OrderScripts.instance.hamburger11 = false;

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
                OrderScripts.instance.marul = false;
                OrderScripts.instance.sogan = false;
                OrderScripts.instance.uzumlusoda = false;
                OrderScripts.instance.cola = false;
                OrderScripts.instance.visnelisoda = false;
                OrderScripts.instance.karpuzlugazoz = false;
            }
            if (OrderScripts.instance.altekmek && OrderScripts.instance.üstekmek && OrderScripts.instance.ortapismiset && OrderScripts.instance.marul && OrderScripts.instance.sogan && OrderScripts.instance.domates && OrderScripts.instance.peynir && OrderScripts.instance.cola && OrderScripts.instance.burgerMaterial[0] == OrderScripts.instance.altekmek && !OrderScripts.instance.azpismiset && !OrderScripts.instance.cokpismiset && !OrderScripts.instance.et && !OrderScripts.instance.visnelisoda && !OrderScripts.instance.karpuzlugazoz && !OrderScripts.instance.uzumlusoda)
            {
                OrderScripts.instance.hamburger0 = false;
                OrderScripts.instance.hamburger1 = false;
                OrderScripts.instance.hamburger2 = false;
                OrderScripts.instance.hamburger3 = true;
                OrderScripts.instance.hamburger4 = false;
                OrderScripts.instance.hamburger5 = false;
                OrderScripts.instance.hamburger6 = false;
                OrderScripts.instance.hamburger7 = false;
                OrderScripts.instance.hamburger8 = false;
                OrderScripts.instance.hamburger9 = false;
                OrderScripts.instance.hamburger10 = false;
                OrderScripts.instance.hamburger11 = false;

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
                OrderScripts.instance.marul = false;
                OrderScripts.instance.sogan = false;
                OrderScripts.instance.uzumlusoda = false;
                OrderScripts.instance.cola = false;
                OrderScripts.instance.visnelisoda = false;
                OrderScripts.instance.karpuzlugazoz = false;
            }

            // Level 2

            if (OrderScripts.instance.altekmek && OrderScripts.instance.üstekmek && OrderScripts.instance.azpismiset && OrderScripts.instance.marul && OrderScripts.instance.visnelisoda && OrderScripts.instance.sogan && OrderScripts.instance.domates && OrderScripts.instance.peynir && OrderScripts.instance.burgerMaterial[0] == OrderScripts.instance.altekmek && !OrderScripts.instance.ortapismiset && !OrderScripts.instance.cokpismiset && !OrderScripts.instance.et && !OrderScripts.instance.cola && !OrderScripts.instance.karpuzlugazoz && !OrderScripts.instance.uzumlusoda)
            {
                OrderScripts.instance.hamburger0 = false;
                OrderScripts.instance.hamburger1 = false;
                OrderScripts.instance.hamburger2 = false;
                OrderScripts.instance.hamburger3 = false;
                OrderScripts.instance.hamburger4 = true;
                OrderScripts.instance.hamburger5 = false;
                OrderScripts.instance.hamburger6 = false;
                OrderScripts.instance.hamburger7 = false;
                OrderScripts.instance.hamburger8 = false;
                OrderScripts.instance.hamburger9 = false;
                OrderScripts.instance.hamburger10 = false;
                OrderScripts.instance.hamburger11 = false;

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
                OrderScripts.instance.marul = false;
                OrderScripts.instance.sogan = false;
                OrderScripts.instance.uzumlusoda = false;
                OrderScripts.instance.cola = false;
                OrderScripts.instance.visnelisoda = false;
                OrderScripts.instance.karpuzlugazoz = false;
            }
            if (OrderScripts.instance.altekmek && OrderScripts.instance.üstekmek && OrderScripts.instance.azpismiset && OrderScripts.instance.uzumlusoda && OrderScripts.instance.peynir && OrderScripts.instance.sogan && OrderScripts.instance.burgerMaterial[0] == OrderScripts.instance.altekmek && !OrderScripts.instance.domates && !OrderScripts.instance.ortapismiset && !OrderScripts.instance.cokpismiset && !OrderScripts.instance.et && !OrderScripts.instance.yanmiset && !OrderScripts.instance.marul && !OrderScripts.instance.cola && !OrderScripts.instance.visnelisoda && !OrderScripts.instance.karpuzlugazoz)
            {
                OrderScripts.instance.hamburger0 = false;
                OrderScripts.instance.hamburger1 = false;
                OrderScripts.instance.hamburger2 = false;
                OrderScripts.instance.hamburger3 = false;
                OrderScripts.instance.hamburger4 = false;
                OrderScripts.instance.hamburger5 = true;
                OrderScripts.instance.hamburger6 = false;
                OrderScripts.instance.hamburger7 = false;
                OrderScripts.instance.hamburger8 = false;
                OrderScripts.instance.hamburger9 = false;
                OrderScripts.instance.hamburger10 = false;
                OrderScripts.instance.hamburger11 = false;

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
                OrderScripts.instance.marul = false;
                OrderScripts.instance.sogan = false;
                OrderScripts.instance.uzumlusoda = false;
                OrderScripts.instance.cola = false;
                OrderScripts.instance.visnelisoda = false;
                OrderScripts.instance.karpuzlugazoz = false;
            }
            if (OrderScripts.instance.altekmek && OrderScripts.instance.üstekmek && OrderScripts.instance.azpismiset && OrderScripts.instance.sogan && OrderScripts.instance.domates && OrderScripts.instance.burgerMaterial[0] == OrderScripts.instance.altekmek && !OrderScripts.instance.peynir && !OrderScripts.instance.marul && !OrderScripts.instance.ortapismiset && !OrderScripts.instance.cokpismiset && !OrderScripts.instance.et)
            {
                OrderScripts.instance.hamburger0 = false;
                OrderScripts.instance.hamburger1 = false;
                OrderScripts.instance.hamburger2 = false;
                OrderScripts.instance.hamburger3 = false;
                OrderScripts.instance.hamburger4 = false;
                OrderScripts.instance.hamburger5 = false;
                OrderScripts.instance.hamburger6 = true;
                OrderScripts.instance.hamburger7 = false;
                OrderScripts.instance.hamburger8 = false;
                OrderScripts.instance.hamburger9 = false;
                OrderScripts.instance.hamburger10 = false;
                OrderScripts.instance.hamburger11 = false;

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
                OrderScripts.instance.marul = false;
                OrderScripts.instance.sogan = false;
                OrderScripts.instance.uzumlusoda = false;
                OrderScripts.instance.cola = false;
                OrderScripts.instance.visnelisoda = false;
                OrderScripts.instance.karpuzlugazoz = false;
            }

            if (OrderScripts.instance.altekmek && OrderScripts.instance.üstekmek && OrderScripts.instance.azpismiset && OrderScripts.instance.visnelisoda && OrderScripts.instance.peynir && OrderScripts.instance.burgerMaterial[0] == OrderScripts.instance.altekmek && !OrderScripts.instance.domates && !OrderScripts.instance.ortapismiset && !OrderScripts.instance.cokpismiset && !OrderScripts.instance.et && !OrderScripts.instance.marul && !OrderScripts.instance.sogan && !OrderScripts.instance.cola && !OrderScripts.instance.karpuzlugazoz && !OrderScripts.instance.uzumlusoda)
            {
                OrderScripts.instance.hamburger0 = false;
                OrderScripts.instance.hamburger1 = false;
                OrderScripts.instance.hamburger2 = false;
                OrderScripts.instance.hamburger3 = false;
                OrderScripts.instance.hamburger4 = false;
                OrderScripts.instance.hamburger5 = false;
                OrderScripts.instance.hamburger6 = false;
                OrderScripts.instance.hamburger7 = true;
                OrderScripts.instance.hamburger8 = false;
                OrderScripts.instance.hamburger9 = false;
                OrderScripts.instance.hamburger10 = false;
                OrderScripts.instance.hamburger11 = false;

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
                OrderScripts.instance.marul = false;
                OrderScripts.instance.sogan = false;
                OrderScripts.instance.uzumlusoda = false;
                OrderScripts.instance.cola = false;
                OrderScripts.instance.visnelisoda = false;
                OrderScripts.instance.karpuzlugazoz = false;
            }

            // Level 3

            if (OrderScripts.instance.altekmek && OrderScripts.instance.üstekmek && OrderScripts.instance.cokpismiset && OrderScripts.instance.sogan && OrderScripts.instance.marul && OrderScripts.instance.domates && OrderScripts.instance.peynir && OrderScripts.instance.burgerMaterial[0] == OrderScripts.instance.altekmek && !OrderScripts.instance.ortapismiset && !OrderScripts.instance.azpismiset && !OrderScripts.instance.et)
            {
                OrderScripts.instance.hamburger0 = false;
                OrderScripts.instance.hamburger1 = false;
                OrderScripts.instance.hamburger2 = false;
                OrderScripts.instance.hamburger3 = false;
                OrderScripts.instance.hamburger4 = false;
                OrderScripts.instance.hamburger5 = false;
                OrderScripts.instance.hamburger6 = false;
                OrderScripts.instance.hamburger7 = false;
                OrderScripts.instance.hamburger8 = true;
                OrderScripts.instance.hamburger9 = false;
                OrderScripts.instance.hamburger10 = false;
                OrderScripts.instance.hamburger11 = false;

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
                OrderScripts.instance.marul = false;
                OrderScripts.instance.sogan = false;
                OrderScripts.instance.uzumlusoda = false;
                OrderScripts.instance.cola = false;
                OrderScripts.instance.visnelisoda = false;
                OrderScripts.instance.karpuzlugazoz = false;
            }
            if (OrderScripts.instance.altekmek && OrderScripts.instance.üstekmek && OrderScripts.instance.cokpismiset && OrderScripts.instance.karpuzlugazoz && OrderScripts.instance.marul && OrderScripts.instance.sogan && OrderScripts.instance.burgerMaterial[0] == OrderScripts.instance.altekmek && !OrderScripts.instance.domates && !OrderScripts.instance.ortapismiset && !OrderScripts.instance.azpismiset && !OrderScripts.instance.et && !OrderScripts.instance.yanmiset && !OrderScripts.instance.peynir && !OrderScripts.instance.visnelisoda && !OrderScripts.instance.cola && !OrderScripts.instance.uzumlusoda)
            {
                OrderScripts.instance.hamburger0 = false;
                OrderScripts.instance.hamburger1 = false;
                OrderScripts.instance.hamburger2 = false;
                OrderScripts.instance.hamburger3 = false;
                OrderScripts.instance.hamburger4 = false;
                OrderScripts.instance.hamburger5 = false;
                OrderScripts.instance.hamburger6 = false;
                OrderScripts.instance.hamburger7 = false;
                OrderScripts.instance.hamburger8 = false;
                OrderScripts.instance.hamburger9 = true;
                OrderScripts.instance.hamburger10 = false;
                OrderScripts.instance.hamburger11 = false;

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
                OrderScripts.instance.marul = false;
                OrderScripts.instance.sogan = false;
                OrderScripts.instance.uzumlusoda = false;
                OrderScripts.instance.cola = false;
                OrderScripts.instance.visnelisoda = false;
                OrderScripts.instance.karpuzlugazoz = false;
            }
            if (OrderScripts.instance.altekmek && OrderScripts.instance.üstekmek && OrderScripts.instance.cokpismiset && OrderScripts.instance.domates && OrderScripts.instance.cola && OrderScripts.instance.marul && OrderScripts.instance.sogan && OrderScripts.instance.burgerMaterial[0] == OrderScripts.instance.altekmek && !OrderScripts.instance.peynir && !OrderScripts.instance.ortapismiset && !OrderScripts.instance.azpismiset && !OrderScripts.instance.et && !OrderScripts.instance.visnelisoda && !OrderScripts.instance.karpuzlugazoz && !OrderScripts.instance.uzumlusoda)
            {
                OrderScripts.instance.hamburger0 = false;
                OrderScripts.instance.hamburger1 = false;
                OrderScripts.instance.hamburger2 = false;
                OrderScripts.instance.hamburger3 = false;
                OrderScripts.instance.hamburger4 = false;
                OrderScripts.instance.hamburger5 = false;
                OrderScripts.instance.hamburger6 = false;
                OrderScripts.instance.hamburger7 = false;
                OrderScripts.instance.hamburger8 = false;
                OrderScripts.instance.hamburger9 = false;
                OrderScripts.instance.hamburger10 = true;
                OrderScripts.instance.hamburger11 = false;

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
                OrderScripts.instance.marul = false;
                OrderScripts.instance.sogan = false;
                OrderScripts.instance.uzumlusoda = false;
                OrderScripts.instance.cola = false;
                OrderScripts.instance.visnelisoda = false;
                OrderScripts.instance.karpuzlugazoz = false;
            }

            if (OrderScripts.instance.altekmek && OrderScripts.instance.üstekmek && OrderScripts.instance.cokpismiset && OrderScripts.instance.peynir && OrderScripts.instance.uzumlusoda && OrderScripts.instance.marul && OrderScripts.instance.burgerMaterial[0] == OrderScripts.instance.altekmek && !OrderScripts.instance.domates && !OrderScripts.instance.ortapismiset && !OrderScripts.instance.azpismiset && !OrderScripts.instance.et && !OrderScripts.instance.sogan && !OrderScripts.instance.cola && !OrderScripts.instance.visnelisoda && !OrderScripts.instance.karpuzlugazoz)
            {
                OrderScripts.instance.hamburger0 = false;
                OrderScripts.instance.hamburger1 = false;
                OrderScripts.instance.hamburger2 = false;
                OrderScripts.instance.hamburger3 = false;
                OrderScripts.instance.hamburger4 = false;
                OrderScripts.instance.hamburger5 = false;
                OrderScripts.instance.hamburger6 = false;
                OrderScripts.instance.hamburger7 = false;
                OrderScripts.instance.hamburger8 = false;
                OrderScripts.instance.hamburger9 = false;
                OrderScripts.instance.hamburger10 = false;
                OrderScripts.instance.hamburger11 = true;

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
                OrderScripts.instance.marul = false;
                OrderScripts.instance.sogan = false;
                OrderScripts.instance.uzumlusoda = false;
                OrderScripts.instance.cola = false;
                OrderScripts.instance.visnelisoda = false;
                OrderScripts.instance.karpuzlugazoz = false;
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
                    OrderScripts.instance.azpismiset = false;
                    OrderScripts.instance.cokpismiset = false;
                    OrderScripts.instance.et = false;
                    OrderScripts.instance.ortapismiset = false;
                    OrderScripts.instance.yanmiset = false;
                    OrderScripts.instance.uzumlusoda = false;
                    OrderScripts.instance.cola = false;
                    OrderScripts.instance.visnelisoda = false;
                    OrderScripts.instance.karpuzlugazoz = false;
                }
            }
        }

        public void OnButtonUp()
        {
            ColorSelf(Color.gray);
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


