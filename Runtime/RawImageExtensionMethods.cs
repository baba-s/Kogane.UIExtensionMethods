using UnityEngine;
using UnityEngine.UI;

namespace Kogane
{
    /// <summary>
    /// RawImage 型の拡張メソッド
    /// </summary>
    public static partial class UIExtensionMethods
    {
        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// テクスチャを設定します
        /// </summary>
        public static void SetTexture( this RawImage self, Texture texture )
        {
            self.texture = texture;
        }

        /// <summary>
        /// テクスチャを設定します
        /// </summary>
        public static void SetTextureIfNotNull( this RawImage self, Texture texture )
        {
            if ( self == null ) return;
            self.SetTexture( texture );
        }

        /// <summary>
        /// テクスチャを設定します
        /// </summary>
        public static void SetTextureAndSnap( this RawImage self, Texture texture )
        {
            self.texture = texture;
            self.SetNativeSize();
        }

        /// <summary>
        /// テクスチャを設定します
        /// </summary>
        public static void SetTextureAndSnapIfNotNull( this RawImage self, Texture texture )
        {
            if ( self == null ) return;
            self.SetTextureAndSnap( texture );
        }

        /// <summary>
        /// テクスチャを設定します
        /// </summary>
        public static void SetTextureAndActive( this RawImage self, Texture texture )
        {
            self.texture = texture;
            self.gameObject.SetActive( texture != null );
        }

        /// <summary>
        /// テクスチャを設定します
        /// </summary>
        public static void SetTextureAndActiveIfNotNull( this RawImage self, Texture texture )
        {
            if ( self == null ) return;
            self.SetTextureAndActive( texture );
        }

        /// <summary>
        /// テクスチャを設定します
        /// </summary>
        public static void SetTextureAndEnabled( this RawImage self, Texture texture )
        {
            self.texture = texture;
            self.enabled = texture != null;
        }

        /// <summary>
        /// テクスチャを設定します
        /// </summary>
        public static void SetTextureAndEnabledIfNotNull( this RawImage self, Texture texture )
        {
            if ( self == null ) return;
            self.SetTextureAndEnabled( texture );
        }

        /// <summary>
        /// uvRect.x を返します
        /// </summary>
        public static float GetUvRectX( this RawImage self )
        {
            return self.uvRect.x;
        }

        /// <summary>
        /// uvRect.y を返します
        /// </summary>
        public static float GetUvRectY( this RawImage self )
        {
            return self.uvRect.y;
        }

        /// <summary>
        /// uvRect.width を返します
        /// </summary>
        public static float GetUvRectWidth( this RawImage self )
        {
            return self.uvRect.width;
        }

        /// <summary>
        /// uvRect.height を返します
        /// </summary>
        public static float GetUvRectHeight( this RawImage self )
        {
            return self.uvRect.height;
        }

        /// <summary>
        /// uvRect.x を設定します
        /// </summary>
        public static void SetUvRectX( this RawImage self, float value )
        {
            var uvRect = self.uvRect;
            uvRect.x    = value;
            self.uvRect = uvRect;
        }

        /// <summary>
        /// uvRect.y を設定します
        /// </summary>
        public static void SetUvRectY( this RawImage self, float value )
        {
            var uvRect = self.uvRect;
            uvRect.y    = value;
            self.uvRect = uvRect;
        }

        /// <summary>
        /// uvRect.width を設定します
        /// </summary>
        public static void SetUvRectWidth( this RawImage self, float value )
        {
            var uvRect = self.uvRect;
            uvRect.width = value;
            self.uvRect  = uvRect;
        }

        /// <summary>
        /// uvRect.height を設定します
        /// </summary>
        public static void SetUvRectHeight( this RawImage self, float value )
        {
            var uvRect = self.uvRect;
            uvRect.height = value;
            self.uvRect   = uvRect;
        }
    }
}