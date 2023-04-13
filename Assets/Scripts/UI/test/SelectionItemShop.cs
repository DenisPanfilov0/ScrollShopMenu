using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SelectionItemShop : MonoBehaviour
{
    [SerializeField] private ShopButton _shopButtonPrefab;
    [SerializeField] private RectTransform _content;
    [SerializeField] private Sprite[] _itemSprite;


    [SerializeField] private string[] SellPrice;

    private void Awake()
    {
        float b = 10;

        for (int i = 0; i < SellPrice.Length; i++)
        {
            var buttonInstance = Instantiate(_shopButtonPrefab, _content);

            buttonInstance.DrawItemShop(Mathf.RoundToInt(b).ToString(), _itemSprite[i]);
            Debug.Log(_itemSprite[i]);
            b = b * 1.2f;

        }
    }
}
