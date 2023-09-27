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
    /// HookDefinitionResponse
    /// </summary>
    [DataContract(Name = "HookDefinitionResponse")]
    public partial class HookDefinitionResponse : IEquatable<HookDefinitionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HookDefinitionResponse" /> class.
        /// </summary>
        /// <param name="definitions">definitions.</param>
        public HookDefinitionResponse(List<HookDefinitionModel> definitions = default(List<HookDefinitionModel>))
        {
            this.Definitions = definitions;
        }

        /// <summary>
        /// Gets or Sets Definitions
        /// </summary>
        [DataMember(Name = "definitions", EmitDefaultValue = true)]
        public List<HookDefinitionModel> Definitions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HookDefinitionResponse {\n");
            sb.Append("  Definitions: ").Append(Definitions).Append("\n");
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
            return this.Equals(input as HookDefinitionResponse);
        }

        /// <summary>
        /// Returns true if HookDefinitionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of HookDefinitionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HookDefinitionResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Definitions == input.Definitions ||
                    this.Definitions != null &&
                    input.Definitions != null &&
                    this.Definitions.SequenceEqual(input.Definitions)
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
                if (this.Definitions != null)
                {
                    hashCode = (hashCode * 59) + this.Definitions.GetHashCode();
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
