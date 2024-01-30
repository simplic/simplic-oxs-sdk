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
    /// Class to represent a transit.  &lt;br&gt;  A transit describes a movement of the primary resource from one place to another during a tour.    Transits will be automaically generated and updated from a service.
    /// </summary>
    [DataContract(Name = "TransitModel")]
    public partial class TransitModel : IEquatable<TransitModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransitModel" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the id..</param>
        /// <param name="startAddress">startAddress.</param>
        /// <param name="startDateTime">Gets or sets the start date time of the transit..</param>
        /// <param name="endAddress">endAddress.</param>
        /// <param name="endDateTime">Gets or sets the end date time off the transit..</param>
        /// <param name="startActionId">Gets or sets the id of the start action.  &lt;br&gt;  When the guid is null the transit will start at the start of the tour.  .</param>
        /// <param name="globalStartActionId">Gets or sets the global id of the start action.  &lt;br&gt;  Will contain the tour id in case of the start of the tour.  .</param>
        /// <param name="endActionId">Gets or sets the id of the end action.  &lt;br&gt;  When the guid is null the transit will end at the end of the tour.  .</param>
        /// <param name="globalEndActionId">Gets or sets the global id of the end action.  &lt;br&gt;  Will contain the tour id in case of the end of the tour.  .</param>
        /// <param name="distance">Gets or sets the distance in meter.</param>
        /// <param name="tollDistance">Gets or sets the toll distance in meter.</param>
        public TransitModel(Guid id = default(Guid), AddressModel startAddress = default(AddressModel), DateTime startDateTime = default(DateTime), AddressModel endAddress = default(AddressModel), DateTime endDateTime = default(DateTime), Guid? startActionId = default(Guid?), Guid? globalStartActionId = default(Guid?), Guid? endActionId = default(Guid?), Guid? globalEndActionId = default(Guid?), int distance = default(int), int tollDistance = default(int))
        {
            this.Id = id;
            this.StartAddress = startAddress;
            this.StartDateTime = startDateTime;
            this.EndAddress = endAddress;
            this.EndDateTime = endDateTime;
            this.StartActionId = startActionId;
            this.GlobalStartActionId = globalStartActionId;
            this.EndActionId = endActionId;
            this.GlobalEndActionId = globalEndActionId;
            this.Distance = distance;
            this.TollDistance = tollDistance;
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>Gets or sets the id.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets StartAddress
        /// </summary>
        [DataMember(Name = "startAddress", EmitDefaultValue = false)]
        public AddressModel StartAddress { get; set; }

        /// <summary>
        /// Gets or sets the start date time of the transit.
        /// </summary>
        /// <value>Gets or sets the start date time of the transit.</value>
        [DataMember(Name = "startDateTime", EmitDefaultValue = false)]
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// Gets or Sets EndAddress
        /// </summary>
        [DataMember(Name = "endAddress", EmitDefaultValue = false)]
        public AddressModel EndAddress { get; set; }

        /// <summary>
        /// Gets or sets the end date time off the transit.
        /// </summary>
        /// <value>Gets or sets the end date time off the transit.</value>
        [DataMember(Name = "endDateTime", EmitDefaultValue = false)]
        public DateTime EndDateTime { get; set; }

        /// <summary>
        /// Gets or sets the id of the start action.  &lt;br&gt;  When the guid is null the transit will start at the start of the tour.  
        /// </summary>
        /// <value>Gets or sets the id of the start action.  &lt;br&gt;  When the guid is null the transit will start at the start of the tour.  </value>
        [DataMember(Name = "startActionId", EmitDefaultValue = true)]
        public Guid? StartActionId { get; set; }

        /// <summary>
        /// Gets or sets the global id of the start action.  &lt;br&gt;  Will contain the tour id in case of the start of the tour.  
        /// </summary>
        /// <value>Gets or sets the global id of the start action.  &lt;br&gt;  Will contain the tour id in case of the start of the tour.  </value>
        [DataMember(Name = "globalStartActionId", EmitDefaultValue = true)]
        public Guid? GlobalStartActionId { get; set; }

        /// <summary>
        /// Gets or sets the id of the end action.  &lt;br&gt;  When the guid is null the transit will end at the end of the tour.  
        /// </summary>
        /// <value>Gets or sets the id of the end action.  &lt;br&gt;  When the guid is null the transit will end at the end of the tour.  </value>
        [DataMember(Name = "endActionId", EmitDefaultValue = true)]
        public Guid? EndActionId { get; set; }

        /// <summary>
        /// Gets or sets the global id of the end action.  &lt;br&gt;  Will contain the tour id in case of the end of the tour.  
        /// </summary>
        /// <value>Gets or sets the global id of the end action.  &lt;br&gt;  Will contain the tour id in case of the end of the tour.  </value>
        [DataMember(Name = "globalEndActionId", EmitDefaultValue = true)]
        public Guid? GlobalEndActionId { get; set; }

        /// <summary>
        /// Gets or sets the distance in meter
        /// </summary>
        /// <value>Gets or sets the distance in meter</value>
        [DataMember(Name = "distance", EmitDefaultValue = false)]
        public int Distance { get; set; }

        /// <summary>
        /// Gets or sets the toll distance in meter
        /// </summary>
        /// <value>Gets or sets the toll distance in meter</value>
        [DataMember(Name = "tollDistance", EmitDefaultValue = false)]
        public int TollDistance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransitModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StartAddress: ").Append(StartAddress).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndAddress: ").Append(EndAddress).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  StartActionId: ").Append(StartActionId).Append("\n");
            sb.Append("  GlobalStartActionId: ").Append(GlobalStartActionId).Append("\n");
            sb.Append("  EndActionId: ").Append(EndActionId).Append("\n");
            sb.Append("  GlobalEndActionId: ").Append(GlobalEndActionId).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  TollDistance: ").Append(TollDistance).Append("\n");
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
            return this.Equals(input as TransitModel);
        }

        /// <summary>
        /// Returns true if TransitModel instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.StartAddress == input.StartAddress ||
                    (this.StartAddress != null &&
                    this.StartAddress.Equals(input.StartAddress))
                ) && 
                (
                    this.StartDateTime == input.StartDateTime ||
                    (this.StartDateTime != null &&
                    this.StartDateTime.Equals(input.StartDateTime))
                ) && 
                (
                    this.EndAddress == input.EndAddress ||
                    (this.EndAddress != null &&
                    this.EndAddress.Equals(input.EndAddress))
                ) && 
                (
                    this.EndDateTime == input.EndDateTime ||
                    (this.EndDateTime != null &&
                    this.EndDateTime.Equals(input.EndDateTime))
                ) && 
                (
                    this.StartActionId == input.StartActionId ||
                    (this.StartActionId != null &&
                    this.StartActionId.Equals(input.StartActionId))
                ) && 
                (
                    this.GlobalStartActionId == input.GlobalStartActionId ||
                    (this.GlobalStartActionId != null &&
                    this.GlobalStartActionId.Equals(input.GlobalStartActionId))
                ) && 
                (
                    this.EndActionId == input.EndActionId ||
                    (this.EndActionId != null &&
                    this.EndActionId.Equals(input.EndActionId))
                ) && 
                (
                    this.GlobalEndActionId == input.GlobalEndActionId ||
                    (this.GlobalEndActionId != null &&
                    this.GlobalEndActionId.Equals(input.GlobalEndActionId))
                ) && 
                (
                    this.Distance == input.Distance ||
                    this.Distance.Equals(input.Distance)
                ) && 
                (
                    this.TollDistance == input.TollDistance ||
                    this.TollDistance.Equals(input.TollDistance)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.StartAddress != null)
                {
                    hashCode = (hashCode * 59) + this.StartAddress.GetHashCode();
                }
                if (this.StartDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartDateTime.GetHashCode();
                }
                if (this.EndAddress != null)
                {
                    hashCode = (hashCode * 59) + this.EndAddress.GetHashCode();
                }
                if (this.EndDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndDateTime.GetHashCode();
                }
                if (this.StartActionId != null)
                {
                    hashCode = (hashCode * 59) + this.StartActionId.GetHashCode();
                }
                if (this.GlobalStartActionId != null)
                {
                    hashCode = (hashCode * 59) + this.GlobalStartActionId.GetHashCode();
                }
                if (this.EndActionId != null)
                {
                    hashCode = (hashCode * 59) + this.EndActionId.GetHashCode();
                }
                if (this.GlobalEndActionId != null)
                {
                    hashCode = (hashCode * 59) + this.GlobalEndActionId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Distance.GetHashCode();
                hashCode = (hashCode * 59) + this.TollDistance.GetHashCode();
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