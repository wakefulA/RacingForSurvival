using Car;
using UI;
using UnityEngine;

namespace Infrastructure.Launcher.Services.HP
{
    public class HPService : MonoBehaviour
    {
        private HpPanel _hpPanel;

        private CarSpawn _carSpawn;
        
        

        public int HP { get; private set; } = 3;

        private void Start()
        {
            _hpPanel = FindObjectOfType<HpPanel>();
            _carSpawn = FindObjectOfType<CarSpawn>();
            
        }

        public void RestartHP()
        {
            HP = 3;
            _hpPanel.HpChanged(HP);
        }

        public void DiscrementHP()
        {
            HP--;
            
            _hpPanel.HpChanged(HP);
            
            if(HP == 0)
            {
                _carSpawn.GameOver();
            }
        }
    }
}