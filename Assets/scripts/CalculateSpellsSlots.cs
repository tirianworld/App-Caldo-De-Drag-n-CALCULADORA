using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class CalculateSpellsSlots : MonoBehaviour
{
    public TMP_Dropdown claseDropdown;
    public TMP_InputField nivelInput;
    public TMP_InputField ExtraSlots;
    public Image nv1;
    public Image nv2;
    public Image nv3;
    public Image nv4;
    public Image nv5;
    public Image nv6;
    public Image nv7;
    public Image nv8;
    public Image nv9;
    public TextMeshProUGUI resultadoTMP;

    public struct ClaseSpellSlots
    {
        public string nombre;
        public int[,] spellSlots; // Rows for levels, columns for spell slot levels
    }

    public ClaseSpellSlots[] clases;

    private void Start()
    {
        clases = new ClaseSpellSlots[]
        {
            new ClaseSpellSlots { nombre = "Barbaro", spellSlots = new int[,] {
                 { 2, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 1
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 2
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 3
                { 4, 3, 0, 0, 0, 0, 0, 0, 0 }, // Level 4
                { 4, 3, 2, 0, 0, 0, 0, 0, 0 }, // Level 5
                { 4, 3, 3, 0, 0, 0, 0, 0, 0 }, // Level 6
                { 4, 3, 3, 1, 0, 0, 0, 0, 0 }, // Level 7
                { 4, 3, 3, 2, 0, 0, 0, 0, 0 }, // Level 8
                { 4, 3, 3, 3, 1, 0, 0, 0, 0 }, // Level 9
                { 4, 3, 3, 3, 2, 0, 0, 0, 0 }, // Level 10
                { 4, 3, 3, 3, 2, 1, 0, 0, 0 }, // Level 11
                { 4, 3, 3, 3, 2, 1, 0, 0, 0 }, // Level 12
                { 4, 3, 3, 3, 2, 1, 1, 0, 0 }, // Level 13
                { 4, 3, 3, 3, 2, 1, 1, 0, 0 }, // Level 14
                { 4, 3, 3, 3, 2, 1, 1, 1, 0 }, // Level 15
                { 4, 3, 3, 3, 2, 1, 1, 1, 0 }, // Level 16
                { 4, 3, 3, 3, 2, 1, 1, 1, 1 }, // Level 17
                { 4, 3, 3, 3, 3, 1, 1, 1, 1 }, // Level 18
                { 4, 3, 3, 3, 3, 1, 1, 1, 1 }, // Level 19
                 { 4, 3, 3, 3, 3, 2, 2, 1, 1 }, // Level 20
                // ... continue for each level up to 20
            }},
            new ClaseSpellSlots { nombre = "Bardo", spellSlots = new int[,] {
                 { 2, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 1
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 2
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 3
                { 4, 3, 0, 0, 0, 0, 0, 0, 0 }, // Level 4
                { 4, 3, 2, 0, 0, 0, 0, 0, 0 }, // Level 5
                { 4, 3, 3, 0, 0, 0, 0, 0, 0 }, // Level 6
                { 4, 3, 3, 1, 0, 0, 0, 0, 0 }, // Level 7
                { 4, 3, 3, 2, 0, 0, 0, 0, 0 }, // Level 8
                { 4, 3, 3, 3, 1, 0, 0, 0, 0 }, // Level 9
                { 4, 3, 3, 3, 2, 0, 0, 0, 0 }, // Level 10
                { 4, 3, 3, 3, 2, 1, 0, 0, 0 }, // Level 11
                { 4, 3, 3, 3, 2, 1, 0, 0, 0 }, // Level 12
                { 4, 3, 3, 3, 2, 1, 1, 0, 0 }, // Level 13
                { 4, 3, 3, 3, 2, 1, 1, 0, 0 }, // Level 14
                { 4, 3, 3, 3, 2, 1, 1, 1, 0 }, // Level 15
                { 4, 3, 3, 3, 2, 1, 1, 1, 0 }, // Level 16
                { 4, 3, 3, 3, 2, 1, 1, 1, 1 }, // Level 17
                { 4, 3, 3, 3, 3, 1, 1, 1, 1 }, // Level 18
                { 4, 3, 3, 3, 3, 1, 1, 1, 1 }, // Level 19
                 { 4, 3, 3, 3, 3, 2, 2, 1, 1 }, // Level 20
                // ... continue for each level up to 20
            }},
             new ClaseSpellSlots { nombre = "Brujo", spellSlots = new int[,] {
                { 1, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 1
                { 2, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 2
                { 0, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 3
                { 0, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 4
                { 0, 0, 2, 0, 0, 0, 0, 0, 0 }, // Level 5
                { 0, 0, 2, 0, 0, 0, 0, 0, 0 }, // Level 6
                { 0, 0, 0, 2, 0, 0, 0, 0, 0 }, // Level 7
                { 0, 0, 0, 2, 0, 0, 0, 0, 0 }, // Level 8
                { 0, 0, 0, 0, 2, 0, 0, 0, 0 }, // Level 9
                { 0, 0, 0, 0, 2, 0, 0, 0, 0 }, // Level 10
                { 0, 0, 0, 0, 3, 0, 0, 0, 0 }, // Level 11
                { 0, 0, 0, 0, 3, 0, 0, 0, 0 }, // Level 12
                { 0, 0, 0, 0, 3, 0, 0, 0, 0 }, // Level 13
                { 0, 0, 0, 0, 3, 0, 0, 0, 0 }, // Level 14
                { 4, 2, 0, 0, 3, 0, 0, 0, 0 }, // Level 15
                { 4, 2, 0, 0, 3, 0, 0, 0, 0 }, // Level 16
                { 4, 2, 0, 0, 4, 0, 0, 0, 0 }, // Level 17
                { 4, 2, 0, 0, 4, 0, 0, 0, 0 }, // Level 18
                { 4, 2, 0, 0, 4, 0, 0, 0, 0 }, // Level 19
                { 4, 2, 0, 0, 4, 0, 0, 0, 0 }, // Level 20
                // ... continue for each level up to 20
            }},
             new ClaseSpellSlots { nombre = "Clérigo", spellSlots = new int[,] {
                { 2, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 1
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 2
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 3
                { 4, 3, 0, 0, 0, 0, 0, 0, 0 }, // Level 4
                { 4, 3, 2, 0, 0, 0, 0, 0, 0 }, // Level 5
                { 4, 3, 3, 0, 0, 0, 0, 0, 0 }, // Level 6
                { 4, 3, 3, 1, 0, 0, 0, 0, 0 }, // Level 7
                { 4, 3, 3, 2, 0, 0, 0, 0, 0 }, // Level 8
                { 4, 3, 3, 3, 1, 0, 0, 0, 0 }, // Level 9
                { 4, 3, 3, 3, 2, 0, 0, 0, 0 }, // Level 10
                { 4, 3, 3, 3, 2, 1, 0, 0, 0 }, // Level 11
                { 4, 3, 3, 3, 2, 1, 0, 0, 0 },
                { 4, 3, 3, 3, 2, 1, 1, 0, 0 }, // Level 13
                { 4, 3, 3, 3, 2, 1, 1, 0, 0 }, // Level 14
                { 4, 3, 3, 3, 2, 1, 1, 1, 0 }, // Level 15
                { 4, 3, 3, 3, 2, 1, 1, 1, 0 }, // Level 16
                { 4, 3, 3, 3, 2, 1, 1, 1, 1 }, // Level 17
                { 4, 3, 3, 3, 3, 1, 1, 1, 1 }, // Level 18
                { 4, 3, 3, 3, 3, 2, 1, 1, 1 }, // Level 19
                { 4, 3, 3, 3, 3, 2, 1, 1, 1 }, // Level 20
                // ... continue for each level up to 20
            }},
             new ClaseSpellSlots { nombre = "Druida", spellSlots = new int[,] {
                { 2, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 1
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 2
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 3
                { 4, 3, 0, 0, 0, 0, 0, 0, 0 }, // Level 4
                { 4, 3, 2, 0, 0, 0, 0, 0, 0 }, // Level 5
                { 4, 3, 3, 0, 0, 0, 0, 0, 0 }, // Level 6
                { 4, 3, 3, 1, 0, 0, 0, 0, 0 }, // Level 7
                { 4, 3, 3, 2, 0, 0, 0, 0, 0 }, // Level 8
                { 4, 3, 3, 3, 1, 0, 0, 0, 0 }, // Level 9
                { 4, 3, 3, 3, 2, 0, 0, 0, 0 }, // Level 10
                { 4, 3, 3, 3, 2, 1, 0, 0, 0 }, // Level 11
                { 4, 3, 3, 3, 2, 1, 0, 0, 0 }, // Level 12
                { 4, 3, 3, 3, 2, 1, 1, 0, 0 }, // Level 13
                { 4, 3, 3, 3, 2, 1, 1, 0, 0 }, // Level 14
                { 4, 3, 3, 3, 2, 1, 1, 1, 0 }, // Level 15
                { 4, 3, 3, 3, 2, 1, 1, 1, 0 }, // Level 16
                { 4, 3, 3, 3, 2, 1, 1, 1, 1 }, // Level 17
                { 4, 3, 3, 3, 3, 1, 1, 1, 1 }, // Level 18
                { 4, 3, 3, 3, 3, 2, 1, 1, 1 }, // Level 19
                { 4, 3, 3, 3, 3, 2, 2, 1, 1 }, // Level 20
                // ... continue for each level up to 20
            }},
             new ClaseSpellSlots { nombre = "Explorador", spellSlots = new int[,] {
                { 2, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 1
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 2
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 3
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 4
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 5
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 6
                { 4, 3, 0, 0, 0, 0, 0, 0, 0 }, // Level 7
                { 4, 3, 0, 0, 0, 0, 0, 0, 0 }, // Level 8
                { 4, 3, 2, 0, 0, 0, 0, 0, 0 }, // Level 9
                { 4, 3, 2, 0, 0, 0, 0, 0, 0 }, // Level 10
                { 4, 3, 3, 0, 0, 0, 0, 0, 0 }, // Level 11
                { 4, 3, 3, 0, 0, 0, 0, 0, 0 }, // Level 12
                { 4, 3, 3, 1, 0, 0, 0, 0, 0 }, // Level 13
                { 4, 3, 3, 1, 0, 0, 0, 0, 0 }, // Level 14
                { 4, 3, 3, 2, 0, 0, 0, 0, 0 }, // Level 15
                { 4, 3, 3, 2, 0, 0, 0, 0, 0 }, // Level 16
                { 4, 3, 3, 3, 1, 0, 0, 0, 0 }, // Level 17
                { 4, 3, 3, 3, 1, 0, 0, 0, 0 }, // Level 18
                { 4, 3, 3, 3, 2, 0, 0, 0, 0 }, // Level 19
                { 4, 3, 3, 3, 2, 0, 0, 0, 0 }, // Level 20
                // ... continue for each level up to 20
            }},
             new ClaseSpellSlots { nombre = "Guerrero", spellSlots = new int[,] {
                { 2, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 1
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 2
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 3
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 4
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 5
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 6
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 7
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 8
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 9
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 10
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 11
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 12
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 13
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 14
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 15
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 16
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 17
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 18
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 19
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 20
                // ... continue for each level up to 20
            }},
             new ClaseSpellSlots { nombre = "Hechicero", spellSlots = new int[,] {
                 { 2, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 1
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 2
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 3
                { 4, 3, 0, 0, 0, 0, 0, 0, 0 }, // Level 4
                { 4, 3, 2, 0, 0, 0, 0, 0, 0 }, // Level 5
                { 4, 3, 3, 0, 0, 0, 0, 0, 0 }, // Level 6
                { 4, 3, 3, 1, 0, 0, 0, 0, 0 }, // Level 7
                { 4, 3, 3, 2, 0, 0, 0, 0, 0 }, // Level 8
                { 4, 3, 3, 3, 1, 0, 0, 0, 0 }, // Level 9
                { 4, 3, 3, 3, 2, 0, 0, 0, 0 }, // Level 10
                { 4, 3, 3, 3, 2, 1, 0, 0, 0 }, // Level 11
                { 4, 3, 3, 3, 2, 1, 0, 0, 0 }, // Level 12
                { 4, 3, 3, 3, 2, 1, 1, 0, 0 }, // Level 13
                { 4, 3, 3, 3, 2, 1, 1, 0, 0 }, // Level 14
                { 4, 3, 3, 3, 2, 1, 1, 1, 0 }, // Level 15
                { 4, 3, 3, 3, 2, 1, 1, 1, 0 }, // Level 16
                { 4, 3, 3, 3, 2, 1, 1, 1, 1 }, // Level 17
                { 4, 3, 3, 3, 3, 1, 1, 1, 1 }, // Level 18
                { 4, 3, 3, 3, 3, 2, 1, 1, 1 }, // Level 19
                { 4, 3, 3, 3, 3, 2, 2, 1, 1 }, // Level 20
                // ... continue for each level up to 20
            }},
            new ClaseSpellSlots { nombre = "Mago", spellSlots = new int[,] {
                 { 2, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 1
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 2
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 3
                { 4, 3, 0, 0, 0, 0, 0, 0, 0 }, // Level 4
                { 4, 3, 2, 0, 0, 0, 0, 0, 0 }, // Level 5
                { 4, 3, 3, 0, 0, 0, 0, 0, 0 }, // Level 6
                { 4, 3, 3, 1, 0, 0, 0, 0, 0 }, // Level 7
                { 4, 3, 3, 2, 0, 0, 0, 0, 0 }, // Level 8
                { 4, 3, 3, 3, 1, 0, 0, 0, 0 }, // Level 9
                { 4, 3, 3, 3, 2, 0, 0, 0, 0 }, // Level 10
                { 4, 3, 3, 3, 2, 1, 0, 0, 0 }, // Level 11
                { 4, 3, 3, 3, 2, 1, 0, 0, 0 }, // Level 12
                { 4, 3, 3, 3, 2, 1, 1, 0, 0 }, // Level 13
                { 4, 3, 3, 3, 2, 1, 1, 0, 0 }, // Level 14
                { 4, 3, 3, 3, 2, 1, 1, 1, 0 }, // Level 15
                { 4, 3, 3, 3, 2, 1, 1, 1, 0 }, // Level 16
                { 4, 3, 3, 3, 2, 1, 1, 1, 1 }, // Level 17
                { 4, 3, 3, 3, 3, 1, 1, 1, 1 }, // Level 18
                { 4, 3, 3, 3, 3, 2, 1, 1, 1 }, // Level 19
                { 4, 3, 3, 3, 3, 2, 2, 1, 1 }, // Level 20
                // ... continue for each level up to 20
            }},
            new ClaseSpellSlots { nombre = "Monje", spellSlots = new int[,] {
                { 2, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 1
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 2
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 3
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 4
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 5
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 6
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 7
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 8
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 9
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 10
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 11
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 12
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 13
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 14
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 15
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 16
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 17
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 18
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 19
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 20
                // ... continue for each level up to 20
            }},
            new ClaseSpellSlots { nombre = "Paladín", spellSlots = new int[,] {
               { 2, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 1
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 2
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 3
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 4
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 5
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 6
                { 4, 3, 0, 0, 0, 0, 0, 0, 0 }, // Level 7
                { 4, 3, 0, 0, 0, 0, 0, 0, 0 }, // Level 8
                { 4, 3, 2, 0, 0, 0, 0, 0, 0 }, // Level 9
                { 4, 3, 2, 0, 0, 0, 0, 0, 0 }, // Level 10
                { 4, 3, 3, 0, 0, 0, 0, 0, 0 }, // Level 11
                { 4, 3, 3, 0, 0, 0, 0, 0, 0 }, // Level 12
                { 4, 3, 3, 1, 0, 0, 0, 0, 0 }, // Level 13
                { 4, 3, 3, 1, 0, 0, 0, 0, 0 }, // Level 14
                { 4, 3, 3, 2, 0, 0, 0, 0, 0 }, // Level 15
                { 4, 3, 3, 2, 0, 0, 0, 0, 0 }, // Level 16
                { 4, 3, 3, 3, 1, 0, 0, 0, 0 }, // Level 17
                { 4, 3, 3, 3, 1, 0, 0, 0, 0 }, // Level 18
                { 4, 3, 3, 3, 2, 0, 0, 0, 0 }, // Level 19
                { 4, 3, 3, 3, 2, 0, 0, 0, 0 }, // Level 20
                // ... continue for each level up to 20
            }},
 new ClaseSpellSlots { nombre = "Pícaro", spellSlots = new int[,] {
                { 2, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 1
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 2
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 3
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 4
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 5
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 6
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 7
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 8
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 9
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 10
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 11
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 12
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 13
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 14
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 15
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 16
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 17
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 18
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 19
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 20
                // ... continue for each level up to 20
            }},
             new ClaseSpellSlots { nombre = "Bloodhunter", spellSlots = new int[,] {
                { 2, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 1
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 2
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 3
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 4
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 5
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 6
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 7
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 8
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 9
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 10
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 11
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 12
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 13
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 14
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 15
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 16
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 17
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 18
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 19
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 20
                // ... continue for each level up to 20
            }},
             new ClaseSpellSlots { nombre = "Shaman", spellSlots = new int[,] {
                { 2, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 1
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 2
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 3
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 4
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 5
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 6
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 7
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 8
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 9
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 10
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 11
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 12
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 13
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 14
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 15
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 16
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 17
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 18
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 19
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 20
                // ... continue for each level up to 20
            }},
 new ClaseSpellSlots { nombre = "Blackguard", spellSlots = new int[,] {
                { 2, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 1
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 2
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 3
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 4
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 5
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 6
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 7
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 8
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 9
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 10
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 11
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 12
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 13
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 14
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 15
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 16
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 17
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 18
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 19
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 20
                // ... continue for each level up to 20
            }},
             new ClaseSpellSlots { nombre = "Artificiero", spellSlots = new int[,] {
                { 2, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 1
                { 3, 0, 0, 0, 0, 0, 0, 0, 0 }, // Level 2
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 3
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 4
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 5
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 6
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 7
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 8
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 9
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 10
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 11
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 12
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 13
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 14
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 15
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 16
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 17
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 18
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 19
                { 4, 2, 0, 0, 0, 0, 0, 0, 0 }, // Level 20
                // ... continue for each level up to 20
            }},
            // Add other classes here...
            };

        foreach (var clase in clases)
        {
            claseDropdown.options.Add(new TMP_Dropdown.OptionData(clase.nombre));
        }
    }

    public void CalcularSpellSlots()
    {
        int nivel;
        if (!int.TryParse(nivelInput.text, out nivel) || nivel < 1 || nivel > 20)
        {
            resultadoTMP.text = "Ingresa un nivel válido (1-20).";
            return;
        }

        int claseIndex = claseDropdown.value;
        if (claseIndex < 0 || claseIndex >= clases.Length)
        {
            resultadoTMP.text = "Selecciona una clase válida.";
            return;
        }

        var slots = clases[claseIndex].spellSlots;

        StartCoroutine(UpdateFillAmountSmoothly(slots, nivel));
    }

    private IEnumerator UpdateFillAmountSmoothly(int[,] slots, int nivel)
    {
        float duration = 0.5f; // Duración de la animación en segundos
        float elapsedTime = 0f;

        float[] targetFillAmounts = new float[9];
        for (int i = 0; i < 9; i++)
        {
            targetFillAmounts[i] = slots[nivel - 1, i] * 0.125f;
        }

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;

            nv1.fillAmount = Mathf.Lerp(nv1.fillAmount, targetFillAmounts[0], elapsedTime / duration);
            nv2.fillAmount = Mathf.Lerp(nv2.fillAmount, targetFillAmounts[1], elapsedTime / duration);
            nv3.fillAmount = Mathf.Lerp(nv3.fillAmount, targetFillAmounts[2], elapsedTime / duration);
            nv4.fillAmount = Mathf.Lerp(nv4.fillAmount, targetFillAmounts[3], elapsedTime / duration);
            nv5.fillAmount = Mathf.Lerp(nv5.fillAmount, targetFillAmounts[4], elapsedTime / duration);
            nv6.fillAmount = Mathf.Lerp(nv6.fillAmount, targetFillAmounts[5], elapsedTime / duration);
            nv7.fillAmount = Mathf.Lerp(nv7.fillAmount, targetFillAmounts[6], elapsedTime / duration);
            nv8.fillAmount = Mathf.Lerp(nv8.fillAmount, targetFillAmounts[7], elapsedTime / duration);
            nv9.fillAmount = Mathf.Lerp(nv9.fillAmount, targetFillAmounts[8], elapsedTime / duration);

            yield return null; // Espera un frame antes de continuar la interpolación
        }

        // Asegurarse de que las barras lleguen exactamente al valor final
        nv1.fillAmount = targetFillAmounts[0];
        nv2.fillAmount = targetFillAmounts[1];
        nv3.fillAmount = targetFillAmounts[2];
        nv4.fillAmount = targetFillAmounts[3];
        nv5.fillAmount = targetFillAmounts[4];
        nv6.fillAmount = targetFillAmounts[5];
        nv7.fillAmount = targetFillAmounts[6];
        nv8.fillAmount = targetFillAmounts[7];
        nv9.fillAmount = targetFillAmounts[8];
    }
    public void SumarExtraSlots()
    {
        int extraSlotsValue;
        if (!int.TryParse(ExtraSlots.text, out extraSlotsValue) || extraSlotsValue < 0)
        {
            resultadoTMP.text = "Ingresa un valor válido para Espacios Extra.";
            return;
        }

        int nivel;
        if (!int.TryParse(nivelInput.text, out nivel) || nivel < 1 || nivel > 20)
        {
            resultadoTMP.text = "Ingresa un nivel válido (1-20).";
            return;
        }

        int claseIndex = claseDropdown.value;
        if (claseIndex < 0 || claseIndex >= clases.Length)
        {
            resultadoTMP.text = "Selecciona una clase válida.";
            return;
        }

        var slots = clases[claseIndex].spellSlots;

        nv1.fillAmount =(slots[nivel - 1, 0] + extraSlotsValue);
        nv2.fillAmount = (slots[nivel - 1, 1] + extraSlotsValue);
        nv3.fillAmount = (slots[nivel - 1, 2] + extraSlotsValue);
        nv4.fillAmount = (slots[nivel - 1, 3] + extraSlotsValue);
        nv5.fillAmount = (slots[nivel - 1, 4] + extraSlotsValue);
        nv6.fillAmount = (slots[nivel - 1, 5] + extraSlotsValue);
        nv7.fillAmount = (slots[nivel - 1, 6] + extraSlotsValue);
        nv8.fillAmount = (slots[nivel - 1, 7] + extraSlotsValue);
        nv9.fillAmount = (slots[nivel - 1, 8] + extraSlotsValue);
    }
}
