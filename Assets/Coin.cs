using UnityEngine;

public class Coin : MonoBehaviour
{

    gameManagerScript gm;

    private void Start()
    {
        gm = FindAnyObjectByType<gameManagerScript>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            gm.coinAdder();
            Destroy(gameObject); 
        }
    }
}
