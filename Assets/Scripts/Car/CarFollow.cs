using UnityEngine;

namespace Car
{
    public class CarFollow : MonoBehaviour
    {
        [SerializeField] private Transform _target;

        public float speed;

        private void FixedUpdate()
        {
            try // попытаться сделать 
            {
                Follow();
            }

            catch //сделать что-то если не получилось
            {
            }
        }

        private void Follow()
        {
            _target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

            transform.position = Vector2.MoveTowards(transform.position,
                _target.position,
                speed * Time.deltaTime);
        }
    }
}