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
    /// Request to create a tour tag.
    /// </summary>
    [DataContract(Name = "CreateTourTagRequest")]
    public partial class CreateTourTagRequest : IEquatable<CreateTourTagRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTourTagRequest" /> class.
        /// </summary>
        /// <param name="name">Gets or sets the name..</param>
        /// <param name="internalName">Gets or sets an internal tag name.</param>
        /// <param name="groupName">Gets or sets the group name.     Group names are a possibillity to group tags.   E.g. when just a single tag from a certain pool should be used.  .</param>
        /// <param name="hexColor">Gets or sets the hex color of the string..</param>
        /// <param name="functions">Gets or sets the functions of the tour tag.     Functions are used to add additional functionalities to a tour tag.  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;disable_edit: Disables editing the tour or action the tag is attached to.&lt;/item&gt;&lt;/list&gt;.</param>
        public CreateTourTagRequest(string name = default(string), string internalName = default(string), string groupName = default(string), string hexColor = default(string), List<string> functions = default(List<string>))
        {
            this.Name = name;
            this.InternalName = internalName;
            this.GroupName = groupName;
            this.HexColor = hexColor;
            this.Functions = functions;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets an internal tag name
        /// </summary>
        /// <value>Gets or sets an internal tag name</value>
        [DataMember(Name = "internalName", EmitDefaultValue = true)]
        public string InternalName { get; set; }

        /// <summary>
        /// Gets or sets the group name.     Group names are a possibillity to group tags.   E.g. when just a single tag from a certain pool should be used.  
        /// </summary>
        /// <value>Gets or sets the group name.     Group names are a possibillity to group tags.   E.g. when just a single tag from a certain pool should be used.  </value>
        [DataMember(Name = "groupName", EmitDefaultValue = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets the hex color of the string.
        /// </summary>
        /// <value>Gets or sets the hex color of the string.</value>
        [DataMember(Name = "hexColor", EmitDefaultValue = true)]
        public string HexColor { get; set; }

        /// <summary>
        /// Gets or sets the functions of the tour tag.     Functions are used to add additional functionalities to a tour tag.  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;disable_edit: Disables editing the tour or action the tag is attached to.&lt;/item&gt;&lt;/list&gt;
        /// </summary>
        /// <value>Gets or sets the functions of the tour tag.     Functions are used to add additional functionalities to a tour tag.  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;&lt;item&gt;disable_edit: Disables editing the tour or action the tag is attached to.&lt;/item&gt;&lt;/list&gt;</value>
        [DataMember(Name = "functions", EmitDefaultValue = true)]
        public List<string> Functions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTourTagRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InternalName: ").Append(InternalName).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  HexColor: ").Append(HexColor).Append("\n");
            sb.Append("  Functions: ").Append(Functions).Append("\n");
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
            return this.Equals(input as CreateTourTagRequest);
        }

        /// <summary>
        /// Returns true if CreateTourTagRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTourTagRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTourTagRequest input)
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
                    this.InternalName == input.InternalName ||
                    (this.InternalName != null &&
                    this.InternalName.Equals(input.InternalName))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.HexColor == input.HexColor ||
                    (this.HexColor != null &&
                    this.HexColor.Equals(input.HexColor))
                ) && 
                (
                    this.Functions == input.Functions ||
                    this.Functions != null &&
                    input.Functions != null &&
                    this.Functions.SequenceEqual(input.Functions)
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
                if (this.InternalName != null)
                {
                    hashCode = (hashCode * 59) + this.InternalName.GetHashCode();
                }
                if (this.GroupName != null)
                {
                    hashCode = (hashCode * 59) + this.GroupName.GetHashCode();
                }
                if (this.HexColor != null)
                {
                    hashCode = (hashCode * 59) + this.HexColor.GetHashCode();
                }
                if (this.Functions != null)
                {
                    hashCode = (hashCode * 59) + this.Functions.GetHashCode();
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
