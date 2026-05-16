using System;
using UnityEngine;

namespace OneM.Attributes
{
    /// <summary>
    /// Abstract class for Comparable Attributes.
    /// <para>Use it to create comparable field attributes.</para>
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
    public abstract class AbstractComparableAttribute : PropertyAttribute
    {
        public readonly object value;
        public readonly string field;
        public readonly LogicalOperatorType operatorType;

        /// <summary>
        /// Compares the given field using the other params.
        /// </summary>
        /// <param name="field">The name of the field to compare (case sensitive).</param>
        /// <param name="operatorType">The Comparison Operator to use.</param>
        /// <param name="value">The value to compare with the field.</param>
        /// <param name="isProperty">Whether the field to compare is a property or not.</param>
        public AbstractComparableAttribute(
            string field,
            LogicalOperatorType operatorType,
            object value,
            bool isProperty
        )
        {
            this.value = value;
            this.operatorType = operatorType;
            this.field = isProperty ? $"<{field}>k__BackingField" : field;
        }

        public bool GetBoolValue() => value != null && (bool)value;
    }
}