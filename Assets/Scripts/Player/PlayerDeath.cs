using Player.PlayerHealth;
using UI;
using UnityEngine;

namespace Player
{
    public class PlayerDeath : MonoBehaviour
    {
        [SerializeField] private GameObject _effect;
        [SerializeField] private HpPanel _hpPanel;

        //[SerializeField] private PlayerHp _playerHp;

        public void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Car")) ;
            {
                Instantiate(_effect, transform.position, transform.rotation);
                
                FindObjectOfType<PlayerHp>().ApplyDamage(1);
                if (_hpPanel != null)
                    Instantiate(_hpPanel, transform.position, transform.rotation);
                GetComponent<HpPanel>();

                Destroy(col.gameObject);
            }

            if (GetComponent<PlayerHp>().CurrentHp <= 0 || FindObjectOfType<Statistics>(). HPCount <= 0)

                Destroy(gameObject);
        }
    }
}