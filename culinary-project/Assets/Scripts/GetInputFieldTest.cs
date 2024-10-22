using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GetInputFieldTest : MonoBehaviour
{
    [SerializeField]
    TMP_InputField field;
    [SerializeField]
    TMP_InputField i_flourAmt;
    [SerializeField]
    TMP_InputField i_flourCost;

    [SerializeField]
    TMP_InputField i_saltAmt;
    [SerializeField]
    TMP_InputField i_saltCost;

    [SerializeField]
    TMP_InputField i_OilAmt;
    [SerializeField]
    TMP_InputField i_OilCost;

    [SerializeField]
    TMP_InputField i_sugarAmt;
    [SerializeField]
    TMP_InputField i_sugarCost;

    [SerializeField]
    TMP_InputField i_heavyCreamAmt;
    [SerializeField]
    TMP_InputField i_heavyCreamCost;

    [SerializeField]
    TMP_InputField i_eggsAmt;
    [SerializeField]
    TMP_InputField i_eggsCost;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Calculate();
        }
    }
    void Calculate()
    { 
            float flourCost = -1;
            Debug.Log(i_flourAmt.text);
            Debug.Log(float.TryParse(i_flourCost.text, out flourCost));
            float flourAmt = -1;
            Debug.Log(float.TryParse(i_flourAmt.text, out flourAmt));
        

        float saltCost = -1;
        Debug.Log(i_saltAmt.text);
        Debug.Log(float.TryParse(i_saltCost.text, out saltCost));
        float saltAmt = -1;
        Debug.Log(float.TryParse(i_saltAmt.text, out saltAmt));
        

        float OilCost = -1;
        Debug.Log(i_OilAmt.text);
        Debug.Log(float.TryParse(i_OilCost.text, out OilCost));
        float OilAmt = -1;
        Debug.Log(float.TryParse(i_OilAmt.text, out OilAmt));
        

        float sugarCost = -1;
        Debug.Log(i_sugarAmt.text);
        Debug.Log(float.TryParse(i_sugarCost.text, out sugarCost));
        float sugarAmt = -1;
        Debug.Log(float.TryParse(i_sugarAmt.text, out sugarAmt));
        

        float heavyCreamCost = -1;
        Debug.Log(i_heavyCreamAmt.text);
        Debug.Log(float.TryParse(i_heavyCreamCost.text, out heavyCreamCost));
        float heavyCreamAmt = -1;
        Debug.Log(float.TryParse(i_sugarAmt.text, out heavyCreamAmt));
        Debug.Log(heavyCreamAmt * heavyCreamCost * sugarAmt * sugarCost + OilAmt * OilCost + saltAmt * saltCost + flourAmt * flourCost);
    }
}