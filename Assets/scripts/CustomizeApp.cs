using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeApp : MonoBehaviour
{
    public CaldoDEDragonLogo CDDL;


    public GameObject CaldoEquipB;
    public GameObject BaronEquipB;
    public GameObject ConsejoOmegaEquipB;
    public GameObject KaironEquipB;
    public GameObject RaxxarEquipB;
    public GameObject RelojAstralEquipB;
    public GameObject tribunalEquipB;
    // Heroes
    public GameObject RelojAstralEquipHeroes;
    public GameObject CaldoEquipHeroes;
    public GameObject AliadosEquipHeroes;

    // Fondos
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Actualizar logos
        UpdateLogoButtons();
        // Actualizar heroes
        UpdateHeroesButtons();
        // Actualizar fondos
        UpdateFondoButtons();
    }
    public void keepDefault()
    {
        // Establecer los valores por defecto
        CDDL.Default = true;
        CDDL.ActivateDefault = true;
        CDDL.DefaultHeroes = true;
        CDDL.ActivateDefaultHeroes = true;
        CDDL.DefaultFondo = true;
        CDDL.ActivateDefaultFondo = true;

        // Desactivar otros valores
        CDDL.ActivateBaron = false;
        CDDL.ActivateConsejoOmega = false;
        CDDL.ActivateKairon = false;
        CDDL.ActivateRaxxar = false;
        CDDL.ActivateRelojAstral = false;
        CDDL.ActivateTribunal = false;

        CDDL.ActivateAliadosHeroes = false;
        CDDL.ActivateBaronHeroes = false;
        CDDL.ActivateRelojAstralHeroes = false;
        CDDL.ActivateKaironHeroes = false;
        CDDL.ActivateRaxxarHeroes = false;
        CDDL.ActivateTribunalHeroes = false;

        CDDL.ActivateConsejoOmegaFondo = false;
        CDDL.ActivateBaronFondo = false;
        CDDL.ActivateKaironFondo = false;
        CDDL.ActivateRaxxarFondo = false;
        CDDL.ActivateRelojAstralFondo = false;
        CDDL.ActivateTribunalFondo = false;
    }
    private void UpdateLogoButtons()
    {
      
        if(BaronEquipB != null)
        {
            BaronEquipB.SetActive(CDDL.ActivateBaron);
        }
        if (CaldoEquipB != null)
        {
            CaldoEquipB.SetActive(CDDL.ActivateDefault);
        }
        if (ConsejoOmegaEquipB != null)
        {
            ConsejoOmegaEquipB.SetActive(CDDL.ActivateConsejoOmega);
        }
        if (KaironEquipB != null)
        {
            KaironEquipB.SetActive(CDDL.ActivateKairon);
        }
        if (RaxxarEquipB != null)
        {
            RaxxarEquipB.SetActive(CDDL.ActivateRaxxar);
        }
        if (RelojAstralEquipB != null)
        {
            RelojAstralEquipB.SetActive(CDDL.ActivateRelojAstral);
        }
        if (tribunalEquipB != null)
        {
            tribunalEquipB.SetActive(CDDL.ActivateTribunal);
        }
    }

    private void UpdateHeroesButtons()
    {
        if (RelojAstralEquipHeroes != null)
        {
            RelojAstralEquipHeroes.SetActive(CDDL.ActivateRelojAstralHeroes);
        }
        if (CaldoEquipHeroes != null)
        {
            CaldoEquipHeroes.SetActive(CDDL.ActivateDefaultHeroes);
        }
    }

    private void UpdateFondoButtons()
    {
        if (BaronEquipFondo != null)
        {
            BaronEquipFondo.SetActive(CDDL.ActivateBaronFondo);
        }
        if (ConsejoOmegaEquipFondo != null)
        {
            ConsejoOmegaEquipFondo.SetActive(CDDL.ActivateConsejoOmegaFondo);
        }
        if (KaironEquipFondo != null)
        {
            KaironEquipFondo.SetActive(CDDL.ActivateKaironFondo);
        }
        if (RaxxarEquipFondo != null)
        {
        RaxxarEquipFondo.SetActive(CDDL.ActivateRaxxarFondo);
        }
        if (RelojAstralEquipFondo != null)
        {
            RelojAstralEquipFondo.SetActive(CDDL.ActivateRelojAstralFondo);
        }
        if (tribunalEquipFondo != null)
        {
            tribunalEquipFondo.SetActive(CDDL.ActivateTribunalFondo);
        }
    }
}
