using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdUI : MonoBehaviour
{

    public BirdCounter counter;

    public Text chickText;
    public Text owlText;
    public Text eagText;

    // Update is called once per frame
    void Update()
    {
        chickText.text = counter.getChickCount().ToString();
        owlText.text = counter.getOwlCount().ToString();
        eagText.text = counter.getEagCount().ToString();
    }
}
