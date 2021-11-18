using UnityEngine;
public class DeadEnd : MonoBehaviour
{
	[SerializeField] GameObject Hero;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Hero.GetComponent<CoinController>().Coin = 0;
            Hero.transform.position = new Vector2(-6, -3);
        }
    }
}
