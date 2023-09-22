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

namespace Simplic.OxS.SDK.Model
{
    /// <summary>
    /// Request model for patching shifted planning.
    /// </summary>
    [DataContract(Name = "PatchScheduledPlanningRequest")]
    public partial class PatchScheduledPlanningRequest : IEquatable<PatchScheduledPlanningRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchScheduledPlanningRequest" /> class.
        /// </summary>
        /// <param name="assignments">Gets or sets the assignments..</param>
        /// <param name="shiftId">Gets or sets the shift id..</param>
        /// <param name="startDate">Gets or sets the start date..</param>
        /// <param name="endDate">Gets or sets the end date..</param>
        public PatchScheduledPlanningRequest(List<ResourceAssignmentPatch> assignments = default(List<ResourceAssignmentPatch>), Guid? shiftId = default(Guid?), DateTime? startDate = default(DateTime?), DateTime? endDate = default(DateTime?))
        {
            this.Assignments = assignments;
            this.ShiftId = shiftId;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// Gets or sets the assignments.
        /// </summary>
        /// <value>Gets or sets the assignments.</value>
        [DataMember(Name = "assignments", EmitDefaultValue = true)]
        public List<ResourceAssignmentPatch> Assignments { get; set; }

        /// <summary>
        /// Gets or sets the shift id.
        /// </summary>
        /// <value>Gets or sets the shift id.</value>
        [DataMember(Name = "shiftId", EmitDefaultValue = true)]
        public Guid? ShiftId { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>Gets or sets the start date.</value>
        [DataMember(Name = "startDate", EmitDefaultValue = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>Gets or sets the end date.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchScheduledPlanningRequest {\n");
            sb.Append("  Assignments: ").Append(Assignments).Append("\n");
            sb.Append("  ShiftId: ").Append(ShiftId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(input as PatchScheduledPlanningRequest);
        }

        /// <summary>
        /// Returns true if PatchScheduledPlanningRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchScheduledPlanningRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchScheduledPlanningRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Assignments == input.Assignments ||
                    this.Assignments != null &&
                    input.Assignments != null &&
                    this.Assignments.SequenceEqual(input.Assignments)
                ) && 
                (
                    this.ShiftId == input.ShiftId ||
                    (this.ShiftId != null &&
                    this.ShiftId.Equals(input.ShiftId))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
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
                if (this.Assignments != null)
                {
                    hashCode = (hashCode * 59) + this.Assignments.GetHashCode();
                }
                if (this.ShiftId != null)
                {
                    hashCode = (hashCode * 59) + this.ShiftId.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
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
