using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    [SerializeField] private GameObject monsters;
    [SerializeField] private GameObject items;
    [SerializeField] private GameObject correctItems;
    [SerializeField] private GameObject ui;
    [SerializeField] private GameObject diary;
    


    private void Awake()
    {
        monsters.SetActive(false);
        items.SetActive(false);
        correctItems.SetActive(false);
        ui.SetActive(true);
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        items.SetActive(true);
    }

    public void MonsterBegin()
    {   
        monsters.SetActive(true);
        ui.SetActive(false);
    }
    public void AllMonsterDefeated()
    {
        monsters.SetActive(false);
        items.SetActive(false);
        ui.SetActive(true);
    }
  
    public void GameOver()
    {
        monsters.SetActive(false);
        items.SetActive(false);
        ui.SetActive(true);
    }
    public void GameWin()
    {
        monsters.SetActive(false);
        items.SetActive(false);
        ui.SetActive(true);
        diary.SetActive(true);
    }

    public void AfterDiaryPick()
    {
        monsters.SetActive(true);
        correctItems.SetActive(true);
        ui.SetActive(false);

    }

}
