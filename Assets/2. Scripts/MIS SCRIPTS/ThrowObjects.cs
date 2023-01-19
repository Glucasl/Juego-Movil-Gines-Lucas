using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObjects : MonoBehaviour
{
    public List<GameObject> objectsToThrow;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;
    public Transform player;
    public float throwForce = 10f;
    public float throwIntervalMin = 1f;
    public float throwIntervalMax = 3f;
    public int poolSize = 10;

    private float timer;
    private Transform[] spawnPoints;
    [SerializeField] private Queue<GameObject> objectPool;

    private void Start()
    {
        timer = Random.Range(throwIntervalMin, throwIntervalMax);
        spawnPoints = new Transform[] { spawnPoint1, spawnPoint2, spawnPoint3, spawnPoint4 };
        objectPool = new Queue<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            int randomIndex = Random.Range(0, objectsToThrow.Count);
            GameObject obj = Instantiate(objectsToThrow[randomIndex]);
            obj.SetActive(false);
            objectPool.Enqueue(obj);
        }
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            int randomIndex = Random.Range(0, spawnPoints.Length);
            ThrowFromPoint(spawnPoints[randomIndex]);
            timer = Random.Range(throwIntervalMin, throwIntervalMax);
        }
    }

    private void ThrowFromPoint(Transform spawnPoint)
    {
        GameObject obj = objectPool.Dequeue();
        obj.transform.position = spawnPoint.position;
        obj.transform.rotation = spawnPoint.rotation;
        obj.SetActive(true);
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        rb.AddForce((player.position - spawnPoint.position).normalized * throwForce, ForceMode.Impulse);
        objectPool.Enqueue(obj);
    }
}