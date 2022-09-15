using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    public int life;
    public int money;

    public void SetUp( int life, int money)
    {
        this.life = life;
        this.money = money; 
    }

    private void Awake()
    {
        Instance = this;
    }
}
