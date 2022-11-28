using UnityEngine;

namespace Player
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] private float _speed = 3f;
        [SerializeField] private Transform _transform;

        public void Update()
        {
            //Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            //transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);

            float hor = Input.GetAxisRaw("Horizontal");
            Vector3 dir = new Vector3(hor, 0, 0);
            _transform.Translate(dir.normalized * (Time.deltaTime * _speed));
        }
    }
}