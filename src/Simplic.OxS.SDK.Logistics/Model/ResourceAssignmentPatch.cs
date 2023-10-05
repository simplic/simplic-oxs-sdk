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
    /// Patch model for resource assignments.
    /// </summary>
    [DataContract(Name = "ResourceAssignmentPatch")]
    public partial class ResourceAssignmentPatch : IEquatable<ResourceAssignmentPatch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAssignmentPatch" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the id..</param>
        /// <param name="departmentId">Gets or sets the department id..</param>
        /// <param name="resources">Gets or sets the resource ids..</param>
        public ResourceAssignmentPatch(Guid id = default(Guid), Guid? departmentId = default(Guid?), List<Guid> resources = default(List<Guid>))
        {
            this.Id = id;
            this.DepartmentId = departmentId;
            this.Resources = resources;
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>Gets or sets the id.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the department id.
        /// </summary>
        /// <value>Gets or sets the department id.</value>
        [DataMember(Name = "departmentId", EmitDefaultValue = true)]
        public Guid? DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets the resource ids.
        /// </summary>
        /// <value>Gets or sets the resource ids.</value>
        [DataMember(Name = "resources", EmitDefaultValue = true)]
        public List<Guid> Resources { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResourceAssignmentPatch {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
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
            return this.Equals(input as ResourceAssignmentPatch);
        }

        /// <summary>
        /// Returns true if ResourceAssignmentPatch instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceAssignmentPatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceAssignmentPatch input)
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
                    this.DepartmentId == input.DepartmentId ||
                    (this.DepartmentId != null &&
                    this.DepartmentId.Equals(input.DepartmentId))
                ) && 
                (
                    this.Resources == input.Resources ||
                    this.Resources != null &&
                    input.Resources != null &&
                    this.Resources.SequenceEqual(input.Resources)
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
                if (this.DepartmentId != null)
                {
                    hashCode = (hashCode * 59) + this.DepartmentId.GetHashCode();
                }
                if (this.Resources != null)
                {
                    hashCode = (hashCode * 59) + this.Resources.GetHashCode();
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
