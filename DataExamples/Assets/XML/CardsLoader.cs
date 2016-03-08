using UnityEngine;
using System.IO;
using System;

public class CardsLoader : MonoBehaviour {

    public const string path = "XML/Cards.xml";

	// Use this for initialization
	void Start () {
        DateTime currentDate = DateTime.Now;

        long elapsedTicks = currentDate.Ticks;
        TimeSpan elapsedSpanStart = new TimeSpan(elapsedTicks);

        Debug.Log("First time " + elapsedSpanStart.TotalSeconds);

        CardsContainer cardsCollection = CardsContainer.Load(Path.Combine(Application.dataPath, path));

        if (cardsCollection!=null)
        {
            int i = 0;
            foreach (Cards card in cardsCollection.cards)
            {
                Debug.Log(card.name);
                i++;
            }
            Debug.Log(i);
        }
        else
            Debug.Log("result is NULL");

        currentDate = DateTime.Now;
        elapsedTicks = currentDate.Ticks;
        TimeSpan elapsedSpanEnd = new TimeSpan(elapsedTicks);
        Debug.Log("Second time " + elapsedSpanEnd.TotalSeconds);

        Debug.Log("Final time " + (elapsedSpanEnd.TotalSeconds-elapsedSpanStart.TotalSeconds));

    }

    // Update is called once per frame
    void Update () {
	
	}
}
