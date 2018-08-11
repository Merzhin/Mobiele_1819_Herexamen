using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyConversionRate : MonoBehaviour {

    public double GBP { get; set; }
    public double EUR { get; set; }
    public double AUD { get; set; }
    public double USD { get; set; }
    public double JPY { get; set; }

    public CurrencyConversionRate(double gbp, double eur, double aud, double usd, double jpy)
    {
        GBP = gbp;
        EUR = eur;
        AUD = aud;
        USD = usd;
        JPY = jpy;
    }
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
