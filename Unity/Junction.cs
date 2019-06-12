using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Diagnostics;
using System.IO;
using Debug = UnityEngine.Debug;
using System;

public class Junction : Editor
{

    private static List<string> originPath = new List<string>();
    private static List<string> targetPath = new List<string>();

    private static string tip;

    [MenuItem("Tools/Junction")]
    public static void DirectoryJunction()
    {
        bool windows = true;
        string configPath = "./Junction/";
        if (Application.platform == RuntimePlatform.OSXEditor)
        {
            configPath += "MacDirectories.txt";
            windows = false;
        }
        else
        {
            configPath += "WindowsDirectories.txt";
        }

        using(FileStream stream = new FileStream(configPath, FileMode.Open, FileAccess.Read))
        {
            StreamReader reader = new StreamReader(stream);
            string path;
            int index = 1;
            while((path = reader.ReadLine()) != null)
            {
                bool isNull = string.IsNullOrEmpty(path);
                if (index == 1 && !isNull)
                {
                    originPath.Add(path);
                }else if (index == 2)
                {
                    targetPath.Add(path);
                    //超过两行连续换行，判定为乱敲的换行，以下都不计入链接
                    if (isNull)
                        break;
                }
                else
                {
                    if (!isNull)
                    {
                        Debug.LogError("检测到第三行分隔符不存在！");
                        return;
                    }
                }
                //第一行为源路径，第二行为目标路径，第三行为分割行
                index++;
                index %= 3;
            }

            if(index == 1 || originPath.Count != targetPath.Count)
            {
                Debug.LogError("检测到存在不成对的路径！");
                return;
            }

        }

        tip = "";
        if(windows)
        {
            WindowsJunction();
        }
        else
        {
            MacJunction();
        }

        Debug.LogError(tip);
    }

    private static void WindowsJunction()
    {
        bool canJunction = true;
        foreach (var p in targetPath)
        {
            if (Directory.Exists(p))
            {
                tip += p + "\n";
                canJunction = false;
            }
            if (!canJunction)
            {
                tip += "以上目录已存在，请删除后进行链接操作";
            }
        }

        if (!canJunction) return;
        
        string title = "rem mklink";
        string cmd = "mklink /j \"{0}\" \"{1}\"";
        string deleteStr = @"del /f /s /q .\tmpJunction.bat";

        Dictionary<string, string> paths = new Dictionary<string, string>();
        for (int i = 0; i < targetPath.Count; i++)
        {
            paths.Add(originPath[i], targetPath[i]);
        }

        string dir = @".\";
        string fileName = "tmpJunction.bat";
        string tmpPath = dir + fileName;

        using (FileStream stream = new FileStream(tmpPath, FileMode.Append, FileAccess.Write))
        {
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(title);

            foreach (var item in paths)
            {
                string context = string.Format(cmd, item.Value, item.Key);
                writer.WriteLine(context);
            }

            writer.WriteLine(deleteStr);
            writer.Flush();
        }
        //保存日志
        string saveTxt = @".\Junction\WindowsHistroyJunction.txt";
        string saveTemplete = "链接起点:{0}    链接终点:{1}    链接时间:{2}";
        using (FileStream stream = new FileStream(saveTxt, FileMode.Append, FileAccess.Write))
        {
            StreamWriter writer = new StreamWriter(stream);

            foreach (var item in paths)
            {
                string context = string.Format(saveTemplete, item.Value, item.Key, DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss"));
                writer.WriteLine(context);
            }
            writer.WriteLine(" ");
            writer.Flush();
        }
        
        Process process = new Process();
        process.StartInfo.WorkingDirectory = dir;
        process.StartInfo.FileName = fileName;
        process.StartInfo.UseShellExecute = true;
        process.Start();

        tip = "windows目录链接成功！";
    }

    private static void MacJunction()
    {
        bool canJunction = true;
        foreach (var p in targetPath)
        {
            if (Directory.Exists(p))
            {
                tip += p + "\n";
                canJunction = false;
            }
            if (!canJunction)
            {
                tip += "以上目录已存在，请删除后进行链接操作";
            }
        }

        if (!canJunction) return;

        string cmd = "ln -s {0} {1}";
        string deleteStr = @"rm -f .\tmpJunction.command";

        Dictionary<string, string> paths = new Dictionary<string, string>();
        for (int i = 0; i < targetPath.Count; i++)
        {
            paths.Add(originPath[i], targetPath[i]);
        }

        string dir = @".\";
        string fileName = "tmpJunction.command";
        string tmpPath = dir + fileName;

        using (FileStream stream = new FileStream(tmpPath, FileMode.Append, FileAccess.Write))
        {
            StreamWriter writer = new StreamWriter(stream);

            foreach (var item in paths)
            {
                string context = string.Format(cmd, item.Value, item.Key);
                writer.WriteLine(context);
            }

            writer.WriteLine(deleteStr);
            writer.Flush();
        }
        //保存日志
        string saveTxt = @".\Junction\WindowsHistroyJunction.txt";
        string saveTemplete = "链接起点:{0}    链接终点:{1}    链接时间:{2}";
        using (FileStream stream = new FileStream(saveTxt, FileMode.Append, FileAccess.Write))
        {
            StreamWriter writer = new StreamWriter(stream);

            foreach (var item in paths)
            {
                string context = string.Format(saveTemplete, item.Value, item.Key, DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss"));
                writer.WriteLine(context);
            }
            writer.WriteLine(" ");
            writer.Flush();
        }

        Process process = new Process();
        process.StartInfo.WorkingDirectory = dir;
        process.StartInfo.FileName = fileName;
        process.StartInfo.UseShellExecute = true;
        process.Start();

        tip = "MacOS目录链接成功！";
    }
}
