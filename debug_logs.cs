using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

public class test1 : MonoBehaviour
{

    // Variables goes here
    private string info = "Game Over";
    private float anum = 42;



    // GUI Text
    private string Text1;
    private string Text2;
    private string TextPos;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world");
        Debug.Log("info string contains: " + info);

        float res = 20 + anum;
        Debug.Log("res contins: " + res);

        Text1 = "Hello World";
        Text2 = "info string contins: " + info;



    }

    // Update is called once per frame
    void Update()
    {

        // Getting the position of the game object
        TextPos = "My Position: " + transform.position.ToString();
    }



    // Output text to GUI
    private void OnGUI()
    {
        GUI.color = Color.green;
        GUI.Label(new Rect(10, 10, Screen.width, Screen.height), Text1);


        GUI.color = Color.red;
        GUI.Label(new Rect(10, 40, Screen.width, Screen.height), Text2);
    }

    // Outputing text on the object
    private void OnDrawGizmos()
    {
        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.blue;
        Handles.Label(transform.position + Vector3.up * 1, TextPos, style);
    }

}
