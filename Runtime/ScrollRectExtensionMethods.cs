using UnityEngine.UI;

namespace Kogane
{
    /// <summary>
    /// ScrollRect 型の拡張メソッド
    /// </summary>
    public static partial class UIExtensionMethods
    {
        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// スクロール座標を上端にリセットします
        /// </summary>
        public static void ResetScrollPositionToTop( this ScrollRect self )
        {
            self.verticalNormalizedPosition = 1;
        }

        /// <summary>
        /// スクロール座標を下端にリセットします
        /// </summary>
        public static void ResetScrollPositionToBottom( this ScrollRect self )
        {
            self.verticalNormalizedPosition = 0;
        }

        /// <summary>
        /// スクロール座標を左端にリセットします
        /// </summary>
        public static void ResetScrollPositionToLeft( this ScrollRect self )
        {
            self.horizontalNormalizedPosition = 0;
        }

        /// <summary>
        /// スクロール座標を右端にリセットします
        /// </summary>
        public static void ResetScrollPositionToRight( this ScrollRect self )
        {
            self.horizontalNormalizedPosition = 1;
        }
    }
}