/*
 * Simplic.OxS.Telematic
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
using OpenAPIDateConverter = Simplic.OxS.SDK.Telematic.OpenAPIDateConverter;

namespace Simplic.OxS.SDK.Telematic
{
    /// <summary>
    /// PatchTelematicConfigurationRequest
    /// </summary>
    [DataContract(Name = "PatchTelematicConfigurationRequest")]
    public partial class PatchTelematicConfigurationRequest : IEquatable<PatchTelematicConfigurationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTelematicConfigurationRequest" /> class.
        /// </summary>
        /// <param name="providerConfiguration">providerConfiguration.</param>
        public PatchTelematicConfigurationRequest(PatchProviderConfiguration providerConfiguration = default(PatchProviderConfiguration))
        {
            this.ProviderConfiguration = providerConfiguration;
        }

        /// <summary>
        /// Gets or Sets ProviderConfiguration
        /// </summary>
        [DataMember(Name = "providerConfiguration", EmitDefaultValue = false)]
        public PatchProviderConfiguration ProviderConfiguration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchTelematicConfigurationRequest {\n");
            sb.Append("  ProviderConfiguration: ").Append(ProviderConfiguration).Append("\n");
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
            return this.Equals(input as PatchTelematicConfigurationRequest);
        }

        /// <summary>
        /// Returns true if PatchTelematicConfigurationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchTelematicConfigurationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchTelematicConfigurationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProviderConfiguration == input.ProviderConfiguration ||
                    (this.ProviderConfiguration != null &&
                    this.ProviderConfiguration.Equals(input.ProviderConfiguration))
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
                if (this.ProviderConfiguration != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderConfiguration.GetHashCode();
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
