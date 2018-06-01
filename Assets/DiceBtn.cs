using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceBtn : MonoBehaviour {

    public Transform dice;
    public Camera camera;

    public void CreateDice()
    {
        Transform t = Instantiate(dice);
        t.position = new Vector3(camera.transform.position.x, camera.transform.position.y - 5, camera.transform.position.z);
    }
}
