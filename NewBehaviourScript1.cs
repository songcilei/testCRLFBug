using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;

public class NewBehaviourScript : EditorWindow
{
    [MenuItem("TA/ss")]
    static void Win()
    {
        var win = EditorWindow.GetWindow<NewBehaviourScript>();
        win.Show();
    }


    private void OnGUI()
    {
        if (GUILayout.Button("11111111"))
        {
            pri();
        }
    }

    // Start is called before the first frame update
    void pri()
    {

        string sd = File.ReadAllText(Application.dataPath+"/CPSInternal.txt");
        //sd.Replace(@"\n",@"\r\n");
       // sd = sd + "\r\n";

        // string ss = "2222222222222222222222222";
        File.WriteAllText("D://1.txt",sd,Encoding.UTF8);
    }

    public static List<string> ReadTxtContents(string Path)
    {
        StreamReader sr = new StreamReader(Path, Encoding.Default);
 
        List<string> contents = new List<string>();
 
        string lineContent = "";
 
        while ((lineContent = sr.ReadLine()) != null)
        {
            contents.Add(lineContent);
        }
 
        sr.Close();
 
        return contents;
    }

}
