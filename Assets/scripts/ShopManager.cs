using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public CaldoDEDragonLogo CDDL;
    public CaldoCoins CC;
    // Logos
    public GameObject BaronBuyB;
    public GameObject ConsejoOmegaBuyB;
    public GameObject KaironBuyB;
    public GameObject RaxxarBuyB;
    public GameObject RelojAstralBuyB;
    public GameObject tribunalBuyB;
    public GameObject BaronEquipB;
    public GameObject ConsejoOmegaEquipB;
    public GameObject KaironEquipB;
    public GameObject RaxxarEquipB;
    public GameObject RelojAstralEquipB;
    public GameObject tribunalEquipB;
    // Heroes
    public GameObject RelojAstralEquipHeroes;
    public GameObject CaldoBuyHeroes;
    public GameObject CaldoEquipHeroes;
    // Fondos
    public GameObject BaronBuyFondo;
    public GameObject ConsejoOmegaBuyFondo;
    public GameObject KaironBuyFondo;
    public GameObject RaxxarBuyFondo;
    public GameObject RelojAstralBuyFondo;
    public GameObject tribunalBuyFondo;
    public GameObject BaronEquipFondo;
    public GameObject ConsejoOmegaEquipFondo;
    public GameObject KaironEquipFondo;
    public GameObject RaxxarEquipFondo;
    public GameObject RelojAstralEquipFondo;
    public GameObject tribunalEquipFondo;

    void Awake()
    {
        CDDL = GameObject.Find("Usuary").GetComponent<CaldoDEDragonLogo>();
    }
    private void Start()
    {
        // Actualizar logos
        UpdateLogoButtons();
        // Actualizar heroes
       
        // Actualizar fondos
        UpdateFondoButtons();
    }

    void Update()
    {
        // Actualizar logos
        UpdateLogoButtons();
        // Actualizar heroes
        // Actualizar fondos
        UpdateFondoButtons();
    }

    private void UpdateLogoButtons()
    {
        BaronBuyB.SetActive(!CDDL.Baron);
        BaronEquipB.SetActive(CDDL.Baron);
        ConsejoOmegaBuyB.SetActive(!CDDL.ConsejoOmega);
        ConsejoOmegaEquipB.SetActive(CDDL.ConsejoOmega);
        KaironBuyB.SetActive(!CDDL.Kairon);
        KaironEquipB.SetActive(CDDL.Kairon);
        RaxxarBuyB.SetActive(!CDDL.Raxxar);
        RaxxarEquipB.SetActive(CDDL.Raxxar);
        RelojAstralBuyB.SetActive(!CDDL.RelojAstral);
        RelojAstralEquipB.SetActive(CDDL.RelojAstral);
        tribunalBuyB.SetActive(!CDDL.Tribunal);
        tribunalEquipB.SetActive(CDDL.Tribunal);
    }

    

    private void UpdateFondoButtons()
    {
        BaronBuyFondo.SetActive(!CDDL.BaronFondo);
        BaronEquipFondo.SetActive(CDDL.BaronFondo);
        ConsejoOmegaBuyFondo.SetActive(!CDDL.ConsejoOmegaFondo);
        ConsejoOmegaEquipFondo.SetActive(CDDL.ConsejoOmegaFondo);
        KaironBuyFondo.SetActive(!CDDL.KaironFondo);
        KaironEquipFondo.SetActive(CDDL.KaironFondo);
        RaxxarBuyFondo.SetActive(!CDDL.RaxxarFondo);
        RaxxarEquipFondo.SetActive(CDDL.RaxxarFondo);
        RelojAstralBuyFondo.SetActive(!CDDL.RelojAstralFondo);
        RelojAstralEquipFondo.SetActive(CDDL.RelojAstralFondo);
        tribunalBuyFondo.SetActive(!CDDL.TribunalFondo);
        tribunalEquipFondo.SetActive(CDDL.TribunalFondo);
    }

    public void DefaultEquipped()
    {
        SetAllLogosInactive();
        CDDL.ActivateDefault = true;
    }

    public void BaronEquipped()
    {
        SetAllLogosInactive();
        CDDL.ActivateBaron = true;
    }

    public void ConsejoOmegaEquipped()
    {
        SetAllLogosInactive();
        CDDL.ActivateConsejoOmega = true;
    }

    public void KaironEquipped()
    {
        SetAllLogosInactive();
        CDDL.ActivateKairon = true;
    }

    public void RaxxarEquipped()
    {
        SetAllLogosInactive();
        CDDL.ActivateRaxxar = true;
    }

    public void RelojAstralEquipped()
    {
        SetAllLogosInactive();
        CDDL.ActivateRelojAstral = true;
    }

    public void TribunalEquipped()
    {
        SetAllLogosInactive();
        CDDL.ActivateTribunal = true;
    }

    private void SetAllLogosInactive()
    {
        CDDL.ActivateDefault = false;
        CDDL.ActivateBaron = false;
        CDDL.ActivateConsejoOmega = false;
        CDDL.ActivateKairon = false;
        CDDL.ActivateRaxxar = false;
        CDDL.ActivateRelojAstral = false;
        CDDL.ActivateTribunal = false;
    }

    public void BaronBuy()
    {
        if(CC.Caldocoins >= 1)
        {
            CDDL.Baron = true;
            CC.SpendCoins(1);
        }
    }

    public void ConsejoOmegaBuy()
    {
        if (CC.Caldocoins >= 1)
        {
            CDDL.ConsejoOmega = true;
            CC.SpendCoins(1);
        }
    }

    public void KaironBuy()
    {
        if (CC.Caldocoins >= 1)
        {
            CDDL.Kairon = true;
            CC.SpendCoins(1);
        }
    }

    public void RaxxarBuy()
    {
        if (CC.Caldocoins >= 1)
        {
            CDDL.Raxxar = true;
            CC.SpendCoins(1);
        }
    }

    public void RelojAstralBuy()
    {
        if (CC.Caldocoins >= 1)
        {
            CDDL.RelojAstral = true;
            CC.SpendCoins(1);
        }
    }

    public void TribunalBuy()
    {
        if (CC.Caldocoins >= 1)
        {
            CDDL.Tribunal = true;
            CC.SpendCoins(1);
        }
    }

    // Funciones para heroes
    public void RelojAstralHeroesEquipped()
    {

        SetAllHeroesInactive();
        CDDL.ActivateRelojAstralHeroes = true;
    }
    public void CaldoHeroesEquipped()
    {
        SetAllHeroesInactive();
        CDDL.ActivateDefaultHeroes = true;
    }

    private void SetAllHeroesInactive()
    {
        CDDL.ActivateDefaultHeroes = false;
        CDDL.ActivateAliadosHeroes = false;
        CDDL.ActivateBaronHeroes = false;
        CDDL.ActivateRelojAstralHeroes = false;
        CDDL.ActivateKaironHeroes = false;
        CDDL.ActivateRaxxarHeroes = false;
        CDDL.ActivateTribunalHeroes = false;
    }

    public void RelojAstralHeroesBuy()
    {
        if (CC.Caldocoins >= 1)
        {
            CDDL.RelojAstralHeroes = true;
            CC.SpendCoins(1);
        }
    }
    public void CaldoHeroesBuy()
    {
        if (CC.Caldocoins >= 1)
        {
            CDDL.DefaultHeroes = true;
            CC.SpendCoins(1);
        }
    }


    // Funciones para fondos
    public void BaronFondoEquipped()
    {
        SetAllFondosInactive();
        CDDL.ActivateBaronFondo = true;
    }
    public void DefaultFondoEquipped()
    {
        SetAllFondosInactive();
        CDDL.ActivateDefaultFondo = true;
    }

    public void ConsejoOmegaFondoEquipped()
    {
        SetAllFondosInactive();
        CDDL.ActivateConsejoOmegaFondo = true;
    }

    public void KaironFondoEquipped()
    {
        SetAllFondosInactive();
        CDDL.ActivateKaironFondo = true;
    }

    public void RaxxarFondoEquipped()
    {
        SetAllFondosInactive();
        CDDL.ActivateRaxxarFondo = true;
    }

    public void RelojAstralFondoEquipped()
    {
        SetAllFondosInactive();
        CDDL.ActivateRelojAstralFondo = true;
    }

    public void TribunalFondoEquipped()
    {
        SetAllFondosInactive();
        CDDL.ActivateTribunalFondo = true;
    }

    private void SetAllFondosInactive()
    {
        CDDL.ActivateDefaultFondo = false;
        CDDL.ActivateBaronFondo = false;
        CDDL.ActivateConsejoOmegaFondo = false;
        CDDL.ActivateKaironFondo = false;
        CDDL.ActivateRaxxarFondo = false;
        CDDL.ActivateRelojAstralFondo = false;
        CDDL.ActivateTribunalFondo = false;
    }

    public void BaronFondoBuy()
    {
        if (CC.Caldocoins >= 1)
        {
            CDDL.BaronFondo = true;
            CC.SpendCoins(1);
        }
    }
    public void DefaultFondoBuy()
    {
        if (CC.Caldocoins >= 1)
        {
            CDDL.BaronFondo = true;
            CC.SpendCoins(1);
        }
        
    }

    public void ConsejoOmegaFondoBuy()
    {
        if (CC.Caldocoins >= 1)
        {
            CDDL.ConsejoOmegaFondo = true;
            CC.SpendCoins(1);
        }
    }

    public void KaironFondoBuy()
    {
        if (CC.Caldocoins >= 1)
        {
            CDDL.KaironFondo = true;
            CC.SpendCoins(1);
        }
    }

    public void RaxxarFondoBuy()
    {
        if (CC.Caldocoins >= 1)
        {
            CDDL.RaxxarFondo = true;
            CC.SpendCoins(1);
        }
    }

    public void RelojAstralFondoBuy()
    {
        if (CC.Caldocoins >= 1)
        {
            CDDL.RelojAstralFondo = true;
            CC.SpendCoins(1);
        }
        
    }

    public void TribunalFondoBuy()
    {
        if (CC.Caldocoins >= 1)
        {
            CDDL.TribunalFondo = true;
            CC.SpendCoins(1);
        }
    }
}
