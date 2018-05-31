using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleConfig2D : MonoBehaviour {

    public GameObject UpperBound;
    public GameObject UpperMiddleBound;
    public GameObject MiddleBound;
    public GameObject LowerMiddleBound;
    public GameObject LowerBound;
    public GameObject Title;


    public void SetScaleValues(float maxStress, float minStress)
    {
        //float conversion = (float)1e09;
        float toMPA = (float)1e06;
    
        float maxStressCon = maxStress / toMPA;
        float minStressCon = minStress / toMPA;

        float range = maxStressCon - minStressCon;

        float UBound = (maxStressCon);
        float UMBound = (float)(minStressCon + (0.75 * range));
        float MBound = (float)(minStressCon + (0.5 * range));
        float LMBound = (float)(minStressCon + (0.25 * range));
        float LBound = (minStressCon);
       
        String UBoundStr = String.Format("{0:N3}", UBound);
        String UMBoundStr = String.Format("{0:N3}", UMBound);
        String MBoundStr = String.Format("{0:N3}", MBound);
        String LMBoundStr = String.Format("{0:N3}", LMBound);
        String LBoundStr = String.Format("{0:N3}", LBound);

        UpperBound.GetComponent<TextMesh>().text = ("- " + UBoundStr);
        UpperMiddleBound.GetComponent<TextMesh>().text = ("- " + UMBoundStr);
        MiddleBound.GetComponent<TextMesh>().text = ("- " + MBoundStr); 
        LowerMiddleBound.GetComponent<TextMesh>().text = ("- " + LMBoundStr);
        LowerBound.GetComponent<TextMesh>().text = ("- " +LBoundStr);

        Title.GetComponent<TextMesh>().text = ("Stress (MPa)");
    }
}
