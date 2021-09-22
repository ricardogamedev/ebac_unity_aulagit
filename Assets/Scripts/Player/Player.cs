using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;
using TMPro;

public class Player : MonoBehaviour
{
    public string playerName;
    private int maxPoints = 2;
    public float speed = 10;
    public Image uiPlayer;

    [Header("Key Setup")]
    public KeyCode KeyCodeMoveUp = KeyCode.UpArrow;
    public KeyCode KeyCodeMoveDown = KeyCode.DownArrow;



    public Rigidbody2D myrigidbody2D;
    [Header("Score")]
    public int currentPoints;
    public TextMeshProUGUI uiTextPoints;

    private void Awake()
    {
        ResetPlayer();
    }

    public void SetName(string s)
    {
        playerName = s;
    }

    public void ResetPlayer()
    {
        currentPoints = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCodeMoveUp))
        {
            myrigidbody2D.MovePosition(transform.position + transform.up * speed);
     //   transform.Translate(transform.up * speed);

        }else if (Input.GetKey(KeyCodeMoveDown))
        {
            myrigidbody2D.MovePosition(transform.position + transform.up * -speed);
            // transform.Translate(transform.up * speed * -1);

        }

    }

    public void AddPoint()
    {
        currentPoints++;
        updateUI();
        CheckMaxPoints();
        Debug.Log(currentPoints);
    }

    private void updateUI()
    {
        uiTextPoints.text = currentPoints.ToString();
    }

    private void CheckMaxPoints()
    {
        if(currentPoints >= maxPoints)
        {
            GameManager.Instance.EndGame();
            HighScoreManager.Instance.SavePlayerWin(this);
        }
    }
    public void ChangeColor(Color c)
    {
        uiPlayer.color = c;
    }

  
}
