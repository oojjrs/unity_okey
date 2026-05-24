using UnityEngine;
using UnityEngine.UI;

namespace Assets.Sources.Scripts
{
    [RequireComponent(typeof(Image))]
    internal class KeyToImage : MonoBehaviour
    {
        public string Key;
        public MyKeyPool Pool;

        private void Start()
        {
            GetComponent<Image>().sprite = Pool.GetSprite(Key);
        }
    }
}
