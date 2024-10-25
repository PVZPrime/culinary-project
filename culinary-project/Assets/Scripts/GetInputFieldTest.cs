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
    public TextMeshProUGUI MyCost;
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
        MyCost.text = "";
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
        float flourAmt = -1;
        float flourCost = -1;
        float flourProduct = -1;
        Debug.Log(i_flourAmt.text);
        Debug.Log(float.TryParse(i_flourCost.text, out flourCost));
        Debug.Log(float.TryParse(i_flourAmt.text, out flourAmt));
        Debug.Log(float.TryParse(i_flourProduct.text, out flourProduct));
        float flourTotalCost = 0;
        if (flourCost > 0 && flourAmt > 0 && flourProduct > 0)
        {
            flourTotalCost = flourAmt * flourCost / flourProduct;
        }
        
        float saltAmt = -1;
        float saltCost = -1;
        float saltProduct = -1;
        Debug.Log(i_saltAmt.text);
        Debug.Log(float.TryParse(i_saltCost.text, out saltCost));
        Debug.Log(float.TryParse(i_saltAmt.text, out saltAmt));
        Debug.Log(float.TryParse(i_saltProduct.text, out saltProduct));
        float saltTotalCost = 0;
        if (saltCost > 0 && saltAmt > 0 && saltProduct > 0)
        {
            saltTotalCost = saltAmt * saltCost / saltProduct;
        }

        float OilAmt = -1;
        float OilCost = -1;
        float OilProduct = -1;
        Debug.Log(i_OilAmt.text);
        Debug.Log(float.TryParse(i_OilCost.text, out OilCost));
        Debug.Log(float.TryParse(i_OilAmt.text, out OilAmt));
        Debug.Log(float.TryParse(i_oilProduct.text, out OilProduct));
        float OilTotalCost = 0;
        if (OilCost > 0 && OilAmt > 0 && OilProduct > 0)
        {
            OilTotalCost = OilAmt * OilCost / OilProduct;
        }

        float sugarCost = -1;
        float sugarAmt = -1;
        float sugarProduct = -1;
        Debug.Log(i_sugarAmt.text);
        Debug.Log(float.TryParse(i_sugarCost.text, out sugarCost));
        Debug.Log(float.TryParse(i_sugarAmt.text, out sugarAmt));
        Debug.Log(float.TryParse(i_sugarProduct.text, out sugarProduct));
        float sugarTotalCost = 0;
        if (sugarCost > 0 && sugarAmt > 0 && sugarProduct > 0)
        {
            sugarTotalCost = sugarAmt * sugarCost / sugarProduct;
        }

        float MilkAmt = -1;
        float MilkCost = -1;
        float MilkProduct = -1;
        Debug.Log(i_MilkAmt.text);
        Debug.Log(float.TryParse(i_MilkCost.text, out MilkCost));
        Debug.Log(float.TryParse(i_MilkAmt.text, out MilkAmt));
        Debug.Log(float.TryParse(i_MilkProduct.text, out MilkProduct));
        float MilkTotalCost = 0;
        if (MilkCost > 0 && MilkAmt > 0 && MilkProduct > 0)
        {
            MilkTotalCost = MilkAmt * MilkCost / MilkProduct;
        }

        float heavyCreamAmt = -1;
        float heavyCreamCost = -1;
        float heavyCreamProduct = -1;
        Debug.Log(i_heavyCreamAmt.text);
        Debug.Log(float.TryParse(i_heavyCreamCost.text, out heavyCreamCost));
        Debug.Log(float.TryParse(i_heavyCreamAmt.text, out heavyCreamAmt));
        Debug.Log(float.TryParse(i_heavyCreamProduct.text, out heavyCreamProduct));
        float heavyCreamTotalCost = 0;
        if (heavyCreamCost > 0 && heavyCreamAmt > 0 && heavyCreamProduct > 0)
        {
            heavyCreamTotalCost = heavyCreamAmt * heavyCreamCost / heavyCreamProduct;
        }

        float eggsAmt = -1;
        float eggsCost = -1;
        float eggsProduct = -1;
        Debug.Log(i_eggsAmt.text);
        Debug.Log(float.TryParse(i_eggsCost.text, out eggsCost));
        Debug.Log(float.TryParse(i_eggsAmt.text, out eggsAmt));
        Debug.Log(float.TryParse(i_eggsProduct.text, out eggsProduct));
        float eggsTotalCost = 0;
        if (eggsCost > 0 && eggsAmt > 0 && eggsProduct > 0)
        {
            eggsTotalCost = eggsAmt * eggsCost / eggsProduct;
        }

        float yeastAmt = -1;
        float yeastCost = -1;
        float yeastProduct = -1;
        Debug.Log(i_yeastAmt.text);
        Debug.Log(float.TryParse(i_yeastCost.text, out yeastCost));
        Debug.Log(float.TryParse(i_yeastAmt.text, out yeastAmt));
        Debug.Log(float.TryParse(i_yeastProduct.text, out yeastProduct));
        float yeastTotalCost = 0;
        if (yeastCost > 0 && yeastAmt > 0 && yeastProduct > 0)
        {
            yeastTotalCost = yeastAmt * yeastCost / yeastProduct;
        }

        float BakingPowderAmt = -1;
        float BakingPowderCost = -1;
        float BakingPowderProduct = -1;
        Debug.Log(i_BakingPowderAmt.text);
        Debug.Log(float.TryParse(i_BakingPowderCost.text, out BakingPowderCost));
        Debug.Log(float.TryParse(i_BakingPowderAmt.text, out BakingPowderAmt));
        Debug.Log(float.TryParse(i_BakingPowderProduct.text, out BakingPowderProduct));
        float BakingPowderTotalCost = 0;
        if (BakingPowderCost > 0 && BakingPowderAmt > 0 && BakingPowderProduct > 0)
        {
            BakingPowderTotalCost = BakingPowderAmt * BakingPowderCost / BakingPowderProduct;
        }

        float butterAmt = -1;
        float butterCost = -1;
        float butterProduct = -1;
        Debug.Log(i_butterAmt.text);
        Debug.Log(float.TryParse(i_butterCost.text, out butterCost));
        Debug.Log(float.TryParse(i_butterAmt.text, out butterAmt));
        Debug.Log(float.TryParse(i_butterProduct.text, out butterProduct));
        float butterTotalCost = 0;
        if (butterCost > 0 && butterAmt > 0 && butterProduct > 0)
        {
            butterTotalCost = butterAmt * butterCost / butterProduct;
        }

        float BakingSodaAmt = -1;
        float BakingSodaCost = -1;
        float BakingSodaProduct = -1;
        Debug.Log(i_BakingSodaAmt.text);
        Debug.Log(float.TryParse(i_BakingSodaCost.text, out BakingSodaCost));
        Debug.Log(float.TryParse(i_BakingSodaAmt.text, out BakingSodaAmt));
        Debug.Log(float.TryParse(i_BakingSodaProduct.text, out BakingSodaProduct));
        float BakingSodaTotalCost = 0;
        if (BakingSodaCost > 0 && BakingSodaAmt > 0 && BakingSodaProduct > 0)
        {
            BakingSodaTotalCost = BakingSodaAmt * BakingSodaCost / BakingSodaProduct;
        }

        float potatoesAmt = -1;
        float potatoesCost = -1;
        float potatoesProduct = -1;
        Debug.Log(i_potatoesAmt.text);
        Debug.Log(float.TryParse(i_potatoesCost.text, out potatoesCost));
        Debug.Log(float.TryParse(i_potatoesAmt.text, out potatoesAmt));
        Debug.Log(float.TryParse(i_potatoesProduct.text, out potatoesProduct));
        float potatoesTotalCost = 0;
        if (potatoesCost > 0 && potatoesAmt > 0 && potatoesProduct > 0)
        {
            potatoesTotalCost = potatoesAmt * potatoesCost / potatoesProduct;
        }

        float carrotsAmt = -1;
        float carrotsCost = -1;
        float carrotsProduct = -1;
        Debug.Log(i_carrotsAmt.text);
        Debug.Log(float.TryParse(i_carrotsCost.text, out carrotsCost));
        Debug.Log(float.TryParse(i_carrotsAmt.text, out carrotsAmt));
        Debug.Log(float.TryParse(i_carrotsProduct.text, out carrotsProduct));
        float carrotsTotalCost = 0;
        if (carrotsCost > 0 && carrotsAmt > 0 && carrotsProduct > 0)
        {
            carrotsTotalCost = carrotsAmt * carrotsCost / carrotsProduct;
        }

        float MarkUp = -1;
        Debug.Log(float.TryParse(i_MarkUp.text, out MarkUp));

        

        Debug.Log(yeastAmt * yeastCost + eggsAmt * eggsCost + heavyCreamAmt * heavyCreamCost * sugarAmt * sugarCost + OilAmt * OilCost + saltAmt * saltCost + flourAmt * flourCost);
        MyText.text = "$" + ((MarkUp)*(flourTotalCost + yeastTotalCost + saltTotalCost + heavyCreamTotalCost + sugarTotalCost + BakingPowderTotalCost + BakingSodaTotalCost + MilkTotalCost + potatoesTotalCost + carrotsTotalCost + OilTotalCost + butterTotalCost + eggsTotalCost));
        MyCost.text = "$" + ((flourCost +yeastCost + saltCost + heavyCreamCost + sugarCost + BakingPowderCost + BakingSodaCost + MilkCost + potatoesCost + carrotsCost + OilCost + butterCost + eggsCost));

    }

}
