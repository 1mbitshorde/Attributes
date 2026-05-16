namespace OneM.Attributes
{
    /// <summary>
    /// Attribute for showing readonly fields when the given condition is met.
    /// <para>Use it to disallow changes in properties based on the current state of the object.</para>
    /// </summary>
    public sealed class ReadonlyIfAttribute : AbstractComparableAttribute
    {
        /// <summary>
        /// Disallows changes in this field only if the given field is equals to the value.
        /// </summary>
        /// <param name="field">The name of the field to compare (case sensitive).</param>
        /// <param name="value">The value to compare with the field.</param>
        /// <param name="isProperty">Whether the field to compare is a property or not.</param>
        public ReadonlyIfAttribute(string field, object value, bool isProperty = false)
            : base(field, LogicalOperatorType.Equals, value, isProperty) { }

        /// <summary>
        /// Disallows changes in this field only if the given field is not null.
        /// </summary>
        /// <param name="field">The name of the field to compare (case sensitive).</param>
        /// <param name="isProperty">Whether the field to compare is a property or not.</param>
        public ReadonlyIfAttribute(string field, bool isProperty = false)
            : base(field, LogicalOperatorType.NotEqual, null, isProperty) { }

        /// <summary>
        /// Disallows changes in this field only if the given condition is met.
        /// </summary>
        /// <param name="field">The name of the field to compare (case sensitive).</param>
        /// <param name="operatorType">The Comparison Operator to use.</param>
        /// <param name="value">The value to compare with the field.</param>
        /// <param name="isProperty">Whether the field to compare is a property or not.</param>
        public ReadonlyIfAttribute(string field, LogicalOperatorType operatorType, object value, bool isProperty = false)
            : base(field, operatorType, value, isProperty) { }
    }
}