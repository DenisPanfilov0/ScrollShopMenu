using System;
using System.Collections;
using System.Collections.Generic;
using UI;
using UnityEditor;
using UnityEngine;
using Random = System.Random;

public class SelectItemShopTest : MonoBehaviour
{
    [SerializeField] private ShopButtonTest _shopButtonPrefab;
    [SerializeField] private RectTransform _content;
    [SerializeField] private ItemShopConfig[] _items;

    public void Awake()
    {
        foreach (var item in _items)
        {
            var buttonPrefab = Instantiate(_shopButtonPrefab, _content);
            buttonPrefab.DrawItemShop(item.Price, item);
        }
    }
}
