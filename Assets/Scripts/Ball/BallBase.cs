using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//collab
public class BallBase : MonoBehaviour
{
    public Vector3 speed = new Vector3(1, 1, 0);
    private Vector3 startSpeed;

    public string keyToCheck = "Player";

    [Header("Randomization")]
    public Vector2 randomSpeedY = new Vector2(1, 3);
    public Vector2 randomSpeedX = new Vector2(1, 3);

    private Vector3 _startPosition;

    public bool _canMove = false;

    private void Awake()
    {
        _startPosition = transform.position;
        startSpeed = speed;
    }
    // Update is called once per frame
    void Update()
    {
        if (!_canMove) return;

        transform.Translate(speed);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == keyToCheck)

            OnPlayerCollision();

        else

            speed.y *= -1;
    }

    private void OnPlayerCollision()
    {
        speed.x *= -1;

        float random = Random.Range(randomSpeedX.x, randomSpeedX.y);

        if(speed.x < 0)
        {
            random = -random;
        }

        speed.x = random;

        random = Random.Range(randomSpeedY.x, randomSpeedY.y);

        speed.y = random;

    }

    public void ResetBall()
    {
        transform.position = _startPosition;
        speed = startSpeed;
       

    }
    public void CanMove(bool state)
    {
        _canMove = state;
    }
}
