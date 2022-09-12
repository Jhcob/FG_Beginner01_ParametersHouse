using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ReSharper disable InconsistentNaming 

public class Room : MonoBehaviour
{
    private float area;
    private string functionality;
    private int amountOfWindows;
    private int amountOfDoors;
    private bool hasAirConditioning;

    public float GetArea()
    {
        return area;
    }
    public void ModifyArea(float newArea)
    {
        area = newArea;
    }
    
    private string GetFunctionality()
    {
        return functionality;
    }
    public void  ModifyFunctionality(string newFunctionality)
    {
        functionality = newFunctionality;
    }
    public int GetAmountOfWindows()
    {
        amountOfWindows = 1;
        return amountOfWindows;
    }
    public void ModifyAmountOfWindows(int NewAmountOfWindows)
    {
        amountOfWindows = NewAmountOfWindows;
    }
    
    public int GetAmountOfDoors()
    {
        amountOfDoors = 1;
        return amountOfDoors;
    }
    public void ModifyAmountOfDoors(int NewAmountOfDoors)
    {
        amountOfDoors = NewAmountOfDoors;
    }
    
    public bool GetHasAirConditioning()
    {
        return hasAirConditioning;
    }
    public void ModifyHasAirConditioning(bool NewHasAirConditioning)
    {
        hasAirConditioning = NewHasAirConditioning;
    }
}
