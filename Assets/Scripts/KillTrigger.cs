using UnityEngine;

public class KillTrigger : MonoBehaviour {
    [SerializeField] private GameObject _killObject;
    [SerializeField] private float _additionalForce = 5;
    
    void OnTriggerEnter2D(Collider2D other) {
        var player = other.gameObject.GetComponent<HeroMove>();
        if (player != null) {
            player.Jump(_additionalForce);
            Destroy(_killObject);
        }
    }
}
