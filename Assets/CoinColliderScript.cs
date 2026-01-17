using UnityEngine;

public class CoinColliderScript : MonoBehaviour
{
    public
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreScript.Instance.UpdateScore(1);
        Destroy(gameObject);
    }
}
