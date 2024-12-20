/*
 * Simplic.OxS.DevOps
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

namespace Simplic.OxS.SDK.DevOps
{
    /// <summary>
    /// Data
    /// </summary>
    [DataContract(Name = "Data")]
    public partial class Data : IEquatable<Data>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data" /> class.
        /// </summary>
        /// <param name="statusType">statusType.</param>
        public Data(string statusType = default(string))
        {
            this.StatusType = statusType;
        }

        /// <summary>
        /// Gets or Sets StatusType
        /// </summary>
        [DataMember(Name = "statusType", EmitDefaultValue = true)]
        public string StatusType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Data {\n");
            sb.Append("  StatusType: ").Append(StatusType).Append("\n");
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
            return this.Equals(input as Data);
        }

        /// <summary>
        /// Returns true if Data instances are equal
        /// </summary>
        /// <param name="input">Instance of Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Data input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.StatusType == input.StatusType ||
                    (this.StatusType != null &&
                    this.StatusType.Equals(input.StatusType))
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
                if (this.StatusType != null)
                {
                    hashCode = (hashCode * 59) + this.StatusType.GetHashCode();
                }
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
