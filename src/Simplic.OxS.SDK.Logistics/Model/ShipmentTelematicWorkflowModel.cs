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
    /// Shared model of shipment telematic workflow.
    /// </summary>
    [DataContract(Name = "ShipmentTelematicWorkflowModel")]
    public partial class ShipmentTelematicWorkflowModel : IEquatable<ShipmentTelematicWorkflowModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentTelematicWorkflowModel" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the id.  &lt;br&gt;  Rerpesents the id of a telematic workflow.  .</param>
        /// <param name="name">Gets or sets the name.  &lt;br&gt;  Represents the display name of a telematic workflow.  .</param>
        public ShipmentTelematicWorkflowModel(Guid id = default(Guid), string name = default(string))
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the id.  &lt;br&gt;  Rerpesents the id of a telematic workflow.  
        /// </summary>
        /// <value>Gets or sets the id.  &lt;br&gt;  Rerpesents the id of a telematic workflow.  </value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.  &lt;br&gt;  Represents the display name of a telematic workflow.  
        /// </summary>
        /// <value>Gets or sets the name.  &lt;br&gt;  Represents the display name of a telematic workflow.  </value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentTelematicWorkflowModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as ShipmentTelematicWorkflowModel);
        }

        /// <summary>
        /// Returns true if ShipmentTelematicWorkflowModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipmentTelematicWorkflowModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipmentTelematicWorkflowModel input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
