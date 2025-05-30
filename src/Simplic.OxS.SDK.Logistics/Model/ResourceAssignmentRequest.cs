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
    /// Request model for resource assignments.
    /// </summary>
    [DataContract(Name = "ResourceAssignmentRequest")]
    public partial class ResourceAssignmentRequest : IEquatable<ResourceAssignmentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAssignmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResourceAssignmentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAssignmentRequest" /> class.
        /// </summary>
        /// <param name="departmentId">Gets or sets the department id. (required).</param>
        /// <param name="resourceIds">Gets or sets the resource ids..</param>
        public ResourceAssignmentRequest(Guid departmentId = default(Guid), List<Guid> resourceIds = default(List<Guid>))
        {
            this.DepartmentId = departmentId;
            this.ResourceIds = resourceIds;
        }

        /// <summary>
        /// Gets or sets the department id.
        /// </summary>
        /// <value>Gets or sets the department id.</value>
        [DataMember(Name = "departmentId", IsRequired = true, EmitDefaultValue = true)]
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets the resource ids.
        /// </summary>
        /// <value>Gets or sets the resource ids.</value>
        [DataMember(Name = "resourceIds", EmitDefaultValue = true)]
        public List<Guid> ResourceIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResourceAssignmentRequest {\n");
            sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
            sb.Append("  ResourceIds: ").Append(ResourceIds).Append("\n");
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
            return this.Equals(input as ResourceAssignmentRequest);
        }

        /// <summary>
        /// Returns true if ResourceAssignmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceAssignmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceAssignmentRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DepartmentId == input.DepartmentId ||
                    (this.DepartmentId != null &&
                    this.DepartmentId.Equals(input.DepartmentId))
                ) && 
                (
                    this.ResourceIds == input.ResourceIds ||
                    this.ResourceIds != null &&
                    input.ResourceIds != null &&
                    this.ResourceIds.SequenceEqual(input.ResourceIds)
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
                if (this.DepartmentId != null)
                {
                    hashCode = (hashCode * 59) + this.DepartmentId.GetHashCode();
                }
                if (this.ResourceIds != null)
                {
                    hashCode = (hashCode * 59) + this.ResourceIds.GetHashCode();
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
