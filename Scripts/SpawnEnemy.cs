using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        // ef spilanrin labbar á óvin opan scene "Batttle"
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Battle");
        }
    }
}
