using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera maincamera;
    double[] player1_posx = new double[]
    {
        0,
        -21.2, -24.62, -24.62, -24.62, -20.14,
        -20.18, -17.83, 2.07, 13.24, 19.66,
        15.9, 5.6, 4.66, 4.14, 17.6,
        -9, -28.79, -17.69, -18.31, -23.46,
        -34, -35.25, -27.15, -24.65, -24.23
    };
    double[] player1_posz = new double[]
    {
        0,
        9, 13.62, 24.55, 29.37, 28.58,
        25.57, 21.64, 23.6, 16.66, 12.8,
        0, 0.2, -5.65, -9.82, -22.6,
        -22, -23.73, -17.52, -12.72, -14.47,
        -14.12, -1.99, -4.15, -2.88, 0.67
    };
    double[] player2_posx = new double[]
    {
        0,
        -13.8, -16.77, -17.43, -16.94, -9.55,
        -11.84, -9.44, 12.49, 21.8, 28.77,
        24.9, 15.6, 14.8, 13.63, 27.1,
        -0.9, -19.94, -8.97, -7.81, -14.27,
        -25.09, -27.24, -19.32, -15.19, -14.68
    };
    double[] player2_posz = new double[]
    {
        0,
        9.1, 13.87, 24.68, 29.43, 28.63,
        25.6, 21.61, 23.72, 16.48, 12.77,
        0, 0.3, -5.28, -9.81, -22.3,
        -22, -23.58, -17.68, -12.69, -14.43,
        -14.03, -1.98, -4.12, -2.91, 0.65
    };

    public void move(int locate, int player)
    {
        if (player == 1)
        {
            transform.position = new Vector3((float)player1_posx[locate], transform.position.y, (float)player1_posz[locate]);
            maincamera.transform.position = new Vector3((float)player1_posx[locate], maincamera.transform.position.y, (float)player1_posz[locate]);
            /*
            while (transform.position != new Vector3((float)player1_posx[locate], transform.position.y, (float)player1_posz[locate]))
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3((float)player1_posx[locate], transform.position.y, (float)player1_posz[locate]), 1 * Time.deltaTime);
                StartCoroutine("pause");
            }
            */
            //transform.position = Vector3.MoveTowards(transform.position,new Vector3((float)player1_posx[locate], transform.position.y, (float)player1_posz[locate]),1);
            //camera.transform.position = Vector3.MoveTowards(camera.transform.position, new Vector3((float)player1_posx[locate], camera.transform.position.y, (float)player1_posz[locate]), 1);
        }
        else
        {
            transform.position = new Vector3((float)player2_posx[locate], transform.position.y, (float)player2_posz[locate]);
            maincamera.transform.position = new Vector3((float)player2_posx[locate], maincamera.transform.position.y, (float)player2_posz[locate]);
            /*
            while (transform.position != new Vector3((float)player2_posx[locate], transform.position.y, (float)player2_posz[locate]))
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3((float)player2_posx[locate], transform.position.y, (float)player2_posz[locate]), 1*Time.deltaTime);
                StartCoroutine("pause");
            }
            */
            //transform.position = Vector3.MoveTowards(transform.position, new Vector3((float)player2_posx[locate], transform.position.y, (float)player2_posz[locate]), 1);
            //camera.transform.position = Vector3.MoveTowards(camera.transform.position, new Vector3((float)player1_posx[locate], camera.transform.position.y, (float)player1_posz[locate]), 1);
        }
    }
}

/*
 check point
 1.億載金城
 2.林默娘公園
 3.東興洋行
 4.安平樹屋
 5.安平古堡
 6.安平開台天后宮
 7.安平遊憩碼頭
 8.花園夜市
 9.321巷藝術聚落
 10.台南公園
 11.成大榕園
 12.台南文創園區
 13.台南車站
 14.原台南縣知事官邸
 15.巴克禮公園
 16.延平郡王祠
 17.藍晒圖文創園區
 18.孔廟
 19.台灣文學館
 20.林百貨
 21.海南路藝術街
 22.神農街
 23.大天后宮
 24.祀典武廟
 25.赤崁樓

 */
