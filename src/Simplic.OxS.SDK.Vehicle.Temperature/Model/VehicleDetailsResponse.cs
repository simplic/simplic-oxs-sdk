/*
 * Simplic.OxS.vehicle-temperature
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

namespace Simplic.OxS.SDK.Vehicle.Temperature
{
    /// <summary>
    /// VehicleDetailsResponse
    /// </summary>
    [DataContract(Name = "VehicleDetailsResponse")]
    public partial class VehicleDetailsResponse : IEquatable<VehicleDetailsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleDetailsResponse" /> class.
        /// </summary>
        /// <param name="measurements">measurements.</param>
        public VehicleDetailsResponse(List<MeasurementResponseModel> measurements = default(List<MeasurementResponseModel>))
        {
            this.Measurements = measurements;
        }

        /// <summary>
        /// Gets or Sets Measurements
        /// </summary>
        [DataMember(Name = "measurements", EmitDefaultValue = true)]
        public List<MeasurementResponseModel> Measurements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VehicleDetailsResponse {\n");
            sb.Append("  Measurements: ").Append(Measurements).Append("\n");
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
            return this.Equals(input as VehicleDetailsResponse);
        }

        /// <summary>
        /// Returns true if VehicleDetailsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of VehicleDetailsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VehicleDetailsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Measurements == input.Measurements ||
                    this.Measurements != null &&
                    input.Measurements != null &&
                    this.Measurements.SequenceEqual(input.Measurements)
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
                if (this.Measurements != null)
                {
                    hashCode = (hashCode * 59) + this.Measurements.GetHashCode();
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