using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ReSharper disable InconsistentNaming 

public class House : MonoBehaviour
{
    private string address;
    private float averageTemperature;
    private int yearBuilt;
    private int numberInhabitants;
    private bool isLeaseAvailable;
    private Room kitchen;
    private Room livingRoom;
    private Room bedroom;
    private Room bathroom;

    public string GetAddress()
    {
        return address;
    }
    public void ModifyAddress(string newAddress)
    {
        address = newAddress;
    }
    
    public float GetAverageTemperature()
    {
        return averageTemperature;
    }
    public void ModifyAverageTemperature(float newAverageTemperature)
    {
        averageTemperature = newAverageTemperature;
    }
    
    public int GetYearBuilt()
    {
        return yearBuilt;
    }
    public void ModifyYearBuilt(int newYearBuilt)
    {
        yearBuilt = newYearBuilt;
    }
    
    public int GetNumberInhabitants()
    {
        return numberInhabitants;
    }
    public void ModifyNumberInhabitants(int newNumberInhabitants)
    {
        numberInhabitants = newNumberInhabitants;
    }
    
    public bool GetIsLeaseAvailable()
    {
        return isLeaseAvailable;
    }

    public void ModifyLease(bool newIsLeaseAvailable)
    {
        isLeaseAvailable = newIsLeaseAvailable;
    }
}
