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
    /// Represents a connection between a shipment and a tour.
    /// </summary>
    [DataContract(Name = "ShipmentTourModel")]
    public partial class ShipmentTourModel : IEquatable<ShipmentTourModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentTourModel" /> class.
        /// </summary>
        /// <param name="tourId">Gets or sets the tour-id.</param>
        /// <param name="resource">resource.</param>
        /// <param name="number">Gets or sets the tour number.</param>
        /// <param name="startDateTime">Gets or sets the start date (attach action date time).</param>
        /// <param name="endDateTime">Gets or sets the end date (detach action date time).</param>
        /// <param name="startAddress">startAddress.</param>
        /// <param name="endAddress">endAddress.</param>
        public ShipmentTourModel(Guid tourId = default(Guid), ResourceModel resource = default(ResourceModel), string number = default(string), DateTime startDateTime = default(DateTime), DateTime endDateTime = default(DateTime), AddressModel startAddress = default(AddressModel), AddressModel endAddress = default(AddressModel))
        {
            this.TourId = tourId;
            this.Resource = resource;
            this.Number = number;
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
            this.StartAddress = startAddress;
            this.EndAddress = endAddress;
        }

        /// <summary>
        /// Gets or sets the tour-id
        /// </summary>
        /// <value>Gets or sets the tour-id</value>
        [DataMember(Name = "tourId", EmitDefaultValue = false)]
        public Guid TourId { get; set; }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name = "resource", EmitDefaultValue = false)]
        public ResourceModel Resource { get; set; }

        /// <summary>
        /// Gets or sets the tour number
        /// </summary>
        /// <value>Gets or sets the tour number</value>
        [DataMember(Name = "number", EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the start date (attach action date time)
        /// </summary>
        /// <value>Gets or sets the start date (attach action date time)</value>
        [DataMember(Name = "startDateTime", EmitDefaultValue = false)]
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// Gets or sets the end date (detach action date time)
        /// </summary>
        /// <value>Gets or sets the end date (detach action date time)</value>
        [DataMember(Name = "endDateTime", EmitDefaultValue = false)]
        public DateTime EndDateTime { get; set; }

        /// <summary>
        /// Gets or Sets StartAddress
        /// </summary>
        [DataMember(Name = "startAddress", EmitDefaultValue = false)]
        public AddressModel StartAddress { get; set; }

        /// <summary>
        /// Gets or Sets EndAddress
        /// </summary>
        [DataMember(Name = "endAddress", EmitDefaultValue = false)]
        public AddressModel EndAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentTourModel {\n");
            sb.Append("  TourId: ").Append(TourId).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  StartAddress: ").Append(StartAddress).Append("\n");
            sb.Append("  EndAddress: ").Append(EndAddress).Append("\n");
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
            return this.Equals(input as ShipmentTourModel);
        }

        /// <summary>
        /// Returns true if ShipmentTourModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentTourModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentTourModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TourId == input.TourId ||
                    (this.TourId != null &&
                    this.TourId.Equals(input.TourId))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.StartDateTime == input.StartDateTime ||
                    (this.StartDateTime != null &&
                    this.StartDateTime.Equals(input.StartDateTime))
                ) && 
                (
                    this.EndDateTime == input.EndDateTime ||
                    (this.EndDateTime != null &&
                    this.EndDateTime.Equals(input.EndDateTime))
                ) && 
                (
                    this.StartAddress == input.StartAddress ||
                    (this.StartAddress != null &&
                    this.StartAddress.Equals(input.StartAddress))
                ) && 
                (
                    this.EndAddress == input.EndAddress ||
                    (this.EndAddress != null &&
                    this.EndAddress.Equals(input.EndAddress))
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
                if (this.TourId != null)
                {
                    hashCode = (hashCode * 59) + this.TourId.GetHashCode();
                }
                if (this.Resource != null)
                {
                    hashCode = (hashCode * 59) + this.Resource.GetHashCode();
                }
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.StartDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartDateTime.GetHashCode();
                }
                if (this.EndDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndDateTime.GetHashCode();
                }
                if (this.StartAddress != null)
                {
                    hashCode = (hashCode * 59) + this.StartAddress.GetHashCode();
                }
                if (this.EndAddress != null)
                {
                    hashCode = (hashCode * 59) + this.EndAddress.GetHashCode();
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
