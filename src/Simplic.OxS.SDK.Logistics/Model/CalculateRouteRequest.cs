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
using OpenAPIDateConverter = Simplic.OxS.SDK.Logistics.OpenAPIDateConverter;

namespace Simplic.OxS.SDK.Logistics
{
    /// <summary>
    /// CalculateRouteRequest
    /// </summary>
    [DataContract(Name = "CalculateRouteRequest")]
    public partial class CalculateRouteRequest : IEquatable<CalculateRouteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateRouteRequest" /> class.
        /// </summary>
        /// <param name="metrics">metrics.</param>
        /// <param name="tour">tour.</param>
        public CalculateRouteRequest(List<string> metrics = default(List<string>), CalculateTourModel tour = default(CalculateTourModel))
        {
            this.Metrics = metrics;
            this.Tour = tour;
        }

        /// <summary>
        /// Gets or Sets Metrics
        /// </summary>
        [DataMember(Name = "metrics", EmitDefaultValue = true)]
        public List<string> Metrics { get; set; }

        /// <summary>
        /// Gets or Sets Tour
        /// </summary>
        [DataMember(Name = "tour", EmitDefaultValue = false)]
        public CalculateTourModel Tour { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CalculateRouteRequest {\n");
            sb.Append("  Metrics: ").Append(Metrics).Append("\n");
            sb.Append("  Tour: ").Append(Tour).Append("\n");
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
            return this.Equals(input as CalculateRouteRequest);
        }

        /// <summary>
        /// Returns true if CalculateRouteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CalculateRouteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalculateRouteRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Metrics == input.Metrics ||
                    this.Metrics != null &&
                    input.Metrics != null &&
                    this.Metrics.SequenceEqual(input.Metrics)
                ) && 
                (
                    this.Tour == input.Tour ||
                    (this.Tour != null &&
                    this.Tour.Equals(input.Tour))
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
                if (this.Metrics != null)
                {
                    hashCode = (hashCode * 59) + this.Metrics.GetHashCode();
                }
                if (this.Tour != null)
                {
                    hashCode = (hashCode * 59) + this.Tour.GetHashCode();
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
