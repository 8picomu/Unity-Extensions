using System;
using UnityEngine;

namespace eightpicomu.Extensions.Editor {

	//https://github.com/baba-s/Unity-SerializeReferenceExtensions
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class SubclassSelectorAttribute : PropertyAttribute {
		bool m_includeMono;

		public SubclassSelectorAttribute(bool includeMono = false) {
			m_includeMono = includeMono;
		}

		public bool IsIncludeMono() {
			return m_includeMono;
		}
	}
}