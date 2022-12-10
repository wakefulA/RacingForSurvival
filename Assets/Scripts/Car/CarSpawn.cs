using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Car
{
    public class CarSpawn : MonoBehaviour
    {
        public GameObject[] cars;
        private float[] positions = {1.09f, 3.47f, -3.31f, -1.15f};

        private void Start()
        {
            StartCoroutine(Spawn());
        }

        IEnumerator Spawn()
        {
            for (int i = 0; i < 10; i++)
            {
                Instantiate(cars[Random.Range(0, cars.Length)], new Vector3(positions[Random.Range(0, 4)], 6.5f, 0),
                    Quaternion.Euler(new Vector3(-90, 360, 0)));

                yield return new WaitForSeconds(2.5f);
            }
        }
    }
}