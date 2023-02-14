using Kryz.CharacterStats;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int age, money;
    public CharacterStat health, hungry, cold, mentalHealth, bodyHealth;

    private void Start()
    {
        money = 0;
        age = 18;
        health.BaseValue = (float)Random.RandomRange(5, 100);
        hungry.BaseValue = (float)Random.RandomRange(0, 100);
        cold.BaseValue = (float)Random.RandomRange(0, 50);
        mentalHealth.BaseValue = 50f;
        bodyHealth.BaseValue = 68f;
    }
}
