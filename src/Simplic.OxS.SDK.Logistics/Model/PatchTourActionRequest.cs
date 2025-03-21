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
    /// Shared model of a tour action.
    /// </summary>
    [DataContract(Name = "PatchTourActionRequest")]
    public partial class PatchTourActionRequest : IEquatable<PatchTourActionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTourActionRequest" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the id..</param>
        /// <param name="orderId">Gets or sets the order id in which the actions are processed..</param>
        /// <param name="dateTime">Gets or sets the date time.     Represents the planned date and time of the action.  .</param>
        /// <param name="actualDateTime">Gets or sets the actual date time.     Represents the actual date and time of the action.  .</param>
        /// <param name="calculatedDateTime">Gets or sets the calculated date time.     Represents the calculated date and time of the action.  .</param>
        /// <param name="mirroredTourNumber">Gets or sets the tour number of the mirrored tour.     The tour number will be used to make sure that all generated tours from this action have the same   tour number.  .</param>
        /// <param name="type">Gets or sets the type..</param>
        /// <param name="notes">Gets or sets notes, which are attached to the current action in the tour.</param>
        /// <param name="entityId">Gets or sets the id to resolve the entity..</param>
        /// <param name="resourceId">Gets or sets the id to resolve the resource..</param>
        /// <param name="addressId">Gets or sets the id to resolve the address..</param>
        /// <param name="mirroredTourTags">Gets or sets the mirrored tour tags.      The mirrored tour tags will be used to add tags to the mirrored tour.  .</param>
        /// <param name="remove">Remove flag for the patch helper..</param>
        /// <param name="cleaningSlots">Gets or sets a list of used loading slots..</param>
        /// <param name="usedLoadingSlots">Gets or sets a list of used loading slots..</param>
        public PatchTourActionRequest(Guid id = default(Guid), int orderId = default(int), DateTime? dateTime = default(DateTime?), DateTime? actualDateTime = default(DateTime?), DateTime? calculatedDateTime = default(DateTime?), string mirroredTourNumber = default(string), string type = default(string), string notes = default(string), Guid? entityId = default(Guid?), Guid? resourceId = default(Guid?), Guid? addressId = default(Guid?), List<Guid> mirroredTourTags = default(List<Guid>), bool remove = default(bool), List<PatchLoadingSlotRequest> cleaningSlots = default(List<PatchLoadingSlotRequest>), List<PatchLoadingSlotRequest> usedLoadingSlots = default(List<PatchLoadingSlotRequest>))
        {
            this.Id = id;
            this.OrderId = orderId;
            this.DateTime = dateTime;
            this.ActualDateTime = actualDateTime;
            this.CalculatedDateTime = calculatedDateTime;
            this.MirroredTourNumber = mirroredTourNumber;
            this.Type = type;
            this.Notes = notes;
            this.EntityId = entityId;
            this.ResourceId = resourceId;
            this.AddressId = addressId;
            this.MirroredTourTags = mirroredTourTags;
            this.Remove = remove;
            this.CleaningSlots = cleaningSlots;
            this.UsedLoadingSlots = usedLoadingSlots;
        }

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
        /// Gets or sets the date time.     Represents the planned date and time of the action.  
        /// </summary>
        /// <value>Gets or sets the date time.     Represents the planned date and time of the action.  </value>
        [DataMember(Name = "dateTime", EmitDefaultValue = true)]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// Gets or sets the actual date time.     Represents the actual date and time of the action.  
        /// </summary>
        /// <value>Gets or sets the actual date time.     Represents the actual date and time of the action.  </value>
        [DataMember(Name = "actualDateTime", EmitDefaultValue = true)]
        public DateTime? ActualDateTime { get; set; }

        /// <summary>
        /// Gets or sets the calculated date time.     Represents the calculated date and time of the action.  
        /// </summary>
        /// <value>Gets or sets the calculated date time.     Represents the calculated date and time of the action.  </value>
        [DataMember(Name = "calculatedDateTime", EmitDefaultValue = true)]
        public DateTime? CalculatedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the tour number of the mirrored tour.     The tour number will be used to make sure that all generated tours from this action have the same   tour number.  
        /// </summary>
        /// <value>Gets or sets the tour number of the mirrored tour.     The tour number will be used to make sure that all generated tours from this action have the same   tour number.  </value>
        [DataMember(Name = "mirroredTourNumber", EmitDefaultValue = true)]
        public string MirroredTourNumber { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>Gets or sets the type.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets notes, which are attached to the current action in the tour
        /// </summary>
        /// <value>Gets or sets notes, which are attached to the current action in the tour</value>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets the id to resolve the entity.
        /// </summary>
        /// <value>Gets or sets the id to resolve the entity.</value>
        [DataMember(Name = "entityId", EmitDefaultValue = true)]
        public Guid? EntityId { get; set; }

        /// <summary>
        /// Gets or sets the id to resolve the resource.
        /// </summary>
        /// <value>Gets or sets the id to resolve the resource.</value>
        [DataMember(Name = "resourceId", EmitDefaultValue = true)]
        public Guid? ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the id to resolve the address.
        /// </summary>
        /// <value>Gets or sets the id to resolve the address.</value>
        [DataMember(Name = "addressId", EmitDefaultValue = true)]
        public Guid? AddressId { get; set; }

        /// <summary>
        /// Gets or sets the mirrored tour tags.      The mirrored tour tags will be used to add tags to the mirrored tour.  
        /// </summary>
        /// <value>Gets or sets the mirrored tour tags.      The mirrored tour tags will be used to add tags to the mirrored tour.  </value>
        [DataMember(Name = "mirroredTourTags", EmitDefaultValue = true)]
        public List<Guid> MirroredTourTags { get; set; }

        /// <summary>
        /// Remove flag for the patch helper.
        /// </summary>
        /// <value>Remove flag for the patch helper.</value>
        [DataMember(Name = "_remove", EmitDefaultValue = true)]
        public bool Remove { get; set; }

        /// <summary>
        /// Gets or sets a list of used loading slots.
        /// </summary>
        /// <value>Gets or sets a list of used loading slots.</value>
        [DataMember(Name = "cleaningSlots", EmitDefaultValue = true)]
        public List<PatchLoadingSlotRequest> CleaningSlots { get; set; }

        /// <summary>
        /// Gets or sets a list of used loading slots.
        /// </summary>
        /// <value>Gets or sets a list of used loading slots.</value>
        [DataMember(Name = "usedLoadingSlots", EmitDefaultValue = true)]
        public List<PatchLoadingSlotRequest> UsedLoadingSlots { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchTourActionRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  ActualDateTime: ").Append(ActualDateTime).Append("\n");
            sb.Append("  CalculatedDateTime: ").Append(CalculatedDateTime).Append("\n");
            sb.Append("  MirroredTourNumber: ").Append(MirroredTourNumber).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  AddressId: ").Append(AddressId).Append("\n");
            sb.Append("  MirroredTourTags: ").Append(MirroredTourTags).Append("\n");
            sb.Append("  Remove: ").Append(Remove).Append("\n");
            sb.Append("  CleaningSlots: ").Append(CleaningSlots).Append("\n");
            sb.Append("  UsedLoadingSlots: ").Append(UsedLoadingSlots).Append("\n");
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
            return this.Equals(input as PatchTourActionRequest);
        }

        /// <summary>
        /// Returns true if PatchTourActionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchTourActionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchTourActionRequest input)
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
                    this.OrderId == input.OrderId ||
                    this.OrderId.Equals(input.OrderId)
                ) && 
                (
                    this.DateTime == input.DateTime ||
                    (this.DateTime != null &&
                    this.DateTime.Equals(input.DateTime))
                ) && 
                (
                    this.ActualDateTime == input.ActualDateTime ||
                    (this.ActualDateTime != null &&
                    this.ActualDateTime.Equals(input.ActualDateTime))
                ) && 
                (
                    this.CalculatedDateTime == input.CalculatedDateTime ||
                    (this.CalculatedDateTime != null &&
                    this.CalculatedDateTime.Equals(input.CalculatedDateTime))
                ) && 
                (
                    this.MirroredTourNumber == input.MirroredTourNumber ||
                    (this.MirroredTourNumber != null &&
                    this.MirroredTourNumber.Equals(input.MirroredTourNumber))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.AddressId == input.AddressId ||
                    (this.AddressId != null &&
                    this.AddressId.Equals(input.AddressId))
                ) && 
                (
                    this.MirroredTourTags == input.MirroredTourTags ||
                    this.MirroredTourTags != null &&
                    input.MirroredTourTags != null &&
                    this.MirroredTourTags.SequenceEqual(input.MirroredTourTags)
                ) && 
                (
                    this.Remove == input.Remove ||
                    this.Remove.Equals(input.Remove)
                ) && 
                (
                    this.CleaningSlots == input.CleaningSlots ||
                    this.CleaningSlots != null &&
                    input.CleaningSlots != null &&
                    this.CleaningSlots.SequenceEqual(input.CleaningSlots)
                ) && 
                (
                    this.UsedLoadingSlots == input.UsedLoadingSlots ||
                    this.UsedLoadingSlots != null &&
                    input.UsedLoadingSlots != null &&
                    this.UsedLoadingSlots.SequenceEqual(input.UsedLoadingSlots)
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
                hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                if (this.DateTime != null)
                {
                    hashCode = (hashCode * 59) + this.DateTime.GetHashCode();
                }
                if (this.ActualDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.ActualDateTime.GetHashCode();
                }
                if (this.CalculatedDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CalculatedDateTime.GetHashCode();
                }
                if (this.MirroredTourNumber != null)
                {
                    hashCode = (hashCode * 59) + this.MirroredTourNumber.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Notes != null)
                {
                    hashCode = (hashCode * 59) + this.Notes.GetHashCode();
                }
                if (this.EntityId != null)
                {
                    hashCode = (hashCode * 59) + this.EntityId.GetHashCode();
                }
                if (this.ResourceId != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceId.GetHashCode();
                }
                if (this.AddressId != null)
                {
                    hashCode = (hashCode * 59) + this.AddressId.GetHashCode();
                }
                if (this.MirroredTourTags != null)
                {
                    hashCode = (hashCode * 59) + this.MirroredTourTags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Remove.GetHashCode();
                if (this.CleaningSlots != null)
                {
                    hashCode = (hashCode * 59) + this.CleaningSlots.GetHashCode();
                }
                if (this.UsedLoadingSlots != null)
                {
                    hashCode = (hashCode * 59) + this.UsedLoadingSlots.GetHashCode();
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
