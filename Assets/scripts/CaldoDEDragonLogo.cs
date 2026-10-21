using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaldoDEDragonLogo : MonoBehaviour
{
    // Logos
    public bool ActivateDefault = true;
    public bool Default = true;
    public bool ActivateConsejoOmega;
    public bool ConsejoOmega;
    public bool ActivateBaron;
    public bool Baron;
    public bool ActivateRelojAstral;
    public bool RelojAstral;
    public bool ActivateKairon;
    public bool Kairon;
    public bool ActivateRaxxar;
    public bool Raxxar;
    public bool ActivateTribunal;
    public bool Tribunal;
    // Heroes
    public bool ActivateDefaultHeroes = true;
    public bool DefaultHeroes = true;
    public bool ActivateAliadosHeroes;
    public bool AliadosHeroes;
    public bool ActivateBaronHeroes;
    public bool BaronHeroes;
    public bool ActivateRelojAstralHeroes;
    public bool RelojAstralHeroes;
    public bool ActivateKaironHeroes;
    public bool KaironHeroes;
    public bool ActivateRaxxarHeroes;
    public bool RaxxarHeroes;
    public bool ActivateTribunalHeroes;
    public bool TribunalHeroes;
    // Fondo
    public bool ActivateDefaultFondo = true;
    public bool DefaultFondo = true;
    public bool ActivateConsejoOmegaFondo;
    public bool ConsejoOmegaFondo;
    public bool ActivateBaronFondo;
    public bool BaronFondo;
    public bool ActivateRelojAstralFondo;
    public bool RelojAstralFondo;
    public bool ActivateKaironFondo;
    public bool KaironFondo;
    public bool ActivateRaxxarFondo;
    public bool RaxxarFondo;
    public bool ActivateTribunalFondo;
    public bool TribunalFondo;

    // Claves para logos
    private const string DefaultKey = "CaldoDEDragonLogo_Default";
    private const string ConsejoOmegaKey = "CaldoDEDragonLogo_ConsejoOmega";
    private const string BaronKey = "CaldoDEDragonLogo_Baron";
    private const string RelojAstralKey = "CaldoDEDragonLogo_RelojAstral";
    private const string KaironKey = "CaldoDEDragonLogo_Kairon";
    private const string RaxxarKey = "CaldoDEDragonLogo_Raxxar";
    private const string TribunalKey = "CaldoDEDragonLogo_Tribunal";

    private const string ActivateDefaultKey = "CaldoDEDragonLogo_ActivateDefault";
    private const string ActivateConsejoOmegaKey = "CaldoDEDragonLogo_ActivateConsejoOmega";
    private const string ActivateBaronKey = "CaldoDEDragonLogo_ActivateBaron";
    private const string ActivateRelojAstralKey = "CaldoDEDragonLogo_ActivateRelojAstral";
    private const string ActivateKaironKey = "CaldoDEDragonLogo_ActivateKairon";
    private const string ActivateRaxxarKey = "CaldoDEDragonLogo_ActivateRaxxar";
    private const string ActivateTribunalKey = "CaldoDEDragonLogo_ActivateTribunal";

    // Claves para heroes
    private const string DefaultHeroesKey = "CaldoDEDragonLogo_DefaultHeroes";
    private const string AliadosHeroesKey = "CaldoDEDragonLogo_AliadosHeroes";
    private const string BaronHeroesKey = "CaldoDEDragonLogo_BaronHeroes";
    private const string RelojAstralHeroesKey = "CaldoDEDragonLogo_RelojAstralHeroes";
    private const string KaironHeroesKey = "CaldoDEDragonLogo_KaironHeroes";
    private const string RaxxarHeroesKey = "CaldoDEDragonLogo_RaxxarHeroes";
    private const string TribunalHeroesKey = "CaldoDEDragonLogo_TribunalHeroes";

    private const string ActivateDefaultHeroesKey = "CaldoDEDragonLogo_ActivateDefaultHeroes";
    private const string ActivateAliadosHeroesKey = "CaldoDEDragonLogo_ActivateAliadosHeroes";
    private const string ActivateBaronHeroesKey = "CaldoDEDragonLogo_ActivateBaronHeroes";
    private const string ActivateRelojAstralHeroesKey = "CaldoDEDragonLogo_ActivateRelojAstralHeroes";
    private const string ActivateKaironHeroesKey = "CaldoDEDragonLogo_ActivateKaironHeroes";
    private const string ActivateRaxxarHeroesKey = "CaldoDEDragonLogo_ActivateRaxxarHeroes";
    private const string ActivateTribunalHeroesKey = "CaldoDEDragonLogo_ActivateTribunalHeroes";

    // Claves para fondo
    private const string DefaultFondoKey = "CaldoDEDragonLogo_DefaultFondo";
    private const string ConsejoOmegaFondoKey = "CaldoDEDragonLogo_ConsejoOmegaFondo";
    private const string BaronFondoKey = "CaldoDEDragonLogo_BaronFondo";
    private const string RelojAstralFondoKey = "CaldoDEDragonLogo_RelojAstralFondo";
    private const string KaironFondoKey = "CaldoDEDragonLogo_KaironFondo";
    private const string RaxxarFondoKey = "CaldoDEDragonLogo_RaxxarFondo";
    private const string TribunalFondoKey = "CaldoDEDragonLogo_TribunalFondo";

    private const string ActivateDefaultFondoKey = "CaldoDEDragonLogo_ActivateDefaultFondo";
    private const string ActivateConsejoOmegaFondoKey = "CaldoDEDragonLogo_ActivateConsejoOmegaFondo";
    private const string ActivateBaronFondoKey = "CaldoDEDragonLogo_ActivateBaronFondo";
    private const string ActivateRelojAstralFondoKey = "CaldoDEDragonLogo_ActivateRelojAstralFondo";
    private const string ActivateKaironFondoKey = "CaldoDEDragonLogo_ActivateKaironFondo";
    private const string ActivateRaxxarFondoKey = "CaldoDEDragonLogo_ActivateRaxxarFondo";
    private const string ActivateTribunalFondoKey = "CaldoDEDragonLogo_ActivateTribunalFondo";

    void Awake()
    {
        LoadAll();
        EnsureDefaultActivated();
    }

     void Update()
    {
        SaveAll();
    }
    void OnApplicationQuit()
    {
        SaveAll();
    }

    public void SaveAll()
    {
        // Guardar los valores de logos
        PlayerPrefs.SetInt(DefaultKey, Default ? 1 : 0);
        PlayerPrefs.SetInt(ConsejoOmegaKey, ConsejoOmega ? 1 : 0);
        PlayerPrefs.SetInt(BaronKey, Baron ? 1 : 0);
        PlayerPrefs.SetInt(RelojAstralKey, RelojAstral ? 1 : 0);
        PlayerPrefs.SetInt(KaironKey, Kairon ? 1 : 0);
        PlayerPrefs.SetInt(RaxxarKey, Raxxar ? 1 : 0);
        PlayerPrefs.SetInt(TribunalKey, Tribunal ? 1 : 0);

        PlayerPrefs.SetInt(ActivateDefaultKey, ActivateDefault ? 1 : 0);
        PlayerPrefs.SetInt(ActivateConsejoOmegaKey, ActivateConsejoOmega ? 1 : 0);
        PlayerPrefs.SetInt(ActivateBaronKey, ActivateBaron ? 1 : 0);
        PlayerPrefs.SetInt(ActivateRelojAstralKey, ActivateRelojAstral ? 1 : 0);
        PlayerPrefs.SetInt(ActivateKaironKey, ActivateKairon ? 1 : 0);
        PlayerPrefs.SetInt(ActivateRaxxarKey, ActivateRaxxar ? 1 : 0);
        PlayerPrefs.SetInt(ActivateTribunalKey, ActivateTribunal ? 1 : 0);

        // Guardar los valores de heroes
        PlayerPrefs.SetInt(DefaultHeroesKey, DefaultHeroes ? 1 : 0);
        PlayerPrefs.SetInt(AliadosHeroesKey, AliadosHeroes ? 1 : 0);
        PlayerPrefs.SetInt(BaronHeroesKey, BaronHeroes ? 1 : 0);
        PlayerPrefs.SetInt(RelojAstralHeroesKey, RelojAstralHeroes ? 1 : 0);
        PlayerPrefs.SetInt(KaironHeroesKey, KaironHeroes ? 1 : 0);
        PlayerPrefs.SetInt(RaxxarHeroesKey, RaxxarHeroes ? 1 : 0);
        PlayerPrefs.SetInt(TribunalHeroesKey, TribunalHeroes ? 1 : 0);

        PlayerPrefs.SetInt(ActivateDefaultHeroesKey, ActivateDefaultHeroes ? 1 : 0);
        PlayerPrefs.SetInt(ActivateAliadosHeroesKey, ActivateAliadosHeroes ? 1 : 0);
        PlayerPrefs.SetInt(ActivateBaronHeroesKey, ActivateBaronHeroes ? 1 : 0);
        PlayerPrefs.SetInt(ActivateRelojAstralHeroesKey, ActivateRelojAstralHeroes ? 1 : 0);
        PlayerPrefs.SetInt(ActivateKaironHeroesKey, ActivateKaironHeroes ? 1 : 0);
        PlayerPrefs.SetInt(ActivateRaxxarHeroesKey, ActivateRaxxarHeroes ? 1 : 0);
        PlayerPrefs.SetInt(ActivateTribunalHeroesKey, ActivateTribunalHeroes ? 1 : 0);

        // Guardar los valores de fondo
        PlayerPrefs.SetInt(DefaultFondoKey, DefaultFondo ? 1 : 0);
        PlayerPrefs.SetInt(ConsejoOmegaFondoKey, ConsejoOmegaFondo ? 1 : 0);
        PlayerPrefs.SetInt(BaronFondoKey, BaronFondo ? 1 : 0);
        PlayerPrefs.SetInt(RelojAstralFondoKey, RelojAstralFondo ? 1 : 0);
        PlayerPrefs.SetInt(KaironFondoKey, KaironFondo ? 1 : 0);
        PlayerPrefs.SetInt(RaxxarFondoKey, RaxxarFondo ? 1 : 0);
        PlayerPrefs.SetInt(TribunalFondoKey, TribunalFondo ? 1 : 0);

        PlayerPrefs.SetInt(ActivateDefaultFondoKey, ActivateDefaultFondo ? 1 : 0);
        PlayerPrefs.SetInt(ActivateConsejoOmegaFondoKey, ActivateConsejoOmegaFondo ? 1 : 0);
        PlayerPrefs.SetInt(ActivateBaronFondoKey, ActivateBaronFondo ? 1 : 0);
        PlayerPrefs.SetInt(ActivateRelojAstralFondoKey, ActivateRelojAstralFondo ? 1 : 0);
        PlayerPrefs.SetInt(ActivateKaironFondoKey, ActivateKaironFondo ? 1 : 0);
        PlayerPrefs.SetInt(ActivateRaxxarFondoKey, ActivateRaxxarFondo ? 1 : 0);
        PlayerPrefs.SetInt(ActivateTribunalFondoKey, ActivateTribunalFondo ? 1 : 0);
    }

    public void LoadAll()
    {
        // Cargar los valores de logos
        Default = PlayerPrefs.GetInt(DefaultKey, Default ? 1 : 0) == 1;
        ConsejoOmega = PlayerPrefs.GetInt(ConsejoOmegaKey, ConsejoOmega ? 1 : 0) == 1;
        Baron = PlayerPrefs.GetInt(BaronKey, Baron ? 1 : 0) == 1;
        RelojAstral = PlayerPrefs.GetInt(RelojAstralKey, RelojAstral ? 1 : 0) == 1;
        Kairon = PlayerPrefs.GetInt(KaironKey, Kairon ? 1 : 0) == 1;
        Raxxar = PlayerPrefs.GetInt(RaxxarKey, Raxxar ? 1 : 0) == 1;
        Tribunal = PlayerPrefs.GetInt(TribunalKey, Tribunal ? 1 : 0) == 1;

        ActivateDefault = PlayerPrefs.GetInt(ActivateDefaultKey, ActivateDefault ? 1 : 0) == 1;
        ActivateConsejoOmega = PlayerPrefs.GetInt(ActivateConsejoOmegaKey, ActivateConsejoOmega ? 1 : 0) == 1;
        ActivateBaron = PlayerPrefs.GetInt(ActivateBaronKey, ActivateBaron ? 1 : 0) == 1;
        ActivateRelojAstral = PlayerPrefs.GetInt(ActivateRelojAstralKey, ActivateRelojAstral ? 1 : 0) == 1;
        ActivateKairon = PlayerPrefs.GetInt(ActivateKaironKey, ActivateKairon ? 1 : 0) == 1;
        ActivateRaxxar = PlayerPrefs.GetInt(ActivateRaxxarKey, ActivateRaxxar ? 1 : 0) == 1;
        ActivateTribunal = PlayerPrefs.GetInt(ActivateTribunalKey, ActivateTribunal ? 1 : 0) == 1;

        // Cargar los valores de heroes
        DefaultHeroes = PlayerPrefs.GetInt(DefaultHeroesKey, DefaultHeroes ? 1 : 0) == 1;
        AliadosHeroes = PlayerPrefs.GetInt(AliadosHeroesKey, AliadosHeroes ? 1 : 0) == 1;
        BaronHeroes = PlayerPrefs.GetInt(BaronHeroesKey, BaronHeroes ? 1 : 0) == 1;
        RelojAstralHeroes = PlayerPrefs.GetInt(RelojAstralHeroesKey, RelojAstralHeroes ? 1 : 0) == 1;
        KaironHeroes = PlayerPrefs.GetInt(KaironHeroesKey, KaironHeroes ? 1 : 0) == 1;
        RaxxarHeroes = PlayerPrefs.GetInt(RaxxarHeroesKey, RaxxarHeroes ? 1 : 0) == 1;
        TribunalHeroes = PlayerPrefs.GetInt(TribunalHeroesKey, TribunalHeroes ? 1 : 0) == 1;

        ActivateDefaultHeroes = PlayerPrefs.GetInt(ActivateDefaultHeroesKey, ActivateDefaultHeroes ? 1 : 0) == 1;
        ActivateAliadosHeroes = PlayerPrefs.GetInt(ActivateAliadosHeroesKey, ActivateAliadosHeroes ? 1 : 0) == 1;
        ActivateBaronHeroes = PlayerPrefs.GetInt(ActivateBaronHeroesKey, ActivateBaronHeroes ? 1 : 0) == 1;
        ActivateRelojAstralHeroes = PlayerPrefs.GetInt(ActivateRelojAstralHeroesKey, ActivateRelojAstralHeroes ? 1 : 0) == 1;
        ActivateKaironHeroes = PlayerPrefs.GetInt(ActivateKaironHeroesKey, ActivateKaironHeroes ? 1 : 0) == 1;
        ActivateRaxxarHeroes = PlayerPrefs.GetInt(ActivateRaxxarHeroesKey, ActivateRaxxarHeroes ? 1 : 0) == 1;
        ActivateTribunalHeroes = PlayerPrefs.GetInt(ActivateTribunalHeroesKey, ActivateTribunalHeroes ? 1 : 0) == 1;

        // Cargar los valores de fondo
        DefaultFondo = PlayerPrefs.GetInt(DefaultFondoKey, DefaultFondo ? 1 : 0) == 1;
        ConsejoOmegaFondo = PlayerPrefs.GetInt(ConsejoOmegaFondoKey, ConsejoOmegaFondo ? 1 : 0) == 1;
        BaronFondo = PlayerPrefs.GetInt(BaronFondoKey, BaronFondo ? 1 : 0) == 1;
        RelojAstralFondo = PlayerPrefs.GetInt(RelojAstralFondoKey, RelojAstralFondo ? 1 : 0) == 1;
        KaironFondo = PlayerPrefs.GetInt(KaironFondoKey, KaironFondo ? 1 : 0) == 1;
        RaxxarFondo = PlayerPrefs.GetInt(RaxxarFondoKey, RaxxarFondo ? 1 : 0) == 1;
        TribunalFondo = PlayerPrefs.GetInt(TribunalFondoKey, TribunalFondo ? 1 : 0) == 1;

        ActivateDefaultFondo = PlayerPrefs.GetInt(ActivateDefaultFondoKey, ActivateDefaultFondo ? 1 : 0) == 1;
        ActivateConsejoOmegaFondo = PlayerPrefs.GetInt(ActivateConsejoOmegaFondoKey, ActivateConsejoOmegaFondo ? 1 : 0) == 1;
        ActivateBaronFondo = PlayerPrefs.GetInt(ActivateBaronFondoKey, ActivateBaronFondo ? 1 : 0) == 1;
        ActivateRelojAstralFondo = PlayerPrefs.GetInt(ActivateRelojAstralFondoKey, ActivateRelojAstralFondo ? 1 : 0) == 1;
        ActivateKaironFondo = PlayerPrefs.GetInt(ActivateKaironFondoKey, ActivateKaironFondo ? 1 : 0) == 1;
        ActivateRaxxarFondo = PlayerPrefs.GetInt(ActivateRaxxarFondoKey, ActivateRaxxarFondo ? 1 : 0) == 1;
        ActivateTribunalFondo = PlayerPrefs.GetInt(ActivateTribunalFondoKey, ActivateTribunalFondo ? 1 : 0) == 1;

        // Asegúrate de que Default esté activado si ninguno de los demás está activado
        EnsureDefaultActivated();
    }
    public void EnsureDefaultActivated()
    {
        // Verifica si todos los valores 'Activate' de logos son falsos
        bool noActivatedLogosTrue = !ActivateConsejoOmega && !ActivateBaron && !ActivateRelojAstral &&
                                    !ActivateKairon && !ActivateRaxxar && !ActivateTribunal;

        // Verifica si todos los valores 'Activate' de héroes son falsos
        bool noActivatedHeroesTrue = !ActivateAliadosHeroes && !ActivateBaronHeroes && !ActivateRelojAstralHeroes &&
                                     !ActivateKaironHeroes && !ActivateRaxxarHeroes && !ActivateTribunalHeroes;

        // Verifica si todos los valores 'Activate' de fondo son falsos
        bool noActivatedFondoTrue = !ActivateConsejoOmegaFondo && !ActivateBaronFondo && !ActivateRelojAstralFondo &&
                                    !ActivateKaironFondo && !ActivateRaxxarFondo && !ActivateTribunalFondo;

        // Si todos los valores 'Activate' de logos son falsos, activa los valores por defecto de logos
        if (noActivatedLogosTrue)
        {
            ActivateDefault = true;
            Default = true;
        }

        // Si todos los valores 'Activate' de héroes son falsos, activa los valores por defecto de héroes
        if (noActivatedHeroesTrue)
        {
            ActivateDefaultHeroes = true;
            DefaultHeroes = true;
        }

        // Si todos los valores 'Activate' de fondo son falsos, activa los valores por defecto de fondo
        if (noActivatedFondoTrue)
        {
            ActivateDefaultFondo = true;
            DefaultFondo = true;
        }
    }


}

