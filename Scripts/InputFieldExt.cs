using UnityEngine.Events;
using UnityEngine.UI;

namespace Kogane
{
	/// <summary>
	/// InputField 型の拡張メソッド
	/// </summary>
	public static partial class UIExtensionMethods
	{
		//================================================================================
		// 関数(static)
		//================================================================================
		/// <summary>
		/// リスナーを設定します
		/// </summary>
		public static void SetListener( this InputField.SubmitEvent self, UnityAction<string> call )
		{
			self.RemoveAllListeners();
			self.AddListener( call );
		}

		/// <summary>
		/// <para>リスナーを追加します</para>
		/// <para>この関数は AddListener 関数の省略表記です</para>
		/// </summary>
		public static void Add( this InputField.SubmitEvent self, UnityAction<string> call )
		{
			self.AddListener( call );
		}
		
		/// <summary>
		/// <para>リスナーを解除します</para>
		/// <para>この関数は RemoveListener 関数の省略表記です</para>
		/// </summary>
		public static void Remove( this InputField.SubmitEvent self, UnityAction<string> call )
		{
			self.RemoveListener( call );
		}
		
		/// <summary>
		/// <para>リスナーを設定します</para>
		/// <para>この関数は SetListener 関数の省略表記です</para>
		/// </summary>
		public static void Set( this InputField.SubmitEvent self, UnityAction<string> call )
		{
			self.SetListener( call );
		}
		
		/// <summary>
		/// リスナーを設定します
		/// </summary>
		public static void SetListener( this InputField.OnChangeEvent self, UnityAction<string> call )
		{
			self.RemoveAllListeners();
			self.AddListener( call );
		}

		/// <summary>
		/// <para>リスナーを追加します</para>
		/// <para>この関数は AddListener 関数の省略表記です</para>
		/// </summary>
		public static void Add( this InputField.OnChangeEvent self, UnityAction<string> call )
		{
			self.AddListener( call );
		}
		
		/// <summary>
		/// <para>リスナーを解除します</para>
		/// <para>この関数は RemoveListener 関数の省略表記です</para>
		/// </summary>
		public static void Remove( this InputField.OnChangeEvent self, UnityAction<string> call )
		{
			self.RemoveListener( call );
		}
		
		/// <summary>
		/// <para>リスナーを設定します</para>
		/// <para>この関数は SetListener 関数の省略表記です</para>
		/// </summary>
		public static void Set( this InputField.OnChangeEvent self, UnityAction<string> call )
		{
			self.SetListener( call );
		}
	}
}