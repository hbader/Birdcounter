using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCounter : MonoBehaviour
{
    private int totalCount;
    private int chickCount;
    private int owlCount;
    private int eagCount;

    private void Start()
    {
        chickCount = 0; owlCount = 0; eagCount = 0;
    }

    private void Update()
    {
        
    }

    public void increaseChick()
    {
        chickCount++;
    }

    public void increaseEag()
    {
        eagCount++;
    }

    public void increaseOwl()
    {
        owlCount++;
    }
    public int getChickCount()
    {
        return chickCount;
    }

    public int getOwlCount()
    {
        return owlCount;
    }

    public int getEagCount()
    {
        return eagCount;
    }

    public int getTotalCount()
    {
        return eagCount + owlCount + chickCount;
    }
}
