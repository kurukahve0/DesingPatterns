using System;
using UnityEngine;

namespace State
{

    public class PlayerController : MonoBehaviour
    {
        public event Action<StateBase> OnChangeState;
        public Rigidbody PlayerRigidbody => rb;

        public float moveSpeed = 5f;
        public float jumpForce = 5f;
        public Transform groundCheck;
        public LayerMask groundLayer;

        private bool isGrounded;
        private Vector3 movementInput;
        private StateBase currentState; // Mevcut durum
        private Rigidbody rb;




        void Start()
        {
            rb = GetComponent<Rigidbody>();
            ChangeState(new IdleState(this));
        }

        void Update()
        {
            movementInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            isGrounded = Physics.CheckSphere(groundCheck.position, 0.05f, groundLayer);

            currentState?.Update();
//        Debug.Log(IsMoving());
        }

        void FixedUpdate()
        {

            if (IsMoving())
            {
                rb.velocity = new Vector3(movementInput.x * moveSpeed, rb.velocity.y, movementInput.z * moveSpeed);

            }
        }


        public void ChangeState(StateBase newState)
        {
            currentState?.Exit();
            currentState = newState;
            currentState.Enter();
            OnChangeState?.Invoke(currentState);
        }

        public bool IsMoving()
        {
            return movementInput.magnitude > 0.1f;
        }


        public bool IsJumping()
        {
            return isGrounded && Input.GetKeyDown(KeyCode.Space);
        }


        public bool IsGrounded()
        {
            return isGrounded;
        }


        public void Jump()
        {
            isGrounded = false;
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }

    }
}