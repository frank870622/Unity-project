using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera maincamera;
    int money;
    int score;
    double[] player1_posx = new double[]
    {
        -3.24,
        -21.2, -24.62, -17.83, -24.62, -20.18,
        -24.62, -20.14, 2.07, 13.24, 19.66,
        15.9, 5.6, 4.66, 4.14, 17.6,
        -9, -17.69, -28.79, -34, -23.46,
        -18.31, -27.15, -35.25, -24.65, -24.23
    };
    double[] player1_posz = new double[]
    {
        4.47,
        9, 13.62, 21.64, 24.55, 25.57,
        29.37, 28.58, 23.6, 16.66, 12.8,
        0, 0.2, -5.65, -9.82, -22.6,
        -22, -17.52, -23.73, -14.12, -14.47,
        -12.72, -4.15, -1.99, -2.88, 0.67
    };
    double[] player2_posx = new double[]
    {
        3.59,
        -13.8, -16.77, -9.44, -17.43, -11.84,
        -16.94, -9.55, 12.49, 21.8, 28.77,
        24.9, 15.6, 14.8, 13.63, 27.1,
        -0.9, -8.97, -19.94, -25.09, -14.27,
        -7.81, -19.32, -27.24, -15.19, -14.68
    };
    double[] player2_posz = new double[]
    {
        4.47,
        9.1, 13.87, 21.61, 24.68, 25.6,
        29.43, 28.63, 23.72, 16.48, 12.77,
        0, 0.3, -5.28, -9.81, -22.3,
        -22, -17.68, -23.58, -14.03, -14.43,
        -12.69, -4.12, -1.98, -2.91, 0.65
    };

    double[] player1_moveroadx = new double[]
    {
        -17.58, -18.01, -20.9, -23.1,  // position 0~1  player1_moveroadx[0] ~ [3]
        -22.61,                        // position 1~2  player1_moveroadx[4]
        -13.64, -14.03, -17.34,        // position 2~3  player1_moveroadx[5] ~ [7]
        -23.17, -24.4,                 // position 3~4  player1_moveroadx[8] ~ [9]
        -21.3, -21.84,                 // position 4~5  player1_moveroadx[10] ~ [11]
                                       
        -21.75,                        // position 5~6  player1_moveroadx[12]
        -19.62,                        // position 6~7  player1_moveroadx[13]
        -16.22, -13.49, -12.02, 2.63,  // position 7~8  player1_moveroadx[14] ~ [17]
        9.64, 15.92, 10.37,            // position 8~9  player1_moveroadx[18] ~ [20]
        19.14,                         // position 9~10  player1_moveroadx[21]

        25.55, 23.41, 17.57,           // position 10~11  player1_moveroadx[22] ~ [24]
        2.32,                          // position 11~12  player1_moveroadx[25]
        1.97,                          // position 12~13  player1_moveroadx[26]
        1.59,                          // position 13~14  player1_moveroadx[27]
        1.77, 22.87, 25.92, 15.28,     // position 14~15  player1_moveroadx[28] ~ [31]

        5.48, 1.01, 1.15, -2.94, -3, -7.68,     // position 15~16  player1_moveroadx[32] ~ [37]
        -17.16,                                 // position 16~17  player1_moveroadx[38]
        -26.67, -26.5,                          // position 17~18  player1_moveroadx[39] ~ [40]
        -32.2, -32.6,                           // position 18~19  player1_moveroadx[41] ~ [42]
        -22.2,                                  // position 19~20  player1_moveroadx[43]

        -17.16,                                 // position 20~21  player1_moveroadx[44]
        -15.13, -15.39, -26.33,                 // position 21~22  player1_moveroadx[45] ~ [47]
        -35.91, -34.2,                          // position 22~23  player1_moveroadx[48] ~ [49]
        -24.85,                                 // position 23~24  player1_moveroadx[50]
        -22.33,                                 // position 24~25  player1_moveroadx[51]

        -7.21, -3.82, -3.24                     // position 25~0  player1_moveroadx[52] ~ [54]
    };
    double[] player1_moveroadz = new double[]
    {
        4.47, 6.22, 4.91, 8.16,         // position 0~1  player1_moveroadz[0] ~ [3]
        12.76,                          // position 1~2  player1_moveroadz[4]
        16.42, 22, 22, 22.3,            // position 2~3  player1_moveroadz[5] ~ [7]
        18.88, 22.87,                   // position 3~4  player1_moveroadz[8] ~ [9]
        23.92, 25.54,                   // position 4~5  player1_moveroadz[10] ~ [11]

        28.37,                          // position 5~6  player1_moveroadz[12]
        29.37,                          // position 6~7  player1_moveroadz[13]
        30.91, 28.48, 29.53, 25.32,     // position 7~8  player1_moveroadz[14] ~ [17]
        29.64, 27.58, 14.72,            // position 8~9  player1_moveroadz[18] ~ [20]
        10.15,                          // position 9~10  player1_moveroadz[21]

        7.52, 2.51, 2.34,               // position 10~11  player1_moveroadz[22] ~ [24]
        1.88,                           // position 11~12  player1_moveroadz[25]
        -5.92,                          // position 12~13  player1_moveroadz[26]
        -11.08,                         // position 13~14  player1_moveroadz[27]
        -13.75, -15.87, -17.39, -21.11, // position 14~15  player1_moveroadz[28] ~ [31]

        -23.36, -18.14, -14.13, -14.01, -17.34, -20.3,      // position 15~16  player1_moveroadz[32] ~ [37]
        -19.27,                                             // position 16~17  player1_moveroadz[38]
        -19.44, -21.5,                                      // position 17~18  player1_moveroadz[39] ~ [40]
        -21.8, -13.6,                                       // position 18~19  player1_moveroadz[41] ~ [42]
        -14,                                                // position 19~20  player1_moveroadz[43]

        -12.68,                                             // position 20~21  player1_moveroadz[44]
        -9.68, -7.1, -5.96,                                 // position 21~22  player1_moveroadz[45] ~ [47]
        -5.26, -2.41,                                       // position 22~23  player1_moveroadz[48] ~ [49]
        -1.95,                                              // position 23~24  player1_moveroadz[50]
        -1.61,                                              // position 24~25  player1_moveroadz[51]

        -3.33, 0.4, 4.47                                    // position 25~0  player1_moveroadz[52] ~ [54]
    };

    double[] player2_moveroadx = new double[]
    {
        -10.86, -11.27, -14.23, -16.39,                     // position 0~1  player2_moveroadx[0] ~ [3]
        -15.98,                                             // position 1~2  player2_moveroadx[4]
        -7.03, -7, -10.17,                                  // position 2~3  player2_moveroadx[5] ~ [7]
        -16.74, -17.93,                                     // position 3~4  player2_moveroadx[8] ~ [9]
        -14.75, -15.29,                                     // position 4~5  player2_moveroadx[10] ~ [11]

        -15.09,                                             // position 5~6  player2_moveroadx[12]
        -13.11,                                             // position 6~7  player2_moveroadx[13]
        -9.61, -6.92, -5.51, 9.1,                           // position 7~8  player2_moveroadx[14] ~ [17]
        16.02, 22.2, 16.48,                                 // position 8~9  player2_moveroadx[18] ~ [20]
        26.48,                                              // position 9~10  player2_moveroadx[21]

        32.25, 29.94, 23.67,                                // position 10~11  player2_moveroadx[22] ~ [24]
        8.41,                                               // position 11~12  player2_moveroadx[25]
        8.29,                                               // position 12~13  player2_moveroadx[26]
        8.26,                                               // position 13~14  player2_moveroadx[27]
        8.66, 29.32, 31.67, 21.94,                          // position 14~15  player2_moveroadx[28] ~ [31]

        11.9, 7.93, 7.74, 3.57, 3.44, -1.01,                // position 15~16  player2_moveroadx[32] ~ [37]
        -9.77,                                              // position 16~17  player2_moveroadx[38]
        -20.17, -19.78,                                     // position 17~18  player2_moveroadx[39] ~ [40]
        -25.96, -25.84,                                     // position 18~19  player2_moveroadx[41] ~ [42]
        -15.85,                                             // position 19~20  player2_moveroadx[43]
            
        -11.43,                                             // position 20~21  player2_moveroadx[44]
        -8.6, -8.59, -19.76,                                // position 21~22  player2_moveroadx[45] ~ [47]
        -29.34, -28.76,                                     // position 22~23  player2_moveroadx[48] ~ [49]
        -18.33,                                             // position 23~24  player2_moveroadx[50]
        -16.03,                                             // position 24~25  player2_moveroadx[51]

        -0.97, 2.67, 3.27                                   // position 25~0  player2_moveroadx[52] ~ [54]
    };
    double[] player2_moveroadz = new double[]
    {
        4.2, 5.93, 5.09, 8.27,                              // position 0~1  player2_moveroadz[0] ~ [3]
        12.73,                                              // position 1~2  player2_moveroadz[4]
        16.39, 21.71, 22.13,                                // position 2~3  player2_moveroadz[5] ~ [7]
        18.8, 22.82,                                        // position 3~4  player2_moveroadz[8] ~ [9]
        23.69, 25.59,                                       // position 4~5  player2_moveroadz[10] ~ [11]

        28.28,                                              // position 5~6  player2_moveroadz[12]
        28.88,                                              // position 6~7  player2_moveroadz[13]
        30.96, 28.49, 29.37, 26.22,                         // position 7~8  player2_moveroadz[14] ~ [17]
        29.4, 27.78, 14.75,                                 // position 8~9  player2_moveroadz[18] ~ [20]
        9.99,                                               // position 9~10  player2_moveroadz[21]

        7.48, 2.44, 2.13,                                   // position 10~11  player2_moveroadz[22] ~ [24]
        1.79,                                               // position 11~12  player2_moveroadz[25]
        -6.36,                                              // position 12~13  player2_moveroadz[26]
        -10.39,                                             // position 13~14  player2_moveroadz[27]
        -13.83, -16.48, -17.55, -20.81,                     // position 14~15  player2_moveroadz[28] ~ [31]

        -23.21, -18.01, -14.07, -14.46, -17.35, -19.54,     // position 15~16  player2_moveroadz[32] ~ [37]
        -19.28,                                             // position 16~17  player2_moveroadz[38]
        -19.43, -21.85,                                     // position 17~18  player2_moveroadz[39] ~ [40]
        -22.16, -14,                                        // position 18~19  player2_moveroadz[41] ~ [42]
        -13.97,                                             // position 19~20  player1_moveroadz[43]

        -12.55,                                             // position 20~21  player2_moveroadz[44]
        -9.73, -7.44, -6.02,                                // position 21~22  player2_moveroadz[45] ~ [47]
        -5.21, -3.28,                                       // position 22~23  player2_moveroadz[48] ~ [49]
        -2.35,                                              // position 23~24  player2_moveroadz[50]
        -2.01,                                              // position 24~25  player2_moveroadz[51]

        -3.41, 0.22, 4.56                                   // position 25~0  player2_moveroadz[52] ~ [54]
    };

    public void Awake()
    {
        score = 0;
        money = 100;
    }
    public void move(int locate, int player)
    {
        if (player == 1)
        {
            transform.position = new Vector3((float)player1_posx[locate], transform.position.y, (float)player1_posz[locate]);
            maincamera.transform.position = new Vector3((float)player1_posx[locate], maincamera.transform.position.y, (float)player1_posz[locate]);

        }
        else
        {
            transform.position = new Vector3((float)player2_posx[locate], transform.position.y, (float)player2_posz[locate]);
            maincamera.transform.position = new Vector3((float)player2_posx[locate], maincamera.transform.position.y, (float)player2_posz[locate]);
        }
    }

    public void buySomething(int cost)
    {
        money -= cost;
    }
    public void addmoney()
    {
        money += 15;
    }
    public void addScore(int addscore)
    {
        score += addscore;
    }
    public int getMoney()
    {
        return money;
    }
    public int getscore()
    {
        return score;
    }
}

