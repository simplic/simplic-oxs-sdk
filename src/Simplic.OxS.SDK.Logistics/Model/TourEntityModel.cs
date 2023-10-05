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

using Simplic.OxS.SDK;

namespace Simplic.OxS.SDK.Logistics
{
    /// <summary>
    /// Shared model for tour entities.
    /// </summary>
    [DataContract(Name = "TourEntityModel")]
    public partial class TourEntityModel : IEquatable<TourEntityModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TourEntityModel" /> class.
        /// </summary>
        /// <param name="shipment">shipment.</param>
        /// <param name="cleaning">cleaning.</param>
        public TourEntityModel(ShipmentModel shipment = default(ShipmentModel), CleaningModel cleaning = default(CleaningModel))
        {
            this.Shipment = shipment;
            this.Cleaning = cleaning;
        }

        /// <summary>
        /// Gets or Sets Shipment
        /// </summary>
        [DataMember(Name = "shipment", EmitDefaultValue = false)]
        public ShipmentModel Shipment { get; set; }

        /// <summary>
        /// Gets or Sets Cleaning
        /// </summary>
        [DataMember(Name = "cleaning", EmitDefaultValue = false)]
        public CleaningModel Cleaning { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TourEntityModel {\n");
            sb.Append("  Shipment: ").Append(Shipment).Append("\n");
            sb.Append("  Cleaning: ").Append(Cleaning).Append("\n");
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
            return this.Equals(input as TourEntityModel);
        }

        /// <summary>
        /// Returns true if TourEntityModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TourEntityModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TourEntityModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Shipment == input.Shipment ||
                    (this.Shipment != null &&
                    this.Shipment.Equals(input.Shipment))
                ) && 
                (
                    this.Cleaning == input.Cleaning ||
                    (this.Cleaning != null &&
                    this.Cleaning.Equals(input.Cleaning))
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
                if (this.Shipment != null)
                {
                    hashCode = (hashCode * 59) + this.Shipment.GetHashCode();
                }
                if (this.Cleaning != null)
                {
                    hashCode = (hashCode * 59) + this.Cleaning.GetHashCode();
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
