using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour {
    public enum GravityDirection { Up, Down, Left, Right }
    public static Vector3[] GravityVectors;

    public static float GravityStrengh = 9.8f;


    void Awake () {
        GravityVectors = new Vector3[]{ Vector3.up, Vector3.down, Vector3.left, Vector3.right };

        //GravityVectors = new Vector3[] { Vector3.up * GravityStrengh, Vector3.down, Vector3.left, Vector3.right };
        //Physics.gravity = GravityVectors[0] * GravityStrengh;
        //Debug.Log((int)GravityDirection.Up);
        Physics.gravity = GravityVectors[(int)GravityDirection.Up] * GravityStrengh;
    }
}
