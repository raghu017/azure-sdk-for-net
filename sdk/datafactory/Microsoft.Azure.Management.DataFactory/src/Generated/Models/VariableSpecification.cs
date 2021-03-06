// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of a single variable for a Pipeline.
    /// </summary>
    public partial class VariableSpecification
    {
        /// <summary>
        /// Initializes a new instance of the VariableSpecification class.
        /// </summary>
        public VariableSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VariableSpecification class.
        /// </summary>
        /// <param name="type">Variable type. Possible values include:
        /// 'String', 'Bool', 'Array'</param>
        /// <param name="defaultValue">Default value of variable.</param>
        public VariableSpecification(string type, object defaultValue = default(object))
        {
            Type = type;
            DefaultValue = defaultValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets variable type. Possible values include: 'String',
        /// 'Bool', 'Array'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets default value of variable.
        /// </summary>
        [JsonProperty(PropertyName = "defaultValue")]
        public object DefaultValue { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
