using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Matrix : MonoBehaviour
{
    public TextMeshPro gameWin;
    public GameObject cube;
    private int spawnPosX = -3;
    private int spawnPosZ = 3;
    public static int size = 3;
    public static GameObject[,] cubes = new GameObject[size, size];
    private int playerPos = size / 2;
    public static Vector3[,] spawnPos = new Vector3[size, size];
    private TextMeshPro text;
    public static bool turnX = true;
    public static bool turnO = false;
    public bool turnDone = false;
    public bool gameover = false;
    public int countEmpty=0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < size; i++)
        {
            spawnPosX = -3;
            for (int j = 0; j < size; j++)
            {
                spawnPos[i, j] = new Vector3(spawnPosX, 0, spawnPosZ);
                spawnPosX += 3;
            }
            spawnPosZ -= 3;
        }
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                
               cubes[i,j] = Instantiate(cube, spawnPos[i, j], cube.transform.rotation);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       
      if(PlayerController.xBool && gameover == false)
        {
            text = cubes[PlayerController.i, PlayerController.j].GetComponentInChildren<TextMeshPro>();
            if(text.text == string.Empty)
            {
                text.text = "X";
                turnX = false;
                turnO = true;
                WinCheck();
            }
            PlayerController.xBool = false;

        }
        if (turnX == false && gameover == false)
        {
            AITurn();
            turnDone = false;
            WinCheck();

        }
       
       
    }
    void WinCheck()
    {
        if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[0, 1].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "O")
        {
            gameWin.text = "O Wins";
            gameover = true;
        }
        else if (cubes[1, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[1, 2].GetComponentInChildren<TextMeshPro>().text == "O")
        {
            gameWin.text = "O Wins";
            gameover = true;
        }
        else if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[2, 1].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "O")
        {
            gameWin.text = "O Wins";
            gameover = true;
        }
        else if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[1, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "O")
        {
            gameWin.text = "O Wins";
            gameover = true;
        }
        else if (cubes[0, 1].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[2, 1].GetComponentInChildren<TextMeshPro>().text == "O")
        {
            gameWin.text = "O Wins";
            gameover = true;
        }
        else if (cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[1, 2].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "O")
        {
            gameWin.text = "O Wins";
            gameover = true;
        }
        else if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "O")
        {
            gameWin.text = "O Wins";
            gameover = true;
        }
        else if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "O")
        {
            gameWin.text = "O Wins";
            gameover = true;
        }
        if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[0, 1].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "X")
        {
            gameWin.text = "X Wins";
            gameover = true;
        }
        else if (cubes[1, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[1, 2].GetComponentInChildren<TextMeshPro>().text == "X")
        {
            gameWin.text = "X Wins";
            gameover = true;
        }
        else if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[2, 1].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "X")
        {
            gameWin.text = "X Wins";
            gameover = true;
        }
        else if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[1, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "X")
        {
            gameWin.text = "X Wins";
            gameover = true;
        }
        else if (cubes[0, 1].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[2, 1].GetComponentInChildren<TextMeshPro>().text == "X")
        {
            gameWin.text = "X Wins";
            gameover = true;
        }
        else if (cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[1, 2].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "X")
        {
            gameWin.text = "X Wins";
            gameover = true;
        }
        else if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "X")
        {
            gameWin.text = "X Wins";
            gameover = true;
        }
        else if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "X")
        {
            gameWin.text = "X Wins";
            gameover = true;
        }
        else if (gameWin.text == string.Empty && gameover)
        {
            gameWin.text = "Game Over";
        }

    }
    private void AITurn()
    {
        countEmpty = size * size;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (cubes[i, j].GetComponentInChildren<TextMeshPro>().text != string.Empty)
                {
                    countEmpty--;
                }
            }
        }
        if (countEmpty == 0)
        {
            gameover = true;
        }
        else
        {
            if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[0, 1].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[0, 2].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[1, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[1, 2].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[1, 2].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[2, 1].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[2, 2].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[1, 0].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[2, 0].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 1].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[2, 1].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[2, 1].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[1, 2].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[2, 2].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[2, 2].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[0, 2].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[0, 1].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[0, 1].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[1, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[1, 2].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[1, 1].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[2, 1].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[2, 1].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[1, 0].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[1, 0].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 1].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[2, 1].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[1, 1].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[1, 2].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[1, 2].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[1, 1].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[1, 1].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 1].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[0, 0].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[1, 2].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[1, 0].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[1, 0].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[2, 1].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[2, 0].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[1, 0].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[0, 0].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[2, 1].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[0, 1].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[0, 1].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[1, 2].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[0, 2].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[0, 0].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "O" && cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "O" && turnDone == false)
            {
                if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[2, 0].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }



            }



            if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[0, 1].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[0, 2].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[1, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[1, 2].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[1, 2].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[2, 1].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[2, 2].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[1, 0].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[2, 0].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 1].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[2, 1].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[2, 1].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[1, 2].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[2, 2].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[2, 2].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[0, 2].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[0, 1].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[0, 1].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[1, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[1, 2].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[1, 1].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[2, 1].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[2, 1].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[1, 0].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[1, 0].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 1].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[2, 1].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[1, 1].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[1, 2].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[1, 2].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[1, 1].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[1, 1].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[0, 1].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[0, 0].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[1, 2].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[1, 0].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[1, 0].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[2, 1].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[2, 0].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[1, 0].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[0, 0].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[2, 1].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[0, 1].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[0, 1].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[1, 2].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[0, 2].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[2, 2].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[0, 0].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[0, 0].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }

            }
            if (cubes[1, 1].GetComponentInChildren<TextMeshPro>().text == "X" && cubes[0, 2].GetComponentInChildren<TextMeshPro>().text == "X" && turnDone == false)
            {
                if (cubes[2, 0].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                {
                    cubes[2, 0].GetComponentInChildren<TextMeshPro>().text = "O";
                    turnX = true;
                    turnO = false;
                    turnDone = true;
                }



            }
            if (turnDone == false)
            {
                    while (turnO)
                    {
                        int i = Random.Range(0, 3);
                        int j = Random.Range(0, 3);
                        if (cubes[i, j].GetComponentInChildren<TextMeshPro>().text == string.Empty)
                        {
                            cubes[i, j].GetComponentInChildren<TextMeshPro>().text = "O";
                            turnX = true;
                            turnO = false;
                            turnDone = true;
                        }
                    }
            }

        }
       
    }
}
