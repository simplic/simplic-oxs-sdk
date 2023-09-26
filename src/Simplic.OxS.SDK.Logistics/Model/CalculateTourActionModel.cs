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
using OpenAPIDateConverter = Simplic.OxS.SDK.Client.OpenAPIDateConverter;

namespace Simplic.OxS.SDK.Logistics.Model
{
    /// <summary>
    /// Represents the action of a tour that will be used to calculate transits.
    /// </summary>
    [DataContract(Name = "CalculateTourActionModel")]
    public partial class CalculateTourActionModel : IEquatable<CalculateTourActionModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateTourActionModel" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="id">Gets or sets the id..</param>
        /// <param name="orderId">Gets or sets the order id in which the actions are processed..</param>
        /// <param name="dateTime">Gets or sets the date time.  &lt;br&gt;  Represents the planned date and time of the action.  .</param>
        public CalculateTourActionModel(AddressModel address = default(AddressModel), Guid id = default(Guid), int orderId = default(int), DateTime? dateTime = default(DateTime?))
        {
            this.Address = address;
            this.Id = id;
            this.OrderId = orderId;
            this.DateTime = dateTime;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public AddressModel Address { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>Gets or sets the id.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the order id in which the actions are processed.
        /// </summary>
        /// <value>Gets or sets the order id in which the actions are processed.</value>
        [DataMember(Name = "orderId", EmitDefaultValue = false)]
        public int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the date time.  &lt;br&gt;  Represents the planned date and time of the action.  
        /// </summary>
        /// <value>Gets or sets the date time.  &lt;br&gt;  Represents the planned date and time of the action.  </value>
        [DataMember(Name = "dateTime", EmitDefaultValue = true)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CalculateTourActionModel {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
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
            return this.Equals(input as CalculateTourActionModel);
        }

        /// <summary>
        /// Returns true if CalculateTourActionModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CalculateTourActionModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalculateTourActionModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    this.OrderId.Equals(input.OrderId)
                ) && 
                (
                    this.DateTime == input.DateTime ||
                    (this.DateTime != null &&
                    this.DateTime.Equals(input.DateTime))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                if (this.DateTime != null)
                {
                    hashCode = (hashCode * 59) + this.DateTime.GetHashCode();
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
