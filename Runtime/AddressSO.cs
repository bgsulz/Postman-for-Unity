using System;
using UnityEngine;

namespace Extra.Postman
{
    [CreateAssetMenu(menuName = "Postman/Address")]
    public class AddressSO : ScriptableObject
    {
        [field: SerializeField] public string Key { get; private set; } = Guid.NewGuid().ToString();

        public static implicit operator Address(AddressSO so) => Address.Get(so.Key);

        public void RefreshKey() => Key = Guid.NewGuid().ToString();
    }
}