using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Kogane
{
    /// <summary>
    /// TMP_InputField 型の拡張メソッド
    /// </summary>
    public static partial class UIExtensionMethods
    {
        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// リスナーを設定します
        /// </summary>
        public static void SetListener( this TMP_InputField.SubmitEvent self, UnityAction<string> call )
        {
            self.RemoveAllListeners();
            self.AddListener( call );
        }

        /// <summary>
        /// <para>リスナーを追加します</para>
        /// <para>この関数は AddListener 関数の省略表記です</para>
        /// </summary>
        public static void Add( this TMP_InputField.SubmitEvent self, UnityAction<string> call )
        {
            self.AddListener( call );
        }

        /// <summary>
        /// <para>リスナーを解除します</para>
        /// <para>この関数は RemoveListener 関数の省略表記です</para>
        /// </summary>
        public static void Remove( this TMP_InputField.SubmitEvent self, UnityAction<string> call )
        {
            self.RemoveListener( call );
        }

        /// <summary>
        /// <para>リスナーを設定します</para>
        /// <para>この関数は SetListener 関数の省略表記です</para>
        /// </summary>
        public static void Set( this TMP_InputField.SubmitEvent self, UnityAction<string> call )
        {
            self.SetListener( call );
        }

        /// <summary>
        /// リスナーを設定します
        /// </summary>
        public static void SetListener( this TMP_InputField.OnChangeEvent self, UnityAction<string> call )
        {
            self.RemoveAllListeners();
            self.AddListener( call );
        }

        /// <summary>
        /// <para>リスナーを追加します</para>
        /// <para>この関数は AddListener 関数の省略表記です</para>
        /// </summary>
        public static void Add( this TMP_InputField.OnChangeEvent self, UnityAction<string> call )
        {
            self.AddListener( call );
        }

        /// <summary>
        /// <para>リスナーを解除します</para>
        /// <para>この関数は RemoveListener 関数の省略表記です</para>
        /// </summary>
        public static void Remove( this TMP_InputField.OnChangeEvent self, UnityAction<string> call )
        {
            self.RemoveListener( call );
        }

        /// <summary>
        /// <para>リスナーを設定します</para>
        /// <para>この関数は SetListener 関数の省略表記です</para>
        /// </summary>
        public static void Set( this TMP_InputField.OnChangeEvent self, UnityAction<string> call )
        {
            self.SetListener( call );
        }

        /// <summary>
        /// リスナーを設定します
        /// </summary>
        public static void SetListener( this TMP_InputField.SelectionEvent self, UnityAction<string> call )
        {
            self.RemoveAllListeners();
            self.AddListener( call );
        }

        /// <summary>
        /// <para>リスナーを追加します</para>
        /// <para>この関数は AddListener 関数の省略表記です</para>
        /// </summary>
        public static void Add( this TMP_InputField.SelectionEvent self, UnityAction<string> call )
        {
            self.AddListener( call );
        }

        /// <summary>
        /// <para>リスナーを解除します</para>
        /// <para>この関数は RemoveListener 関数の省略表記です</para>
        /// </summary>
        public static void Remove( this TMP_InputField.SelectionEvent self, UnityAction<string> call )
        {
            self.RemoveListener( call );
        }

        /// <summary>
        /// <para>リスナーを設定します</para>
        /// <para>この関数は SetListener 関数の省略表記です</para>
        /// </summary>
        public static void Set( this TMP_InputField.SelectionEvent self, UnityAction<string> call )
        {
            self.SetListener( call );
        }

        /// <summary>
        /// リスナーを設定します
        /// </summary>
        public static void SetListener( this TMP_InputField.TextSelectionEvent self, UnityAction<string, int, int> call )
        {
            self.RemoveAllListeners();
            self.AddListener( call );
        }

        /// <summary>
        /// <para>リスナーを追加します</para>
        /// <para>この関数は AddListener 関数の省略表記です</para>
        /// </summary>
        public static void Add( this TMP_InputField.TextSelectionEvent self, UnityAction<string, int, int> call )
        {
            self.AddListener( call );
        }

        /// <summary>
        /// <para>リスナーを解除します</para>
        /// <para>この関数は RemoveListener 関数の省略表記です</para>
        /// </summary>
        public static void Remove( this TMP_InputField.TextSelectionEvent self, UnityAction<string, int, int> call )
        {
            self.RemoveListener( call );
        }

        /// <summary>
        /// <para>リスナーを設定します</para>
        /// <para>この関数は SetListener 関数の省略表記です</para>
        /// </summary>
        public static void Set( this TMP_InputField.TextSelectionEvent self, UnityAction<string, int, int> call )
        {
            self.SetListener( call );
        }

        /// <summary>
        /// リスナーを設定します
        /// </summary>
        public static void SetListener( this TMP_InputField.TouchScreenKeyboardEvent self, UnityAction<TouchScreenKeyboard.Status> call )
        {
            self.RemoveAllListeners();
            self.AddListener( call );
        }

        /// <summary>
        /// <para>リスナーを追加します</para>
        /// <para>この関数は AddListener 関数の省略表記です</para>
        /// </summary>
        public static void Add( this TMP_InputField.TouchScreenKeyboardEvent self, UnityAction<TouchScreenKeyboard.Status> call )
        {
            self.AddListener( call );
        }

        /// <summary>
        /// <para>リスナーを解除します</para>
        /// <para>この関数は RemoveListener 関数の省略表記です</para>
        /// </summary>
        public static void Remove( this TMP_InputField.TouchScreenKeyboardEvent self, UnityAction<TouchScreenKeyboard.Status> call )
        {
            self.RemoveListener( call );
        }

        /// <summary>
        /// <para>リスナーを設定します</para>
        /// <para>この関数は SetListener 関数の省略表記です</para>
        /// </summary>
        public static void Set( this TMP_InputField.TouchScreenKeyboardEvent self, UnityAction<TouchScreenKeyboard.Status> call )
        {
            self.SetListener( call );
        }
    }
}