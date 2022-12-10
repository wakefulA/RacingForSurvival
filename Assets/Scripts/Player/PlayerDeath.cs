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

        public void OnTriggerEnter2D (Collider2D col)
        {
           if (col.gameObject.CompareTag("Car")) ;
           {
               Instantiate(_effect, transform.position, transform.rotation);
               FindObjectOfType<PlayerHp>().ApplyDamage(1);
               Instantiate(_hpPanel, transform.position, transform.rotation);
               Statistics.Instance.GetComponent<HpPanel>();
               
               Destroy(col.gameObject);

           }
           
           if (GetComponent<PlayerHp>().CurrentHp <= 0 || Statistics.Instance.HPCount <=0)

               Destroy(gameObject);
           
        }
    }
}