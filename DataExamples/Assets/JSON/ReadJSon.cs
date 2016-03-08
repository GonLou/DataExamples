using UnityEngine;
using System.Collections;
using System.IO;
using System;
using LitJson;

public class ReadJSon : MonoBehaviour {
    private string jsonString;
    private JsonData itemData;

	// Use this for initialization
	void Start () {
        DateTime currentDate = DateTime.Now;

        long elapsedTicks = currentDate.Ticks;
        TimeSpan elapsedSpanStart = new TimeSpan(elapsedTicks);

        Debug.Log("First time " + elapsedSpanStart.TotalSeconds);

        jsonString = File.ReadAllText(Application.dataPath + "/JSON/Cards.json");
        //Debug.Log(jsonString);
        itemData = JsonMapper.ToObject(jsonString);

        //Debug.Log(itemData["Cards"][1]["Unit"]);
        for (int i = 0; i < itemData["Cards"].Count; i++)
        {
            Debug.Log(itemData["Cards"][i]["Unit"].ToString());
        }
        Debug.Log(itemData["Cards"].Count);

        currentDate = DateTime.Now;
        elapsedTicks = currentDate.Ticks;
        TimeSpan elapsedSpanEnd = new TimeSpan(elapsedTicks);
        Debug.Log("Second time " + elapsedSpanEnd.TotalSeconds);

        Debug.Log("Final time " + (elapsedSpanEnd.TotalSeconds - elapsedSpanStart.TotalSeconds));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
