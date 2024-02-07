using System.Collections;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSperd = 5f;
    public float leftRightSpeed = 5f;
    static public bool canMove = false;
    public bool isJumping = false;
    public bool commingDown = false;
    public GameObject playerObject;
    void Update()
    {
        transform.Translate(Vector3.forward * (moveSperd * Time.deltaTime), Space.World );
        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (gameObject.transform.position.x > LevelBounder.leftSide)
                {
                    transform.Translate(Vector3.left * (leftRightSpeed * Time.deltaTime));
                }
            }if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (gameObject.transform.position.x < LevelBounder.rightSide)
                {
                    transform.Translate(Vector3.right * (leftRightSpeed * Time.deltaTime));
                }
            }

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
            {
                if (isJumping == false)
                {
                    isJumping = true;
                    playerObject.GetComponent<Animator>().Play("Jump");
                    StartCoroutine(JumpSequence());
                }
            }
            {
                
            }
            
        }

        if (isJumping == true)
        {
            if (commingDown == false)
            {
                 transform.Translate(Vector3.up * (3 * Time.deltaTime), Space.World);   
                 
            }
            if (commingDown == true)
            {
                transform.Translate(Vector3.up * (-3 * Time.deltaTime), Space.World);   
                 
            }
        }
        
    }

    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.45f);
        commingDown = true;
        yield return new WaitForSeconds(0.45f);
        isJumping = false;
        commingDown = false;
        playerObject.GetComponent<Animator>().Play("Standard Run");

    }
}
