using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    int Status = 0;
    public GameObject Heart;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;
    public GameObject Star4;
    public GameObject Star5;
    public GameObject[] UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (Status)
        {
            case 0: //調查中

                break;
            case 1: //找對目標

                break;
            case 2: //找錯目標

                break;
        }
    }

    void Find_Heart()
    {
        if(Status == 0)
        {
              UI[0].SetActive(true);
              Status = 1;

        }
    }

    void Find_Star()
    {
        if (Status == 0)
        {
             UI[1].SetActive(true);
             Status = 2;
        }
    }
}
