using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BallBase ballBase;
    public StateMachine stateMachine;
    public float timeToSetBallFree = 1f;


    public static GameManager Instance;

    public Player[] players;

    [Header("Menus")]
    public GameObject uiMainMenu;
    private void Awake()
    {
        Instance = this;

        players = FindObjectsOfType<Player>();
    }

    public void SwitchStateReset()
    {
        stateMachine.ResetPosition();
    }

    public void ResetBall()
    {
        ballBase.ResetBall();
        ballBase.CanMove(false);
        Invoke(nameof(SetBallFree), timeToSetBallFree);
    }

    public void ResetPlayers()
    {
        foreach(var player in players)
        {
            player.ResetPlayer();
        }
    }
    private void SetBallFree()
    {
        ballBase.CanMove(true);
    }
    public void StartGame()
    {
        ballBase.CanMove(true);
    }

    public void EndGame()
    {
        stateMachine.SwitchStates(StateMachine.States.END_GAME);
        ballBase.CanMove(false);//aqui
    }

    public void ShowMainMenu()
    {
        uiMainMenu.SetActive(true);
        ballBase.CanMove(false);
    }
}
