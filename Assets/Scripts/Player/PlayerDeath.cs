using Infrastructure.Launcher.Services.HP;
using Player.PlayerHealth;
using UI;
using UnityEngine;
using Zenject;

namespace Player
{
    public class PlayerDeath : MonoBehaviour
    {
        [SerializeField] private GameObject _effect;
        [SerializeField] private HpPanel _hpPanel;

        private HPService _hpService;

        [Inject]
        public void Construct(HPService hpService)
        {
            _hpService = hpService;
        }

        //[SerializeField] private PlayerHp _playerHp;

        public void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("Wall"))
            {
                return;
            }

            if (col.gameObject.CompareTag("Car")) ;
            {
                Instantiate(_effect, transform.position, transform.rotation);
                
                _hpService.DiscrementHP();

                //FindObjectOfType<HPService>().DiscrementHP();
                if (_hpPanel != null)
                    Instantiate(_hpPanel, transform.position, transform.rotation);


                //  GetComponent<HpPanel>();

                //Destroy(col.gameObject);
            }


            //if (GetComponent<PlayerHp>().CurrentHp <= 0 || FindObjectOfType<Statistics>().HPCount <= 0)

            // Destroy(gameObject);
        }
    }
}