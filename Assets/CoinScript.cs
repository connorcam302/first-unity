using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float lifespan = 5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, lifespan);
    }
}
