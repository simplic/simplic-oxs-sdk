/*
 * Simplic.OxS.Logistics
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

namespace Simplic.OxS.SDK.Logistics.Model
{
    /// <summary>
    /// Response of a calculate route response.
    /// </summary>
    [DataContract(Name = "CalculateRouteResponse")]
    public partial class CalculateRouteResponse : IEquatable<CalculateRouteResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateRouteResponse" /> class.
        /// </summary>
        /// <param name="transits">Gets or sets the transits..</param>
        public CalculateRouteResponse(List<TransitModel> transits = default(List<TransitModel>))
        {
            this.Transits = transits;
        }

        /// <summary>
        /// Gets or sets the transits.
        /// </summary>
        /// <value>Gets or sets the transits.</value>
        [DataMember(Name = "transits", EmitDefaultValue = true)]
        public List<TransitModel> Transits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CalculateRouteResponse {\n");
            sb.Append("  Transits: ").Append(Transits).Append("\n");
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
            return this.Equals(input as CalculateRouteResponse);
        }

        /// <summary>
        /// Returns true if CalculateRouteResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CalculateRouteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalculateRouteResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Transits == input.Transits ||
                    this.Transits != null &&
                    input.Transits != null &&
                    this.Transits.SequenceEqual(input.Transits)
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
                if (this.Transits != null)
                {
                    hashCode = (hashCode * 59) + this.Transits.GetHashCode();
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
