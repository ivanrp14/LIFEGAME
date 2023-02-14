using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;

public class DisplayText : MonoBehaviour
{
    // Referencia al componente TextMeshPro
    

    // Referencia al componente PlayerStats
    public PlayerStats playerStats;
    public TextMeshProUGUI textMesh;
    public bool displayAge, displayMoney, displayHealth, displayHungry, displayCold, displayMentalHealth, displayBodyHealth;
    public Vector2 coord;
    public RectTransform rectTransform;
    // Start es llamado antes de la primera actualización de frame
    private void Start()
    {
        rectTransform= GetComponent<RectTransform>();
       
    }
    private void Update()
    {
        checkPosition();
        
    }













    private void checkPosition()
    {
        if(rectTransform.anchoredPosition.y < 0)
        {
            rectTransform.anchoredPosition=new Vector2(rectTransform.anchoredPosition.x,0);
        }
    }
    public void checkDisplay()
    {
        if (displayAge || displayBodyHealth || displayCold || displayHealth || displayMentalHealth || displayHungry || displayMoney)
        {
            if (displayAge) DisplayAge();
            else if (displayMoney) DisplayMoney();
            else if (displayHealth) DisplayHealth();
            else if (displayHungry) DisplayHungry();
            else if (displayCold) DisplayCold();
            else if (displayMentalHealth) DisplayMentalHealth();
            else if (displayBodyHealth) DisplayBodyHealth();
        }
       
       
    }
    public void printInit()
    {
        string[] initText = Enumerable.Repeat("PENDIENTE", 100).ToArray();

        textMesh.text = initText[playerStats.age - 18];
    }
    private void DisplayAge()
    {
        textMesh.text = playerStats.age.ToString();
    }
    private void DisplayMoney()
    {
        textMesh.text = playerStats.money.ToString();
    }
    private void DisplayHealth()
    {
        textMesh.text = playerStats.health.Value.ToString();
    }
    private void DisplayHungry()
    {
        textMesh.text = playerStats.hungry.Value.ToString();
    }
    private void DisplayCold()
    {
        textMesh.text = playerStats.cold.Value.ToString();
    }
    private void DisplayMentalHealth()
    {
        textMesh.text = playerStats.mentalHealth.Value.ToString();
    }
    private void DisplayBodyHealth()
    {
        textMesh.text = playerStats.bodyHealth.Value.ToString();
    }
}