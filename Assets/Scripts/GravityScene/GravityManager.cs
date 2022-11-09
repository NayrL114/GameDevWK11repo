using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour {
    public enum GravityDirection { Up, Down, Left, Right }
    public static Vector3[] GravityVectors;


    void Awake () {
        GravityVectors = new Vector3[]{ Vector3.up, Vector3.down, Vector3.left, Vector3.right };
	}
}
