using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _sellText;
    [SerializeField] private Image _itemSpriteImage;
    

    public void DrawItemShop(string SellText, Sprite ItemSprite)
    {
        _sellText.text = SellText;
        _itemSpriteImage.sprite = ItemSprite;
    }
}
