using UnityEngine;
using Zenject;

namespace Player
{
    public class PlayerMove : MonoBehaviour, IInputService
    {
        [SerializeField] private float _speed = 3f;
        [SerializeField] private Transform _transform;
        private Vector3 _force;

        // public Vector2 position;

        // private Vector2 moveVelocity;
        //private Rigidbody2D rb;

        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";

        private IInputService _inputService;

        [Inject]
        public void Construct(IInputService inputService)
        {
            _inputService = inputService;
        }

        // private float _horizontalInput;
        // private float _verticalInput;
        // private bool _isBreaking;

        //  private void Start()
        // {
        //     rb = GetComponent<Rigidbody2D>();
        // }

        //private void FixedUpdate()
        //{
        //  GetInput();

        //}

        // private void GetInput()
        // {
        //  _horizontalInput = Input.GetAxisRaw(Horizontal);
        //   _verticalInput = Input.GetAxisRaw(Vertical);
        //  _isBreaking = Input.GetKey(KeyCode.Escape);
        //  }

        private void Update()
        {
            if (_inputService == null)
                return;

            // Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            // moveVelocity = moveInput.normalized * _speed;

            //Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            //transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);

            Move();
            Acceleration();
        }

        public void Acceleration()
        {
            if (_transform != null)
            {
                _transform.position += _force;

                if (Input.GetKey(KeyCode.Space))
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
            float hor = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
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