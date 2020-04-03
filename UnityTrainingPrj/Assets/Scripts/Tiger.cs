using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiger : MonoBehaviour
{
    Animator animator;
    Rigidbody rigidbody;
    float moveSpeed=0;
    // Start is called before the first frame update
    private void Awake()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }
    void Start()
    {

    }
    void UpdateKeyboardEvents()
    {
        animator.SetBool("SpacePressDown", Input.GetKeyDown(KeyCode.Space));

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveSpeed=Mathf.Min(moveSpeed+Time.deltaTime,3);
        }
        else
        {
            moveSpeed = Mathf.Max(moveSpeed - Time.deltaTime*3, 0);
        }
        animator.SetFloat("Speed", moveSpeed);
    }
    private void FixedUpdate()
    {
        rigidbody.velocity = new Vector3(moveSpeed, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {
        UpdateKeyboardEvents();
    }
}
