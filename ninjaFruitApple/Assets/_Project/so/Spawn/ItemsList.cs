using Project;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace So
{
    [CreateAssetMenu(fileName = "ItemsList", menuName ="Configs/ItemList")]
    public class ItemsList : ScriptableObject
    {
        public ItemBase[] items;
    }
}