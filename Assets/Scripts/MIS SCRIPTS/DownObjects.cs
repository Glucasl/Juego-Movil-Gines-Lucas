using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownObjects : MonoBehaviour
{
    public List<GameObject> objectsToThrow;
    public Vector3 startPosition;
    public Vector3 endPosition;
    public Transform player;
    public float throwForce = 10f;
    public float throwIntervalMin = 1f;
    public float throwIntervalMax = 3f;
    public int poolSize = 10;

    private float timer;
    [SerializeField] private Queue<GameObject> objectPool;

    private void Start()
    {
        timer = Random.Range(throwIntervalMin, throwIntervalMax);
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
            ThrowFromRange();
            timer = Random.Range(throwIntervalMin, throwIntervalMax);
        }
    }

    private void ThrowFromRange()
    {
        if(objectPool.Count > 0) {
            GameObject obj = objectPool.Dequeue();
            obj.transform.position = new Vector3(Random.Range(startPosition.x, endPosition.x), 
                                                Random.Range(startPosition.y, endPosition.y), 
                                                Random.Range(startPosition.z, endPosition.z));
            obj.SetActive(true);
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.down * throwForce, ForceMode.Impulse);
            objectPool.Enqueue(obj);
        }
    }
}