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
    /// ShipmentsToTourRequest
    /// </summary>
    [DataContract(Name = "ShipmentsToTourRequest")]
    public partial class ShipmentsToTourRequest : IEquatable<ShipmentsToTourRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentsToTourRequest" /> class.
        /// </summary>
        /// <param name="shipmentIds">shipmentIds.</param>
        /// <param name="resourceId">resourceId.</param>
        /// <param name="startDateTime">startDateTime.</param>
        /// <param name="endDateTime">endDateTime.</param>
        /// <param name="autoAssignResourceModes">autoAssignResourceModes.</param>
        public ShipmentsToTourRequest(List<Guid> shipmentIds = default(List<Guid>), Guid? resourceId = default(Guid?), DateTime startDateTime = default(DateTime), DateTime endDateTime = default(DateTime), List<string> autoAssignResourceModes = default(List<string>))
        {
            this.ShipmentIds = shipmentIds;
            this.ResourceId = resourceId;
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
            this.AutoAssignResourceModes = autoAssignResourceModes;
        }

        /// <summary>
        /// Gets or Sets ShipmentIds
        /// </summary>
        [DataMember(Name = "shipmentIds", EmitDefaultValue = true)]
        public List<Guid> ShipmentIds { get; set; }

        /// <summary>
        /// Gets or Sets ResourceId
        /// </summary>
        [DataMember(Name = "resourceId", EmitDefaultValue = true)]
        public Guid? ResourceId { get; set; }

        /// <summary>
        /// Gets or Sets StartDateTime
        /// </summary>
        [DataMember(Name = "startDateTime", EmitDefaultValue = false)]
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// Gets or Sets EndDateTime
        /// </summary>
        [DataMember(Name = "endDateTime", EmitDefaultValue = false)]
        public DateTime EndDateTime { get; set; }

        /// <summary>
        /// Gets or Sets AutoAssignResourceModes
        /// </summary>
        [DataMember(Name = "autoAssignResourceModes", EmitDefaultValue = true)]
        public List<string> AutoAssignResourceModes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentsToTourRequest {\n");
            sb.Append("  ShipmentIds: ").Append(ShipmentIds).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  AutoAssignResourceModes: ").Append(AutoAssignResourceModes).Append("\n");
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
            return this.Equals(input as ShipmentsToTourRequest);
        }

        /// <summary>
        /// Returns true if ShipmentsToTourRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentsToTourRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentsToTourRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ShipmentIds == input.ShipmentIds ||
                    this.ShipmentIds != null &&
                    input.ShipmentIds != null &&
                    this.ShipmentIds.SequenceEqual(input.ShipmentIds)
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
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
                    this.AutoAssignResourceModes == input.AutoAssignResourceModes ||
                    this.AutoAssignResourceModes != null &&
                    input.AutoAssignResourceModes != null &&
                    this.AutoAssignResourceModes.SequenceEqual(input.AutoAssignResourceModes)
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
                if (this.ShipmentIds != null)
                {
                    hashCode = (hashCode * 59) + this.ShipmentIds.GetHashCode();
                }
                if (this.ResourceId != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceId.GetHashCode();
                }
                if (this.StartDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartDateTime.GetHashCode();
                }
                if (this.EndDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndDateTime.GetHashCode();
                }
                if (this.AutoAssignResourceModes != null)
                {
                    hashCode = (hashCode * 59) + this.AutoAssignResourceModes.GetHashCode();
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
