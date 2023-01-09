using System;
using Mission;
using UnityEngine;
using Zenject;

namespace Car
{
    public class EnemyDeath : MonoBehaviour
    {
        private int _carCount;

        private IMissionCheker _missionCheker;

        [Inject]
        public void Construct(IMissionCheker missioncheker)
        {
            _missionCheker = missioncheker;
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            _missionCheker.Ienumerator();
            Destroy(gameObject);
        }
    }
}

// 