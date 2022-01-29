using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    public GameManager gm; 
    public KeyCode CWKey, CCWKey, SprintKey;
    public float turnSpeed;
    public float moveSpeed;
    public float maxMoveSpeed;

    public int PlayerNum;

    float desiredMoveSpeed;
    float currentMoveSpeed;
    float direction;

    void Start()
    {
        currentMoveSpeed = desiredMoveSpeed = moveSpeed;

        direction = 45.0f;

    }

    void Update()
    {
        float yPosition = transform.position.y;

        if (yPosition < -2){
            gm.EndGame(PlayerNum);
        }

        currentMoveSpeed += (Time.deltaTime * 0.1f);

        if (Input.GetKey(CWKey))
        {
            direction += turnSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(CCWKey))
        {
            direction -= turnSpeed * Time.deltaTime;
        }

        desiredMoveSpeed = Input.GetKey(SprintKey) ? maxMoveSpeed : moveSpeed;

        Vector3 moveDir = new Vector3(Mathf.Sin(direction), 0, Mathf.Cos(direction)) * Time.deltaTime * currentMoveSpeed;
        transform.position += moveDir;
    }

    public void SetLocation(Vector3 loc)
    {
        transform.position = loc;
    }

    public void SetCurrentMoveSpeed(float speed){
        this.currentMoveSpeed = speed;
    }
}