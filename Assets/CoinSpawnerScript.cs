using UnityEngine;

public class CoinSpawnerScript : MonoBehaviour
{
    public GameObject coin;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    public float widthOffset = 10;

    void Start()
    {
        spawnCoin();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnCoin();
            timer = 0;
        }

    }

    void spawnCoin()
    {
        float minY = transform.position.y - heightOffset;
        float minX = transform.position.x - widthOffset;
        float maxY = transform.position.y + heightOffset;
        float maxX = transform.position.x + widthOffset;

        Vector3 spawnPoint = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);

        Instantiate(coin, spawnPoint, transform.rotation);
    }
}
