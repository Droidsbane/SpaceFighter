using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D mRigidbody = null;
    [SerializeField] private PlayerData mPlayerConfig = null;

    private float mVerticalMovement;
    private float mHorizontalMovement;
    private float mMoveSpeed;
    private float mTurnSpeed;
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";
    // Start is called before the first frame update
    private void Start()
    {
        mMoveSpeed = mPlayerConfig.MovementSpeed;
        mTurnSpeed = mPlayerConfig.TurningSpeed;
    }

    
    private void FixedUpdate()
    {
        
    }
    private void Update()
    {
        Quaternion rot = transform.rotation;

        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3 (0,Input.GetAxis("Vertical") * mMoveSpeed * Time.deltaTime);

        pos += rot * velocity;

        float z = rot.eulerAngles.z;

        z -= Input.GetAxis("Horizontal") * mTurnSpeed * Time.deltaTime;

        rot = Quaternion.Euler(0,0,z);

        transform.rotation = rot;
    }
    public void OnMovement(InputValue value)
    {
        mHorizontalMovement = value.Get<Vector2>().x;
        mVerticalMovement = value.Get<Vector2>().y;
    }
}
