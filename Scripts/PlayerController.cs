using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public static int i = Matrix.size / 2;
    public static int j = Matrix.size / 2;
    public static bool xBool=false;
    public static bool oBool = false;
    public static bool player1Bool = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            i--;
            if (i >= 0)
            {
                transform.position = Matrix.spawnPos[i, j] + new Vector3(0, 2, 0);
            }
            else
            {
                i = 0;
            }


        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            i++;
            if (i < Matrix.size)
            {
                transform.position = Matrix.spawnPos[i, j] + new Vector3(0, 2, 0);
               
            }
            else
            {
                i = Matrix.size - 1;
            }


        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            j--;
            if (j >= 0)
            {
                transform.position = Matrix.spawnPos[i, j] + new Vector3(0, 2, 0);
               
            }
            else
            {
                j = 0;
            }

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            j++;
            if (j < Matrix.size)
            {
                transform.position = Matrix.spawnPos[i, j] + new Vector3(0, 2, 0);
               
            }
            else
            {
                j = Matrix.size - 1;
            }

        }
        if(Input.GetKeyDown(KeyCode.X) && player1Bool && Matrix.turnO== false)
        {
            xBool = true;                       
           
        }
       
        
        
    }
    
    
}
