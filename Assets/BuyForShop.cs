using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static GooglePlayGames.BasicApi.Nearby.ConnectionResponse;

public class BuyForShop : MonoBehaviour
{
    public SpriteRenderer topSprite;
    public bool footballisbuy;
    public bool aquaballisbuy;
    public bool tomatoballisbuy;
    public bool lemonballisbuy;
    public TextMeshProUGUI FootballText;
    public TextMeshProUGUI AquaBallText;
    public TextMeshProUGUI TomatoballText;
    public TextMeshProUGUI LemonballText;
    public TextMeshProUGUI FirstBall;
    private void Start()
    {
#if UNITY_IPHONE

        RestoreButton.gameObject.SetActive(true);


#endif
        //initialize the EasyIAP plugin at the very beggining of your app
        IAPManager.Instance.InitializeIAPManager(InitializeResultCallback);
        check();
    }
    public void Football()
    {

        IAPManager.Instance.BuyProduct(ShopProductNames.football, ProductBoughtCallback);

    }

    public void AquaBall()
    {
        IAPManager.Instance.BuyProduct(ShopProductNames.aquaball, ProductBoughtCallback);


    }
    public void TomatoBall()
    {
        IAPManager.Instance.BuyProduct(ShopProductNames.tomatoball, ProductBoughtCallback);


    }
    public void LemonBall()
    {
        IAPManager.Instance.BuyProduct(ShopProductNames.lemonball, ProductBoughtCallback);


    }
    
    private void ProductBoughtCallback(IAPOperationStatus status, string message, StoreProduct
product)
    {
        if (status == IAPOperationStatus.Success)
        {
            //each consumable gives coins in this example

            //non consumable Unlock Level 1 -> unlocks level 1 so we set the corresponding bool to true
            if (product.productName == "football")
            {
                PlayerPrefs.SetString("AktifBall", "Ball2");
                PlayerPrefs.SetString("FootballisBuy", "Ball2");
                var sprite = Resources.Load<Sprite>("Ball 2/football");
                check();
                topSprite.sprite = sprite;
            }
            if (product.productName == "aquaball")
            {

                PlayerPrefs.SetString("AktifBall", "Ball3");
                PlayerPrefs.SetString("AquaballisBuy", "Ball3");
                var sprite = Resources.Load<Sprite>("Ball 3/aqua");
                check();
                topSprite.sprite = sprite;
            }
            if (product.productName == "tomatoball")
            {
                PlayerPrefs.SetString("AktifBall", "Ball4");
                PlayerPrefs.SetString("TomatoballlisBuy", "Ball4");
                var sprite = Resources.Load<Sprite>("Ball 4/tomato");
                check();
                topSprite.sprite = sprite;
            }
            if (product.productName == "lemonball")
            {
                PlayerPrefs.SetString("AktifBall", "Ball5");
                PlayerPrefs.SetString("LemonballisBuy", "Ball5");
                var sprite = Resources.Load<Sprite>("Ball 5/lemon");
                check();
                topSprite.sprite = sprite;
            }

        }
        else
        {
            //an error occurred in the buy process, log the message for more details
            Debug.Log("Buy product failed: " + message);
        }
    }
    public void Restore()
    {

        IAPManager.Instance.RestorePurchases(ProductRestoredCallback);

    }
    private void ProductRestoredCallback(IAPOperationStatus status, string message, StoreProduct product)
    {
        if (status == IAPOperationStatus.Success)
        {

            //each consumable gives coins in this example

            //non consumable Unlock Level 1 -> unlocks level 1 so we set the corresponding bool to true
            if (product.productName == "football")
            {
                PlayerPrefs.SetString("AktifBall", "Ball2");
                var sprite = Resources.Load<Sprite>("Ball 2/football");
                topSprite.sprite = sprite;
                check();
            }
            if (product.productName == "aquaball")
            {

                PlayerPrefs.SetString("AktifBall", "Ball3");
                var sprite = Resources.Load<Sprite>("Ball 3/aqua");
                topSprite.sprite = sprite;
                check();
            }
            if (product.productName == "tomatoball")
            {
                PlayerPrefs.SetString("AktifBall", "Ball4");
                var sprite = Resources.Load<Sprite>("Ball 4/tomato");
                topSprite.sprite = sprite;
                check();
            }
            if (product.productName == "lemonball")
            {
                PlayerPrefs.SetString("AktifBall", "Ball5");
                var sprite = Resources.Load<Sprite>("Ball 5/lemon");
                topSprite.sprite = sprite;
                check();
            }
        }
        else
        {
            //an error occurred in the buy process, log the message for more details
            Debug.Log("Buy product failed: " + message);
        }
    }
    private void InitializeResultCallback(IAPOperationStatus status, string message, List<StoreProduct>
shopProducts)
    {
        if (status == IAPOperationStatus.Success)
        {
            //IAP was successfully initialized
            //loop through all products
            for (int i = 0; i < shopProducts.Count; i++)
            {
                if (shopProducts[i].productName == "BinCoins")
                {
                    //if active variable is true, means that user had bought that product
                    //so enable access
                    if (shopProducts[i].active)
                    {
                        Debug.Log("Var");
                    }
                }
            }
        }
    }
    public void FirstBalls()
    {
        PlayerPrefs.SetString("AktifBall", "FirstBall");
        var sprite = Resources.Load<Sprite>("Ball First/orange");
        topSprite.sprite = sprite;
        FirstBall.text = "Selected";
        if (aquaballisbuy == true)
        {
            AquaBallText.text = "Select";
        }
        if (tomatoballisbuy == true)
        {
            TomatoballText.text = "Select";
        }
        if (lemonballisbuy == true)
        {
            LemonballText.text = "Select";
        }
        if (footballisbuy == true)
        {
           FootballText.text = "Select";
        }
        check();
    }
    public void check()
    {
        if (PlayerPrefs.HasKey("FootballisBuy"))
        {
            footballisbuy = true;
        }
        if (PlayerPrefs.HasKey("AquaballisBuy"))
        {
            aquaballisbuy = true;
        }
        if (PlayerPrefs.HasKey("TomatoballlisBuy"))
        {
            tomatoballisbuy = true;
        }
        if (PlayerPrefs.HasKey("LemonballisBuy"))
        {
            lemonballisbuy = true;
        }
        if (PlayerPrefs.GetString("AktifBall") == "Ball2")
        {
            FootballText.text = "Selected";
            FirstBall.text = "Select";
            if (aquaballisbuy == true)
            {
                AquaBallText.text = "Select";
            }
            if (tomatoballisbuy == true)
            {
                TomatoballText.text = "Select";
            }
            if (lemonballisbuy == true)
            {
                LemonballText.text = "Select";
            }
        }
        if (PlayerPrefs.GetString("AktifBall") == "Ball3")
        {
            AquaBallText.text = "Selected";
            FirstBall.text = "Select";
            if (footballisbuy== true)
            {
                FootballText.text = "Select";
            }
            if (tomatoballisbuy == true)
            {
                TomatoballText.text = "Select";
            }
            if (lemonballisbuy == true)
            {
                LemonballText.text = "Select";
            }
        }
        if (PlayerPrefs.GetString("AktifBall") == "Ball4")
        {
            TomatoballText.text = "Selected";
            FirstBall.text = "Select";
            if (footballisbuy == true)
            {
                FootballText.text = "Select";
            }
            if (aquaballisbuy == true)
            {
                AquaBallText.text = "Select";
            }
            if (lemonballisbuy == true)
            {
                LemonballText.text = "Select";
            }
        }
        if (PlayerPrefs.GetString("AktifBall") == "Ball5")
        {
            LemonballText.text = "Selected";
            FirstBall.text = "Select";
            if (footballisbuy == true)
            {
                FootballText.text = "Select";
            }
            if (aquaballisbuy == true)
            {
                AquaBallText.text = "Select";
            }
            if (tomatoballisbuy  == true)
            {
                TomatoballText.text = "Select";
            }
        }
    }
}
