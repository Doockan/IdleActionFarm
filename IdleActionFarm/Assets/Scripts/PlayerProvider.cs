using UnityEngine;

public class PlayerProvider : MonoBehaviour
{
    public CharacterController characterController;
    public float MovementSpeed;
    
    private DynamicJoystick _inputController;
    private Camera _camera;

    private void Awake()
    {
        _inputController = FindObjectOfType<DynamicJoystick>();
    }

    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        Vector3 movementVector = Vector3.zero;
        if (_inputController.Direction.sqrMagnitude > 0.05f)
        {
            movementVector = new Vector3(_inputController.Horizontal, 0f, _inputController.Vertical);

            transform.forward = movementVector;
            
        }

        movementVector += Physics.gravity;
        
        characterController.Move(MovementSpeed * movementVector * Time.deltaTime);
    }
}