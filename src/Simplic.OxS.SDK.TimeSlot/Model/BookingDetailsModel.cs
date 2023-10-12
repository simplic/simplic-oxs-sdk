/*
 * Simplic.OxS.TimeSlot
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

namespace Simplic.OxS.SDK.TimeSlot
{
    /// <summary>
    /// Represents the booking details
    /// </summary>
    [DataContract(Name = "BookingDetailsModel")]
    public partial class BookingDetailsModel : IEquatable<BookingDetailsModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookingDetailsModel" /> class.
        /// </summary>
        /// <param name="dateTime">Gets or sets the booking date time.</param>
        /// <param name="bookedByName">Gets or sets the name of the user that has booked the time slot.</param>
        /// <param name="loadNumber">Gets or sets the load number.</param>
        /// <param name="deliveryNumber">Gets or sets the delivery number.</param>
        /// <param name="referenceNumber">Gets or sets the reference number.</param>
        /// <param name="tractorUnit">Gets or sets the tractor unit registration plate.</param>
        /// <param name="trailer">Gets or sets the trailer registration plate.</param>
        /// <param name="driver">Gets or sets the driver name.</param>
        /// <param name="notes">Gets or sets the booking notes.</param>
        public BookingDetailsModel(DateTime dateTime = default(DateTime), string bookedByName = default(string), string loadNumber = default(string), string deliveryNumber = default(string), string referenceNumber = default(string), string tractorUnit = default(string), string trailer = default(string), string driver = default(string), string notes = default(string))
        {
            this.DateTime = dateTime;
            this.BookedByName = bookedByName;
            this.LoadNumber = loadNumber;
            this.DeliveryNumber = deliveryNumber;
            this.ReferenceNumber = referenceNumber;
            this.TractorUnit = tractorUnit;
            this.Trailer = trailer;
            this.Driver = driver;
            this.Notes = notes;
        }

        /// <summary>
        /// Gets or sets the booking date time
        /// </summary>
        /// <value>Gets or sets the booking date time</value>
        [DataMember(Name = "dateTime", EmitDefaultValue = false)]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets the name of the user that has booked the time slot
        /// </summary>
        /// <value>Gets or sets the name of the user that has booked the time slot</value>
        [DataMember(Name = "bookedByName", EmitDefaultValue = true)]
        public string BookedByName { get; set; }

        /// <summary>
        /// Gets or sets the load number
        /// </summary>
        /// <value>Gets or sets the load number</value>
        [DataMember(Name = "loadNumber", EmitDefaultValue = true)]
        public string LoadNumber { get; set; }

        /// <summary>
        /// Gets or sets the delivery number
        /// </summary>
        /// <value>Gets or sets the delivery number</value>
        [DataMember(Name = "deliveryNumber", EmitDefaultValue = true)]
        public string DeliveryNumber { get; set; }

        /// <summary>
        /// Gets or sets the reference number
        /// </summary>
        /// <value>Gets or sets the reference number</value>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = true)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// Gets or sets the tractor unit registration plate
        /// </summary>
        /// <value>Gets or sets the tractor unit registration plate</value>
        [DataMember(Name = "tractorUnit", EmitDefaultValue = true)]
        public string TractorUnit { get; set; }

        /// <summary>
        /// Gets or sets the trailer registration plate
        /// </summary>
        /// <value>Gets or sets the trailer registration plate</value>
        [DataMember(Name = "trailer", EmitDefaultValue = true)]
        public string Trailer { get; set; }

        /// <summary>
        /// Gets or sets the driver name
        /// </summary>
        /// <value>Gets or sets the driver name</value>
        [DataMember(Name = "driver", EmitDefaultValue = true)]
        public string Driver { get; set; }

        /// <summary>
        /// Gets or sets the booking notes
        /// </summary>
        /// <value>Gets or sets the booking notes</value>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BookingDetailsModel {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  BookedByName: ").Append(BookedByName).Append("\n");
            sb.Append("  LoadNumber: ").Append(LoadNumber).Append("\n");
            sb.Append("  DeliveryNumber: ").Append(DeliveryNumber).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  TractorUnit: ").Append(TractorUnit).Append("\n");
            sb.Append("  Trailer: ").Append(Trailer).Append("\n");
            sb.Append("  Driver: ").Append(Driver).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as BookingDetailsModel);
        }

        /// <summary>
        /// Returns true if BookingDetailsModel instances are equal
        /// </summary>
        /// <param name="input">Instance of BookingDetailsModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BookingDetailsModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DateTime == input.DateTime ||
                    (this.DateTime != null &&
                    this.DateTime.Equals(input.DateTime))
                ) && 
                (
                    this.BookedByName == input.BookedByName ||
                    (this.BookedByName != null &&
                    this.BookedByName.Equals(input.BookedByName))
                ) && 
                (
                    this.LoadNumber == input.LoadNumber ||
                    (this.LoadNumber != null &&
                    this.LoadNumber.Equals(input.LoadNumber))
                ) && 
                (
                    this.DeliveryNumber == input.DeliveryNumber ||
                    (this.DeliveryNumber != null &&
                    this.DeliveryNumber.Equals(input.DeliveryNumber))
                ) && 
                (
                    this.ReferenceNumber == input.ReferenceNumber ||
                    (this.ReferenceNumber != null &&
                    this.ReferenceNumber.Equals(input.ReferenceNumber))
                ) && 
                (
                    this.TractorUnit == input.TractorUnit ||
                    (this.TractorUnit != null &&
                    this.TractorUnit.Equals(input.TractorUnit))
                ) && 
                (
                    this.Trailer == input.Trailer ||
                    (this.Trailer != null &&
                    this.Trailer.Equals(input.Trailer))
                ) && 
                (
                    this.Driver == input.Driver ||
                    (this.Driver != null &&
                    this.Driver.Equals(input.Driver))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                if (this.DateTime != null)
                {
                    hashCode = (hashCode * 59) + this.DateTime.GetHashCode();
                }
                if (this.BookedByName != null)
                {
                    hashCode = (hashCode * 59) + this.BookedByName.GetHashCode();
                }
                if (this.LoadNumber != null)
                {
                    hashCode = (hashCode * 59) + this.LoadNumber.GetHashCode();
                }
                if (this.DeliveryNumber != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryNumber.GetHashCode();
                }
                if (this.ReferenceNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceNumber.GetHashCode();
                }
                if (this.TractorUnit != null)
                {
                    hashCode = (hashCode * 59) + this.TractorUnit.GetHashCode();
                }
                if (this.Trailer != null)
                {
                    hashCode = (hashCode * 59) + this.Trailer.GetHashCode();
                }
                if (this.Driver != null)
                {
                    hashCode = (hashCode * 59) + this.Driver.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
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
