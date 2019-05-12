using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public GameObject PlayerStat;
    public Text PlayerHP;
    public GameObject enamyStat;
    public Text enamyHP;
    public Animator death;

    private Stats Pstat;
    private Stats Estat;
    private void Start()
    {
        Pstat = PlayerStat.GetComponent<Stats>();
        Estat = enamyStat.GetComponent<Stats>();
    }

    public void Turn()
    {
        // Reikanna meyðslin á óvininum
        int Edamage = Pstat.attack - Estat.defense;
        // Reikna líf óvinsins eftir meyðlins
        Estat.health = Estat.health - Edamage;
        enamyHP.text = "HP:" + Estat.health;

        // ef spilarin deyr faraí scene "Win"
        if (Estat.health == 0)
        {
            death = GetComponent<Animator>();
            death.SetBool("dead", true);
            SceneManager.LoadScene("Win");
        }

        int ETurn = Random.Range(0, 9);
        if (ETurn == 9)
        {
            Estat.health += 5;
            enamyHP.text = "HP:" + Estat.health;
        }
        else
        {
            // Reikanna meyðslin á spilarans
            int Pdamage = Estat.attack - Pstat.defense;
            // Reikna líf óvinsins eftir meyðlins
            Pstat.health -= Pdamage;
            PlayerHP.text = "HP:" + Pstat.health;
        }
        // ef spilarin deyr faraí scene "Game Over"
        if (Pstat.health == 0)
        {
            SceneManager.LoadScene("Game Over");
        }

    }
}
