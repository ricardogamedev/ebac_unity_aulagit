using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPoint : MonoBehaviour
{
    public Player player;
    public string tagToCheck = "Ball";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == tagToCheck)
        {
            Debug.Log("Bati na bola");
            CountPoint();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void CountPoint()
    {
        StateMachine.Instance.ResetPosition();
        player.AddPoint();
    }
}
