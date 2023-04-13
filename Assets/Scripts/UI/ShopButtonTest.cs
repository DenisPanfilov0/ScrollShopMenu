using TMPro;
using UI;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShopButtonTest : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _sellPrice;
    [SerializeField] private Image _itemSprite;

    public void DrawItemShop(string SellPrice, ItemShopConfig Item)
    {
        _sellPrice.text = SellPrice;
        _itemSprite.sprite = Item.Icon;
    }
}
