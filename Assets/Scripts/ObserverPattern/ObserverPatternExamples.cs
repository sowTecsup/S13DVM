using System;
using UnityEngine;

public class ObserverPatternExamples : MonoBehaviour
{
    //-> open/ closed 

    public static event Action simpleAction;

    public int PlayerHp = 10;

    public static event Action<int> OnPlayerLifeChanged;
    void Start()
    {
        // simpleAction += evento1
        // simpleAction += evento2
        simpleAction = null;
    }


    void Update()
    {
        
    }

    public void TakeDamage(int amount)
    {
        PlayerHp -= amount;
        //uimanager.playerhpbar.set(playerHP) XXXXXXXXXXXXXXX
        //GameManger.instance.UIMnanager.Sethpbar = 10; XXXXXXXXXXXXXXXXXX
        OnPlayerLifeChanged?.Invoke(PlayerHp);
    }
    public void HealPlayer(int amount)
    {
        PlayerHp += amount;
        OnPlayerLifeChanged?.Invoke(PlayerHp);
    }
}
