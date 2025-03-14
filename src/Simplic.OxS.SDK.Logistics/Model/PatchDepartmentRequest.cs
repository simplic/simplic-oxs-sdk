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
    /// Request model for patching Simplic.OxS.Logistics.Departments.
    /// </summary>
    [DataContract(Name = "PatchDepartmentRequest")]
    public partial class PatchDepartmentRequest : IEquatable<PatchDepartmentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchDepartmentRequest" /> class.
        /// </summary>
        /// <param name="name">Gets or sets the name..</param>
        /// <param name="orderId">Gets or sets the order id..</param>
        /// <param name="hexColor">Gets or sets the hex color..</param>
        public PatchDepartmentRequest(string name = default(string), int? orderId = default(int?), string hexColor = default(string))
        {
            this.Name = name;
            this.OrderId = orderId;
            this.HexColor = hexColor;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>Gets or sets the name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the order id.
        /// </summary>
        /// <value>Gets or sets the order id.</value>
        [DataMember(Name = "orderId", EmitDefaultValue = true)]
        public int? OrderId { get; set; }

        /// <summary>
        /// Gets or sets the hex color.
        /// </summary>
        /// <value>Gets or sets the hex color.</value>
        [DataMember(Name = "hexColor", EmitDefaultValue = true)]
        public string HexColor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchDepartmentRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  HexColor: ").Append(HexColor).Append("\n");
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
            return this.Equals(input as PatchDepartmentRequest);
        }

        /// <summary>
        /// Returns true if PatchDepartmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchDepartmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchDepartmentRequest input)
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
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.HexColor == input.HexColor ||
                    (this.HexColor != null &&
                    this.HexColor.Equals(input.HexColor))
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
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.HexColor != null)
                {
                    hashCode = (hashCode * 59) + this.HexColor.GetHashCode();
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
