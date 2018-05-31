using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public List<Transform> pos;
    public GameObject enemy;
    GameObject enemyInstance;

    public float maxTime;
    [SerializeField]
    float time;

	void Start () {
		
	}
	
	void Update () {
        if(time > 0 && time < maxTime)
        {
            time--;
        }

        if (time <= 0)
        {
            time = maxTime;
        }

        if (time == maxTime)
        {
            Spawn();
            time--;
        }

    }

    void Spawn()
    {
        enemyInstance = Instantiate(enemy, pos[0]);
        enemyInstance = Instantiate(enemy, pos[1]);
        enemyInstance = Instantiate(enemy, pos[2]);
        enemyInstance = Instantiate(enemy, pos[3]);
    }
}
