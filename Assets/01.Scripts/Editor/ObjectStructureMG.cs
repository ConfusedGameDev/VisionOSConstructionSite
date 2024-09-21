using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class ObjectStructureMG : MonoBehaviour
{
    [MenuItem("VRARRI/Create Project Structure")]
    public static void CreateProjectFolders()
    {
        if(!Directory.Exists("Assets/00.Plugins"))
        {
            Directory.CreateDirectory("Assets/00.Plugins");
        }
        if (!Directory.Exists("Assets/01.Scripts"))
        {
            Directory.CreateDirectory("Assets/01.Scripts");
        }
        if (!Directory.Exists("Assets/01.Plugins"))
        {
            Directory.CreateDirectory("Assets/02.Graphics");
        }
        if (!Directory.Exists("Assets/03.Animations"))
        {
            Directory.CreateDirectory("Assets/03.Animations");
        }
        if (!Directory.Exists("Assets/04.Scenes"))
        {
            Directory.CreateDirectory("Assets/04.Scenes");
        }
        if (!Directory.Exists("Assets/05.Prefabs"))
        {
            Directory.CreateDirectory("Assets/05.Prefabs");
        }
        if (!Directory.Exists("Assets/06.Audio"))
        {
            Directory.CreateDirectory("Assets/06.Audio");
        }
        if (!Directory.Exists("Assets/07.Data"))
        {
            Directory.CreateDirectory("Assets/07.Data");
        }
        if (!Directory.Exists("Assets/08.Timelines"))
        {
            Directory.CreateDirectory("Assets/08.Timelines");
        }
        if (!Directory.Exists("Assets/99.Testing"))
        {
            Directory.CreateDirectory("Assets/99.Testing");
        }
        if (!Directory.Exists("Assets/Resources"))
        {
            Directory.CreateDirectory("Assets/Resources");
        }
        if (!Directory.Exists("Assets/StreamingAssets"))
        {
            Directory.CreateDirectory("Assets/StreamingAssets");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
