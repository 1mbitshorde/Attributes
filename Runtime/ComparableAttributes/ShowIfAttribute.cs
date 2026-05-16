namespace OneM.Attributes
{
    /// <summary>
    /// Attribute for showing fields when the given condition is met.
    /// <para>Use it to show fields based on the current state of the object.</para>
    /// </summary>
    public sealed class ShowIfAttribute : AbstractComparableAttribute
    {
        /// <summary>
        /// Shows this field only if the given field is equals to the value.
        /// </summary>
        /// <param name="field">The name of the field to compare (case sensitive).</param>
        /// <param name="value">The value to compare with the field.</param>
        /// <param name="isProperty">Whether the field to compare is a property or not.</param>
        public ShowIfAttribute(string field, object value, bool isProperty = false)
            : base(field, LogicalOperatorType.Equals, value, isProperty) { }

        /// <summary>
        /// Shows this field only if the given field is not null.
        /// </summary>
        /// <param name="field">The name of the field to compare (case sensitive).</param>
        /// <param name="isProperty">Whether the field to compare is a property or not.</param>
        public ShowIfAttribute(string field, bool isProperty = false)
            : base(field, LogicalOperatorType.NotEqual, null, isProperty) { }

        /// <summary>
        /// Shows this field only if the given condition is met.
        /// </summary>
        /// <param name="field">The name of the field to compare (case sensitive).</param>
        /// <param name="operatorType">The Comparison Operator to use.</param>
        /// <param name="value">The value to compare with the field.</param>
        /// <param name="isProperty">Whether the field to compare is a property or not.</param>
        public ShowIfAttribute(string field, LogicalOperatorType operatorType, object value, bool isProperty = false)
            : base(field, operatorType, value, isProperty) { }
    }
}