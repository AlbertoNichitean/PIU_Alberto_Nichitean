using System;

namespace ModeleAuto
{
    // Cerinta: Culoare - de tip enumerare (Rosu, Alb, Negru)
    public enum CuloareMasina
    {
        Rosu = 1,
        Alb = 2,
        Negru = 3
    }

    // Cerinta: Opţiuni - enumerare cu atributul Flag [Flags]
    [Flags]
    public enum OptiuniMasina
    {
        None = 0,
        AerConditionat = 1,
        Navigatie = 2,
        CutieAutomata = 4,
        SenzoriParcare = 8
    }
}