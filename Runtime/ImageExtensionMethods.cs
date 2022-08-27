using UnityEngine;
using UnityEngine.UI;

namespace Kogane
{
    /// <summary>
    /// Image 型の拡張メソッド
    /// </summary>
    public static partial class UIExtensionMethods
    {
        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// スプライトを設定します
        /// </summary>
        public static void SetSprite( this Image self, Sprite sprite )
        {
            self.sprite = sprite;
        }

        /// <summary>
        /// スプライトを設定します
        /// </summary>
        public static void SetSpriteIfNotNull( this Image self, Sprite sprite )
        {
            if ( self == null ) return;
            self.SetSprite( sprite );
        }

        /// <summary>
        /// スプライトを設定します
        /// </summary>
        public static void SetSpriteAndSnap( this Image self, Sprite sprite )
        {
            self.sprite = sprite;
            self.SetNativeSize();
        }

        /// <summary>
        /// スプライトを設定します
        /// </summary>
        public static void SetSpriteAndSnapIfNotNull( this Image self, Sprite sprite )
        {
            if ( self == null ) return;
            self.SetSpriteAndSnap( sprite );
        }

        /// <summary>
        /// スプライトを設定します
        /// </summary>
        public static void SetSpriteAndActive( this Image self, Sprite sprite )
        {
            self.sprite = sprite;
            self.gameObject.SetActive( sprite != null );
        }

        /// <summary>
        /// スプライトを設定します
        /// </summary>
        public static void SetSpriteAndActiveIfNotNull( this Image self, Sprite sprite )
        {
            if ( self == null ) return;
            self.SetSpriteAndActive( sprite );
        }

        /// <summary>
        /// スプライトを設定します
        /// </summary>
        public static void SetSpriteAndEnabled( this Image self, Sprite sprite )
        {
            self.sprite  = sprite;
            self.enabled = sprite != null;
        }

        /// <summary>
        /// スプライトを設定します
        /// </summary>
        public static void SetSpriteAndEnabledIfNotNull( this Image self, Sprite sprite )
        {
            if ( self == null ) return;
            self.SetSpriteAndEnabled( sprite );
        }

        /// <summary>
        /// fillAmount を設定します
        /// </summary>
        public static void SetFillAmount( this Image self, float fillAmount )
        {
            self.fillAmount = fillAmount;
        }

        /// <summary>
        /// fillAmount を設定します
        /// </summary>
        public static void SetFillAmountIfNotNull( this Image self, float fillAmount )
        {
            if ( self == null ) return;
            self.SetFillAmount( fillAmount );
        }

        /// <summary>
        /// fillAmount を設定します
        /// </summary>
        public static void SetFillAmount
        (
            this Image self,
            int        current,
            int        max
        )
        {
            self.fillAmount = max == 0 ? 0 : ( float )current / max;
        }

        /// <summary>
        /// fillAmount を設定します
        /// </summary>
        public static void SetFillAmountIfNotNull
        (
            this Image self,
            int        current,
            int        max
        )
        {
            if ( self == null ) return;
            self.SetFillAmount( current, max );
        }

        /// <summary>
        /// fillAmount を設定します
        /// </summary>
        public static void SetFillAmount
        (
            this Image self,
            long       current,
            long       max
        )
        {
            self.fillAmount = max == 0 ? 0 : ( float )current / max;
        }

        /// <summary>
        /// fillAmount を設定します
        /// </summary>
        public static void SetFillAmountIfNotNull
        (
            this Image self,
            long       current,
            long       max
        )
        {
            if ( self == null ) return;
            self.SetFillAmount( current, max );
        }
    }
}