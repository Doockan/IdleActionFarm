using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private CharacterController _characterController;
        [SerializeField] private BackPack _backPack;
        [SerializeField] private float _movementSpeed;

        private DynamicJoystick _inputController;


        private void Awake()
        {
            _inputController = FindObjectOfType<DynamicJoystick>();
        }

        private void Update()
        {
            Movement();
        }

        private void Movement()
        {
            Vector3 movementVector = Vector3.zero;
            if (_inputController.Direction.sqrMagnitude > 0.05f)
            {
                movementVector = new Vector3(_inputController.Horizontal, 0f, _inputController.Vertical);

                transform.forward = movementVector;
            }

            movementVector += Physics.gravity;

            _characterController.Move(_movementSpeed * movementVector * Time.deltaTime);
        }
    }
}