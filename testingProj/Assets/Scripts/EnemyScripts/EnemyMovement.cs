using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    GameObject player;
    CharacterHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<CharacterHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }


     void Update()
    {
        if (enemyHealth.currentHealth > 0 && playerHealth.healthPoints > 0)
        {
			
            nav.SetDestination(player.transform.position);
        }
        else
        {
            //nav.enabled = false;
        }
    }
}
