using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    public Player player1;
    public Player player2;
    public Camera maincamera;
    public GameObject Turnblank;
    public MapInformation mapinformation;

    int whichPlayer = 1;
    int player1Locate = 0;
    int player2Locate = 0;
    public void Awake()
    {
        player1.transform.position = new Vector3(0, 0, 0);
        player2.transform.position = new Vector3(0, 0, 0);
    }
    public void LetPlayerMove(int diceNumber)
    {
        if (whichPlayer == 1)
        {
            player1Locate = player1Locate + diceNumber;
            if (player1Locate > 25) player1Locate -= 25;
            player1.move(player1Locate, whichPlayer);
            mapinformation.changeInformation(player1Locate);
        }
        else
        {
            player2Locate = player2Locate + diceNumber;
            if (player2Locate > 25) player2Locate -= 25;
            player2.move(player2Locate, whichPlayer);
            mapinformation.changeInformation(player2Locate);
        }
    }
    public void changePlayer()
    {
        if (whichPlayer == 1)
        {
            Turnblank.GetComponent<Text>().text = "歲星的回合";
            maincamera.transform.position = new Vector3(player2.transform.position.x, maincamera.transform.position.y, player2.transform.position.z);
            whichPlayer = 2;
        }
        else
        {
            Turnblank.GetComponent<Text>().text = "小滿的回合";
            maincamera.transform.position = new Vector3(player1.transform.position.x, maincamera.transform.position.y, player1.transform.position.z);
            whichPlayer = 1;
        }
    }
}
