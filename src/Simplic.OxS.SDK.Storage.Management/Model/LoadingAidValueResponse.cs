/*
 * Simplic.OxS.storage-management
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Simplic.OxS.SDK.OpenAPIDateConverter;

using Simplic.OxS.SDK;

namespace Simplic.OxS.SDK.Storage.Management
{
    /// <summary>
    /// LoadingAidValueResponse
    /// </summary>
    [DataContract(Name = "LoadingAidValueResponse")]
    public partial class LoadingAidValueResponse : IEquatable<LoadingAidValueResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadingAidValueResponse" /> class.
        /// </summary>
        /// <param name="loadingAidType">loadingAidType.</param>
        /// <param name="quantity">quantity.</param>
        public LoadingAidValueResponse(LoadingAidTypeModel loadingAidType = default(LoadingAidTypeModel), double quantity = default(double))
        {
            this.LoadingAidType = loadingAidType;
            this.Quantity = quantity;
        }

        /// <summary>
        /// Gets or Sets LoadingAidType
        /// </summary>
        [DataMember(Name = "loadingAidType", EmitDefaultValue = false)]
        public LoadingAidTypeModel LoadingAidType { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public double Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LoadingAidValueResponse {\n");
            sb.Append("  LoadingAidType: ").Append(LoadingAidType).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoadingAidValueResponse);
        }

        /// <summary>
        /// Returns true if LoadingAidValueResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LoadingAidValueResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoadingAidValueResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LoadingAidType == input.LoadingAidType ||
                    (this.LoadingAidType != null &&
                    this.LoadingAidType.Equals(input.LoadingAidType))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.LoadingAidType != null)
                {
                    hashCode = (hashCode * 59) + this.LoadingAidType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
