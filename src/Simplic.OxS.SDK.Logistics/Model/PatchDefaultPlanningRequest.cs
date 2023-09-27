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

namespace Simplic.OxS.SDK.Logistics.Model
{
    /// <summary>
    /// Request model for patching default planning.
    /// </summary>
    [DataContract(Name = "PatchDefaultPlanningRequest")]
    public partial class PatchDefaultPlanningRequest : IEquatable<PatchDefaultPlanningRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchDefaultPlanningRequest" /> class.
        /// </summary>
        /// <param name="assignments">Gets or sets the assignments..</param>
        public PatchDefaultPlanningRequest(List<ResourceAssignmentPatch> assignments = default(List<ResourceAssignmentPatch>))
        {
            this.Assignments = assignments;
        }

        /// <summary>
        /// Gets or sets the assignments.
        /// </summary>
        /// <value>Gets or sets the assignments.</value>
        [DataMember(Name = "assignments", EmitDefaultValue = true)]
        public List<ResourceAssignmentPatch> Assignments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchDefaultPlanningRequest {\n");
            sb.Append("  Assignments: ").Append(Assignments).Append("\n");
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
            return this.Equals(input as PatchDefaultPlanningRequest);
        }

        /// <summary>
        /// Returns true if PatchDefaultPlanningRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchDefaultPlanningRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchDefaultPlanningRequest input)
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
