using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    [SerializeField] float spawnTime = 2;
    [SerializeField] float height= 0.5f;
    [SerializeField] GameObject block;

    float timer=2;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnTime)
        {
            SpawnBlock();
            timer = 0;
        }
    }
    void SpawnBlock()
    {
        Vector3 spawnPos = transform.position + new Vector3(5, Random.Range(-height, height));
        GameObject spawnedBlock = Instantiate(block, spawnPos, Quaternion.identity);
        spawnedBlock.transform.SetParent(null);
        Destroy(spawnedBlock, 10f);
    }
}
