using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class data : MonoBehaviour
{
    public TextAsset textFile;
    public int limit;
    public string capital;

    public List<string> tData;

    void Start()
    {
        tData = textFile.text.Split().ToList();

        for (int i = 0; i < tData.Count; i++)
        {
            if (tData[i].StartsWith(capital) && tData[i].Length==limit)
            {
                Debug.Log(tData[i]);
            }

        }
    }
}
