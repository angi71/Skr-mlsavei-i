using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public Text HP;
    public int health;
    public int attack;
    public int defense;

    void Start()
    {
        //Sýnir líf í byruns bardaga
        HP.text = "HP:" + health;

    }
}
