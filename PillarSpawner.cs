using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSpawner : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float posY;
    [SerializeField] private float negY;

    [Header("Elements")]
    [SerializeField] private GameObject pillar;

    private float timer;
    [SerializeField] private float maxTime;

    private void Start()
    {
        SpawnPillars();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= maxTime)
        {
            SpawnPillars();
            timer = 0;
        }
    }

    private void SpawnPillars()
    {
        float yPillar = Random.Range(posY, negY);

        GameObject spawnedPillar = Instantiate(pillar);

        spawnedPillar.transform.position = new Vector3(transform.position.x, yPillar, transform.position.z);
    }
}
