using UnityEngine;
using Zenject;

namespace Infrastructure.Launcher.Services.Input
{
    public class PlayerMove : MonoBehaviour, IInputService
    {
        [SerializeField] private float _speed = 3f;
        [SerializeField] private Transform _transform;

        private Vector3 _force;
        private IInputService _inputService;

        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";

        [Inject]
        public void Construct(IInputService inputService)
        {
            _inputService = inputService;
        }

        private void Update()
        {
            if (_inputService == null)
                return;
            Move();
            Acceleration();
        }

        public void Acceleration()
        {
            if (_transform != null)
            {
                _transform.position += _force;

                if (UnityEngine.Input.GetKey(KeyCode.Space))
                {
                    _force += (_transform.up * Time.deltaTime) * 0.05f;
                }

                else
                {
                    _force = Vector3.Lerp(_force, Vector3.zero, Time.deltaTime);
                }
            }
        }

        public void Move()
        {
            float hor = UnityEngine.Input.GetAxisRaw("Horizontal");
            float vertical = UnityEngine.Input.GetAxisRaw("Vertical");
            Vector3 dir2 = new Vector3(0, vertical, 0);
            Vector3 dir = new Vector3(hor, 0, 0);
            if (_transform != null)
            {
                _transform.Translate(dir.normalized * (Time.deltaTime * _speed));
                if (_transform != null)
                    _transform.Translate(dir2.normalized * (Time.deltaTime * _speed));
            }
        }
    }
}