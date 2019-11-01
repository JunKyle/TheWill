﻿using System;
using UnityEngine;

namespace TheWill
{
    public class ItemCard : InteractibleObject
    {
        [SerializeField] SpriteRenderer _spriteRenderer;

        [SerializeField] bool _isTalking;
        public bool IsTalking
        {
            get
            {
                return _isTalking;
            }

            set
            {
                _isTalking = value;
            }
        }

        [SerializeField] ItemInfo _info;
        public ItemInfo Info
        {
            get { return _info; }
            set { _info = value; }
        }

        public event Action<string> OnClickObjectValue;
        public bool isClicked = false;

        
    ///////////////////////////////////////////////////////////////
    /// GENERAL FUNCTIONS /////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
        void Awake()
        {
            Sprite = _spriteRenderer;

            EventManager.StartListening(Info.name + "OnClick", OnClickObject);

            OnClickObjectValue += DoStuff;
        }
        /*********************************************************/
        
    ///////////////////////////////////////////////////////////////
    /// PRIVATE FUNCTIONS /////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
        void OnClickObject(object a_value)
        {
            if (OnClickObjectValue != null)
                OnClickObjectValue(Info.name);
        }
        /*********************************************************/

        void DoStuff(string a_name)
        {
            Debug.Log("[DoStuff] name is " + a_name);
            isClicked = true;
        }
        /*********************************************************/
    }
}
