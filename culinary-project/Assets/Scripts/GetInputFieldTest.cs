using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GetInputFieldTest : MonoBehaviour
{
    
    public TextMeshProUGUI MyText;

    [SerializeField]
    TMP_InputField field;
    [SerializeField]
    TMP_InputField i_flourAmt;
    [SerializeField]
    TMP_InputField i_flourCost;
    [SerializeField]
    TMP_InputField i_flourProduct;

    [SerializeField]
    TMP_InputField i_saltAmt;
    [SerializeField]
    TMP_InputField i_saltCost;
    [SerializeField]
    TMP_InputField i_saltProduct;

    [SerializeField]
    TMP_InputField i_OilAmt;
    [SerializeField]
    TMP_InputField i_OilCost;
    [SerializeField]
    TMP_InputField i_oilProduct;

    [SerializeField]
    TMP_InputField i_sugarAmt;
    [SerializeField]
    TMP_InputField i_sugarCost;
    [SerializeField]
    TMP_InputField i_sugarProduct;

    [SerializeField]
    TMP_InputField i_MilkAmt;
    [SerializeField]
    TMP_InputField i_MilkCost;
    [SerializeField]
    TMP_InputField i_MilkProduct;

    [SerializeField]
    TMP_InputField i_heavyCreamAmt;
    [SerializeField]
    TMP_InputField i_heavyCreamCost;
    [SerializeField]
    TMP_InputField i_heavyCreamProduct;

    [SerializeField]
    TMP_InputField i_eggsAmt;
    [SerializeField]
    TMP_InputField i_eggsCost;
    [SerializeField]
    TMP_InputField i_eggsProduct;

    [SerializeField]
    TMP_InputField i_yeastAmt;
    [SerializeField]
    TMP_InputField i_yeastCost;
    [SerializeField]
    TMP_InputField i_yeastProduct;

    [SerializeField]
    TMP_InputField i_BakingPowderAmt;
    [SerializeField]
    TMP_InputField i_BakingPowderCost;
    [SerializeField]
    TMP_InputField i_BakingPowderProduct;

    [SerializeField]
    TMP_InputField i_butterAmt;
    [SerializeField]
    TMP_InputField i_butterCost;
    [SerializeField]
    TMP_InputField i_butterProduct;

    [SerializeField]
    TMP_InputField i_BakingSodaAmt;
    [SerializeField]
    TMP_InputField i_BakingSodaCost;
    [SerializeField]
    TMP_InputField i_BakingSodaProduct;

    [SerializeField]
    TMP_InputField i_potatoesAmt;
    [SerializeField]
    TMP_InputField i_potatoesCost;
    [SerializeField]
    TMP_InputField i_potatoesProduct;

    [SerializeField]
    TMP_InputField i_carrotsAmt;
    [SerializeField]
    TMP_InputField i_carrotsCost;
    [SerializeField]
    TMP_InputField i_carrotsProduct;

    [SerializeField]
    TMP_InputField i_MarkUp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyText.text = "";
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
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
        float flourProduct = -1;
        Debug.Log(float.TryParse(i_flourProduct.text, out flourProduct));

        float saltCost = -1;
        Debug.Log(i_saltAmt.text);
        Debug.Log(float.TryParse(i_saltCost.text, out saltCost));
        float saltAmt = -1;
        Debug.Log(float.TryParse(i_saltAmt.text, out saltAmt));
        float saltProduct = -1;
        Debug.Log(float.TryParse(i_saltProduct.text, out saltProduct));

        float OilCost = -1;
        Debug.Log(i_OilAmt.text);
        Debug.Log(float.TryParse(i_OilCost.text, out OilCost));
        float OilAmt = -1;
        Debug.Log(float.TryParse(i_OilAmt.text, out OilAmt));
        float oilProduct = -1;
        Debug.Log(float.TryParse(i_oilProduct.text, out oilProduct));

        float sugarCost = -1;
        Debug.Log(i_sugarAmt.text);
        Debug.Log(float.TryParse(i_sugarCost.text, out sugarCost));
        float sugarAmt = -1;
        Debug.Log(float.TryParse(i_sugarAmt.text, out sugarAmt));
        float sugarProduct = -1;
        Debug.Log(float.TryParse(i_sugarProduct.text, out sugarProduct));

        float MilkCost = -1;
        Debug.Log(i_MilkAmt.text);
        Debug.Log(float.TryParse(i_MilkCost.text, out MilkCost));
        float MilkAmt = -1;
        Debug.Log(float.TryParse(i_MilkAmt.text, out MilkAmt));
        float MilkProduct = -1;
        Debug.Log(float.TryParse(i_MilkProduct.text, out MilkProduct));

        float heavyCreamCost = -1;
        Debug.Log(i_heavyCreamAmt.text);
        Debug.Log(float.TryParse(i_heavyCreamCost.text, out heavyCreamCost));
        float heavyCreamAmt = -1;
        Debug.Log(float.TryParse(i_heavyCreamAmt.text, out heavyCreamAmt));
        float heavyCreamProduct = -1;
        Debug.Log(float.TryParse(i_heavyCreamProduct.text, out heavyCreamProduct));

        float eggsCost = -1;
        Debug.Log(i_eggsAmt.text);
        Debug.Log(float.TryParse(i_eggsCost.text, out eggsCost));
        float eggsAmt = -1;
        Debug.Log(float.TryParse(i_eggsAmt.text, out eggsAmt));
        float eggsProduct = -1;
        Debug.Log(float.TryParse(i_eggsProduct.text, out eggsProduct));

        float yeastCost = -1;
        Debug.Log(i_yeastAmt.text);
        Debug.Log(float.TryParse(i_yeastCost.text, out yeastCost));
        float yeastAmt = -1;
        Debug.Log(float.TryParse(i_yeastAmt.text, out yeastAmt));
        float yeastProduct = -1;
        Debug.Log(float.TryParse(i_yeastProduct.text, out yeastProduct));

        float BakingPowderCost = -1;
        Debug.Log(i_BakingPowderAmt.text);
        Debug.Log(float.TryParse(i_BakingPowderCost.text, out BakingPowderCost));
        float BakingPowderAmt = -1;
        Debug.Log(float.TryParse(i_BakingPowderAmt.text, out BakingPowderAmt));
        float BakingPowderProduct = -1;
        Debug.Log(float.TryParse(i_BakingPowderProduct.text, out BakingPowderProduct));

        float butterCost = -1;
        Debug.Log(i_butterAmt.text);
        Debug.Log(float.TryParse(i_butterCost.text, out butterCost));
        float butterAmt = -1;
        Debug.Log(float.TryParse(i_butterAmt.text, out butterAmt));
        float butterProduct = -1;
        Debug.Log(float.TryParse(i_butterProduct.text, out butterProduct));

        float BakingSodaCost = -1;
        Debug.Log(i_BakingSodaAmt.text);
        Debug.Log(float.TryParse(i_BakingSodaCost.text, out BakingSodaCost));
        float BakingSodaAmt = -1;
        Debug.Log(float.TryParse(i_BakingSodaAmt.text, out BakingSodaAmt));
        float BakingSodaProduct = -1;
        Debug.Log(float.TryParse(i_BakingSodaProduct.text, out BakingSodaProduct));

        float potatoesCost = -1;
        Debug.Log(i_potatoesAmt.text);
        Debug.Log(float.TryParse(i_potatoesCost.text, out potatoesCost));
        float potatoesAmt = -1;
        Debug.Log(float.TryParse(i_potatoesAmt.text, out potatoesAmt));
        float potatoesProduct = -1;
        Debug.Log(float.TryParse(i_potatoesProduct.text, out potatoesProduct));

        float carrotsCost = -1;
        Debug.Log(i_carrotsAmt.text);
        Debug.Log(float.TryParse(i_carrotsCost.text, out carrotsCost));
        float carrotsAmt = -1;
        Debug.Log(float.TryParse(i_carrotsAmt.text, out carrotsAmt));
        float carrotsProduct = -1;
        Debug.Log(float.TryParse(i_carrotsProduct.text, out carrotsProduct));

        float MarkUp = -1;
        Debug.Log(float.TryParse(i_MarkUp.text, out MarkUp));

        Debug.Log(yeastAmt * yeastCost + eggsAmt * eggsCost + heavyCreamAmt * heavyCreamCost * sugarAmt * sugarCost + OilAmt * OilCost + saltAmt * saltCost + flourAmt * flourCost);
        MyText.text = "$" + ((carrotsAmt * (carrotsCost / carrotsProduct) + potatoesAmt * (potatoesCost / potatoesProduct) + BakingSodaAmt * (BakingSodaCost / BakingSodaProduct) + butterAmt * (butterCost / butterProduct) + BakingPowderAmt * (BakingPowderCost / BakingPowderProduct)+ MilkAmt * (MilkCost / MilkProduct) + yeastAmt * (yeastCost / yeastProduct) + eggsAmt * (eggsCost / eggsProduct)+ heavyCreamAmt * (heavyCreamCost / heavyCreamProduct) + sugarAmt * (sugarCost / sugarProduct)+ OilAmt * (OilCost / oilProduct)+ saltAmt * (saltCost / saltProduct)+ flourAmt * (flourCost / flourProduct)*MarkUp));


    }

}
