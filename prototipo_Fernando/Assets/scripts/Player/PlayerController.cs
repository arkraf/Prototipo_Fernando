using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 6f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 movement = Vector3.zero;
    private CharacterController controller;
    public Transform pivoteCam;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    } 
       
    

    // Update is called once per frame
    void Update()
    {
        movement = pivoteCam.TransformDirection(new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical")));
        movement = movement * speed;

        Vector3 temp_Rot_Vector = pivoteCam.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
        if (temp_Rot_Vector.magnitude > 0.1)
        {
            transform.forward = temp_Rot_Vector.normalized;
        }

        movement.y = movement.y - (gravity * Time.deltaTime);

        controller.Move(movement * Time.deltaTime);
    }
}
