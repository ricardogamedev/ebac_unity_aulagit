using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeiroScript : MonoBehaviour
{
    public float position;

    // Start is called before the first frame update
    void Start()
    {
      position = PlayerPrefs.GetFloat("position", 1);//passa a posi��o salva ou 1 se n�o 
        position ++;

        PlayerPrefs.SetFloat("position", position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
