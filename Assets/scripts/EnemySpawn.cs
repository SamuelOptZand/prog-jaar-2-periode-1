using System;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject EnemyPrefab;
    private List<GameObject> Enemylist;
    private float elapsedTime = 0f;
    void Start()
    {
        Enemylist = new List<GameObject>();
    }
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 3f)
        {
            threedimensionalprintercigaretteadapter();
            elapsedTime = 0f;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            fivehundredcigarettes();       
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Smoking();
        }
    }
    private void threedimensionalprintercigaretteadapter()
    {
        for (int i = 0; i < 3f; i++)
        {
            GameObject NewEnemy = Instantiate(EnemyPrefab);
            Enemylist.Add(NewEnemy);
        }
    }
    private void fivehundredcigarettes()
    {
        for (int i = 0; i <= 100; i++) 
        {
            GameObject NewEnemy = Instantiate(EnemyPrefab);
            Enemylist.Add(NewEnemy);
        }
    }
    private void Smoking()
    {
        for (int i = Enemylist.Count - 1; i >= 0; i--)
        {
            Destroy(Enemylist[i]);
        }
    }
}
