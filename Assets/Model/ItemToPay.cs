using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemToPay : MonoBehaviour {

    public string ItemName { get; set; }
    public int Price { get; set; }
    public Expense OriginalExpense { get; set; }
    public Person WhoPaid { get; set; }
    public Person WhoConsumedItem { get; set; }

    public ItemToPay(string name, int price, Person whoPaid, Person whoConsumedItem)
    {
        ItemName = name;
        Price = price;

        whoPaid.UpdateOwesPerson(whoConsumedItem, -price);
        whoConsumedItem.UpdateOwesPerson(whoPaid, price);

        WhoPaid = whoPaid;
        WhoConsumedItem = whoConsumedItem;
    }



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
