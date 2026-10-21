using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
    public void vida()
    {
        SceneManager.LoadScene("levelcalculator");
    }

    public void gacha()
    {
        SceneManager.LoadScene("Gacha");
    }

    public void BattleMode()
    {
        SceneManager.LoadScene("Raxxar");
    }

    public void HOME()
    {
        SceneManager.LoadScene("Home");
    }

    public void HEROSELECTOR()
    {
        SceneManager.LoadScene("SelecciónDeHéroe");
    }
    public void SPELLLIST()
    {
        SceneManager.LoadScene("Spellslist");
    }
    public void libros()
    {
        SceneManager.LoadScene("Books");
    }
    public void INDEX()
    {
        SceneManager.LoadScene("INDEX");
    }

    public void habilities()
    {
        SceneManager.LoadScene("Habilities");
    }

    public void gold()
    {
        SceneManager.LoadScene("goldcalc0ulater");
    }

    public void Spells_slots()
    {
        SceneManager.LoadScene("SpellSlots");
    }

    public void GMmode()
    {
        SceneManager.LoadScene("GMMode");
    }

    public void GMmode_Life()
    {
        SceneManager.LoadScene("GMMode_Life");
    }

    public void GMmode_Home()
    {
        SceneManager.LoadScene("GMMode_Home");
    }

    // public void GMmode_gold()
    // {
    //     SceneManager.LoadScene("GMMode_Gold");
    // }

    public void GMmode_map()
    {
        SceneManager.LoadScene("GMMode_Map");
    }
}
