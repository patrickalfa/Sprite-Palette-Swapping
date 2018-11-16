using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PTK.Palette
{
    [ExecuteInEditMode]
    [RequireComponent(typeof(SpriteRenderer))]
    public class SpritePalette : MonoBehaviour
    {
        public Texture _palette;
        private Material _material;

        private void Start()
        {
            UpdatePalette();
        }

        public void SetPalette(Texture palette)
        {
            _palette = palette;
            UpdatePalette();
        }

        public void UpdatePalette()
        {
            SetMaterial();

            _material.SetTexture("_PaletteTex", _palette);
        }

        private void SetMaterial()
        {
            if (!_material)
            {
                SpriteRenderer sprt = GetComponent<SpriteRenderer>();
                _material = new Material(Shader.Find("Sprites/Paletted"));
                _material.SetTexture("_MainTex", sprt.sprite.texture);
                _material.SetTexture("_PaletteTex", _palette);
                sprt.material = _material;
            }
        }
    }
}