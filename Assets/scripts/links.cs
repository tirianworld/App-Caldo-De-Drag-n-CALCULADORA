using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class links : MonoBehaviour
{
    public LogIn login;
    private void Awake()
    {
        login = GameObject.Find("Usuary").GetComponent<LogIn>();
    }
    public void GuiaBloodHunter()
    {
        Application.OpenURL("https://drive.google.com/file/d/1I86lC1Jb095Xnb_RFnYa4BVVXCJVhlO9/view?usp=sharing");

    }
    public void PersonajesSlots()
    {
        Application.OpenURL("https://www.spellbookdnd.com/es/characters");

    }
    public void HechizosSlots()
    {
        Application.OpenURL("https://www.spellbookdnd.com/es");

    }
    public void HechizosCustomSlots()
    {
        Application.OpenURL("https://www.spellbookdnd.com/es/my-spells");

    }
    public void GuiaPistolero()
    {
        Application.OpenURL("https://drive.google.com/file/d/1zkQYCLCx8GkurY4kmrDgnoF8A3rmloyD/view?usp=sharing");

    }
    public void GuiaParaQuests()
    {
        Application.OpenURL("https://drive.google.com/file/d/1J3au0kHribDGvzx_wfx7ICxFvmrxZJVx/view?usp=sharing");

    }
    public void CaldodeDargonWiki()
    {
        Application.OpenURL("https://caldo-de-dragon.fandom.com/es/wiki/Wiki_Caldo_De_Dragón");

    }
    public void Conjuros()
    {
        Application.OpenURL("https://drive.google.com/file/d/1W6sajCjCYR7BkehXb408AMjjFGSsVbW7/view?usp=sharing");

    }
    public void InventariosGM()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/11B3qYf5GY7-SVkJvB4mxbJOx5CEMiEcu?usp=sharing");
    }
    public void NotasGM()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/14MvQfwQFNHE1MUOl0YSFKKzzKO49dLzi?usp=sharing");
    }
    public void AlbaDoradaNotas()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1hzfzMpS8xJzYE3vLiYiZ4ETRUZRoxq10?usp=sharing");
    }
    public void discord()
    {
        Application.OpenURL("https://discord.com/channels/@me/1102313177389215784");
    }
    public void Inventary()
    {

        if(login.Anibal == true)
        {
            Application.OpenURL("https://drive.google.com/drive/folders/1qR2qeYpQWjrKTQo7cEk7ZintLx6N8zyK?usp=sharing");
        }
        if (login.Pablo == true)
        {
            Application.OpenURL("https://drive.google.com/drive/folders/1BR_r4MRp1JLPUU2mUZaQ5qdbed-8GmB3?usp=sharing");
        }
        if (login.Armando == true)
        {
            Application.OpenURL("https://drive.google.com/drive/folders/1L5S7BJwGMQC5-o7X3aho0uZO9bxBbVfz?usp=sharing");
        }
        if (login.Ruben == true)
        {
            Application.OpenURL("https://drive.google.com/drive/folders/1l40mm3S5uiU5GpTzHRX78X5c0ky5tBo4?usp=sharing");
        }
        if (login.Samuel == true)
        {
            Application.OpenURL("https://drive.google.com/drive/folders/1CXFcADnLvVao0H3P0tzDVftacshqoyEZ?usp=sharing");
        }
        if (login.Chispo == true)
        {
            Application.OpenURL("https://drive.google.com/drive/folders/1pq_yx3i-_ElBuHWgGILSjmfbH3AlawcD?usp=sharing");
        }
        if (login.Jaime == true)
        {
            Application.OpenURL("https://drive.google.com/drive/folders/10L_Jx7IzBWJR3JSJHt9zBcRfURT1UAyE?usp=sharing");
        }
        if (login.Invitado == true)
        {
            Application.OpenURL("https://drive.google.com/drive/folders/1_uJjfgqNlc69ky66-1l5p7mlwp4s9o2A?usp=sharing");
        }

    }
    public void SpellsList()
    {
        if (login.Anibal == true)
        {
            Application.OpenURL("https://drive.google.com/drive/folders/1_zfrq3KHZXZjsWUJlFWx2bAqZfur2BT4?usp=sharing");
        }
        if (login.Pablo == true)
        {
            Application.OpenURL("https://drive.google.com/drive/folders/1KxxUVHBwHRHcMcRJVmJDI57OmBky7F0p?usp=sharing");
        }
        if (login.Armando == true)
        {
            Application.OpenURL("https://rpgbot.net/dnd5/characters/classes/matt-mercers-gunslinger/");
        }
        if (login.Ruben == true)
        {
            Application.OpenURL("https://drive.google.com/drive/folders/1ZuMryRaJW3frarhWSBuA3POIk13HmOzA?usp=sharing");
        }
        if (login.Samuel == true)
        {
            Application.OpenURL("https://rpgbot.net/dnd5/characters/classes/wizard/");
        }
        if (login.Chispo == true)
        {
            Application.OpenURL("https://drive.google.com/drive/folders/1vcqJmYWKo8EL1FQOz-jMjDjyQ8RvZhS2?usp=sharing");

        }
    }
    public void Notas()
    {
        if (login.Anibal == true)
        {
            Application.OpenURL("https://docs.google.com/document/d/1V7wy_coZSNYDXx2522EMpuUubfh00RBuZulwvaB5b9Y/edit?usp=sharing");
        }
        if (login.Pablo == true)
        {
            Application.OpenURL("https://docs.google.com/document/d/1_ipIwb0xPo_bsfniWiXazU1dLNwycHAtN9n_tGxK87g/edit?usp=sharing");
        }
        if (login.Armando == true)
        {
            Application.OpenURL("https://docs.google.com/document/d/12dqx2xDAZ81hcgBRNy1pCcGyVX2vz-Ud-MbIB4Zt0G4/edit?usp=sharing");
        }
        if (login.Ruben == true)
        {
            Application.OpenURL("https://docs.google.com/document/d/1YFnjUyCBnJDWKNAMIrzf752c-pPvPbzJ-PO3Q9K__TM/edit?usp=sharing");
        }
        if (login.Samuel == true)
        {
            Application.OpenURL("https://docs.google.com/document/d/1VTZw43vK--BaZFyaMbyXkxjJjvgDZEl-ghk91bZbktw/edit?usp=sharing");
        }
        if (login.Chispo == true)
        {
            Application.OpenURL("https://docs.google.com/document/d/1RJzZcKUwluoMjtJy_V6CTabXXagvVWXkXqmtovcri-8/edit?usp=sharing");
        }
    }
    public void CharacterSheet()
    {
        if (login.Anibal == true)
        {
            Application.OpenURL("https://docs.google.com/presentation/d/1DuvlbLdzAR0xajoKWUtd292zGkiZ3oURqUQ4WXS-AeE/edit?usp=sharing");
        }
        if (login.Pablo == true)
        {
            Application.OpenURL("https://docs.google.com/presentation/d/1jUvejPZwHmtnnxDw_wRE3yMdbo8oMohMt6QDWo4sC8M/edit?usp=sharing");
        }
        if (login.Armando == true)
        {
            Application.OpenURL("https://docs.google.com/presentation/d/1CM5lsbSKoW9vq-8kQZhpFe0NwHYwHzOBrYIVLiHZBzE/edit?usp=sharing");
        }
        if (login.Ruben == true)
        {
            Application.OpenURL("https://docs.google.com/presentation/d/1W7N8p1QwvNlb_m61FPjzDeBgBzwrRGJ5RXWZwmpdQc0/edit?usp=sharing");
        }
        if (login.Samuel == true)
        {
            Application.OpenURL("https://docs.google.com/presentation/d/1nSYMF4KwNmqrL8I8UnCNhbpY6_kMCC4WI4PyOZWA89k/edit?usp=sharing");
        }
        if (login.Chispo == true)
        {
            Application.OpenURL("https://docs.google.com/presentation/d/1I-ns3DqDNkdHgxhDh4P2J18wQjaClnwVBHTIymhh7zo/edit?usp=sharing");
        }
    }
    public void RaxxarCharacterSheet()
    {
     Application.OpenURL("https://drive.google.com/drive/folders/1qR2qeYpQWjrKTQo7cEk7ZintLx6N8zyK?usp=sharing");
    }
    public void PrometeoCharacterSheet()
    {
     Application.OpenURL("https://docs.google.com/presentation/d/1jUvejPZwHmtnnxDw_wRE3yMdbo8oMohMt6QDWo4sC8M/edit?usp=sharing");
    }
    public void KaironCharacterSheet()
    {
     Application.OpenURL("https://docs.google.com/presentation/d/1CM5lsbSKoW9vq-8kQZhpFe0NwHYwHzOBrYIVLiHZBzE/edit?usp=sharing");
    }
    public void BarlemCharacterSheet()
    {
     Application.OpenURL("https://docs.google.com/presentation/d/1W7N8p1QwvNlb_m61FPjzDeBgBzwrRGJ5RXWZwmpdQc0/edit?usp=sharing");
    }
    public void RagnavaldrCharacterSheet()
    {
     Application.OpenURL("https://docs.google.com/presentation/d/1I-ns3DqDNkdHgxhDh4P2J18wQjaClnwVBHTIymhh7zo/edit?usp=sharing");
    }
    public void AlmaFelasCharacterSheet()
    {
     Application.OpenURL("https://docs.google.com/presentation/d/1nSYMF4KwNmqrL8I8UnCNhbpY6_kMCC4WI4PyOZWA89k/edit?usp=sharing");
    }
    public void RaxxarInventary()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1qR2qeYpQWjrKTQo7cEk7ZintLx6N8zyK?usp=sharing");
    }
    public void PrometeoInventary()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1BR_r4MRp1JLPUU2mUZaQ5qdbed-8GmB3?usp=sharing");
    }
    public void KaironInventary()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1L5S7BJwGMQC5-o7X3aho0uZO9bxBbVfz?usp=sharing");
    }
    public void BarlemInventary()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1l40mm3S5uiU5GpTzHRX78X5c0ky5tBo4?usp=sharing");
    }
    public void RagnavaldrInventary()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1pq_yx3i-_ElBuHWgGILSjmfbH3AlawcD?usp=sharing");
    }
    public void AlmaFelasInventary()
    {
        Application.OpenURL("https://drive.google.com/drive/folders/1CXFcADnLvVao0H3P0tzDVftacshqoyEZ?usp=sharing");
    }


}
