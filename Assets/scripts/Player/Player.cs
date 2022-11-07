using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private CharacterController characterController;
    [SerializeField] private int health;

    private void Update()
    {
        HandleMovementInput();
        HandleRotationInput();

        if (health < 1)
        {
            GameObject.FindGameObjectWithTag("Player").SetActive(false);
        }
    }

    void HandleMovementInput()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector3 playerMovement = new Vector3(horizontal, 0f, vertical) * movementSpeed;

        characterController.Move(playerMovement);

    }

    void HandleRotationInput()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" || other.tag == "BulletEnemy")
        {
            health--;
        }
    }







}
