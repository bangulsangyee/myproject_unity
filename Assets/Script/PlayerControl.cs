using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerControl : MonoBehaviour
{

    public float moveSpeed; // �̵����ǵ�.
    public float jumpPower; // �����Ŀ�.
    public float gravity;   // �߷�.

    private CharacterController controller; // ĳ���� ��Ʈ�ѷ�.
    private Vector3 moveDir;                // ������ ���� ����.

    void Start()
    {
        moveSpeed = 5.0f;
        jumpPower = 7.0f;
        gravity = 9.8f;

        moveDir = Vector3.zero;
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // ���� ĳ���Ͱ� ���� �ִ°�?
        if (controller.isGrounded)
        {
            // ������ Ű����κ��� �Է¹ޱ�. 
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            // �̵����ǵ� ����.
            moveDir *= moveSpeed;

            // ����Ű(�����̽�)�� �����ٸ�, �����Ŀ� ����.
            if (Input.GetButton("Jump"))
                moveDir.y = jumpPower;

        }

        // �߷� ����.
        moveDir.y -= gravity * Time.deltaTime;

        // ĳ���� ������.
        controller.Move(moveDir * Time.deltaTime);


        if (transform.position.y < -20)
        {
            // 0, 10, 0 ���� ��ǥ �ٲٱ�
            transform.position
               = new Vector3(0, 15, -13);
            GetComponent<AudioSource>().Play();
        }


    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("FINISH"))
        {
            SceneManager.LoadScene("Stage2");

        }

        if (collision.collider.CompareTag("FINALY"))
        {
            SceneManager.LoadScene("Clear");

        }

    }


}