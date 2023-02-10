using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public EnemyProducer enemyProducer;
    public GameObject playerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        var player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        player.onPlayerDeath += onPlayerDeath;
    }

    void onPlayerDeath(Player player)
    {
        enemyProducer.SpawnEnemies(false);
        Destroy(player.gameObject);

        Invoke("restartGame", 3f); //restart function, but will have a 3 second delay
    }


    void restartGame()
    {
        var enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (var enemy in enemies)
        {
            Destroy(enemy);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
