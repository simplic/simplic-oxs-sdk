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
    /// CreateResourceGroupRequest
    /// </summary>
    [DataContract(Name = "CreateResourceGroupRequest")]
    public partial class CreateResourceGroupRequest : IEquatable<CreateResourceGroupRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResourceGroupRequest" /> class.
        /// </summary>
        /// <param name="name">The name of the resource group..</param>
        /// <param name="resourceIds">The resources in the resource group..</param>
        public CreateResourceGroupRequest(string name = default(string), List<Guid> resourceIds = default(List<Guid>))
        {
            this.Name = name;
            this.ResourceIds = resourceIds;
        }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        /// <value>The name of the resource group.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The resources in the resource group.
        /// </summary>
        /// <value>The resources in the resource group.</value>
        [DataMember(Name = "resourceIds", EmitDefaultValue = true)]
        public List<Guid> ResourceIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateResourceGroupRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as CreateResourceGroupRequest);
        }

        /// <summary>
        /// Returns true if CreateResourceGroupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateResourceGroupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateResourceGroupRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
