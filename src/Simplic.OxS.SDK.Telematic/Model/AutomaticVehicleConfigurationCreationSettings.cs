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
using OpenAPIDateConverter = Simplic.OxS.SDK.OpenAPIDateConverter;

using Simplic.OxS.SDK;

namespace Simplic.OxS.SDK.Telematic
{
    /// <summary>
    /// AutomaticVehicleConfigurationCreationSettings
    /// </summary>
    [DataContract(Name = "AutomaticVehicleConfigurationCreationSettings")]
    public partial class AutomaticVehicleConfigurationCreationSettings : IEquatable<AutomaticVehicleConfigurationCreationSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticVehicleConfigurationCreationSettings" /> class.
        /// </summary>
        /// <param name="vehicleType">vehicleType.</param>
        /// <param name="externalVehicleIdentifierTemplate">externalVehicleIdentifierTemplate.</param>
        /// <param name="createInTelematicSystem">createInTelematicSystem.</param>
        public AutomaticVehicleConfigurationCreationSettings(string vehicleType = default(string), string externalVehicleIdentifierTemplate = default(string), bool createInTelematicSystem = default(bool))
        {
            this.VehicleType = vehicleType;
            this.ExternalVehicleIdentifierTemplate = externalVehicleIdentifierTemplate;
            this.CreateInTelematicSystem = createInTelematicSystem;
        }

        /// <summary>
        /// Gets or Sets VehicleType
        /// </summary>
        [DataMember(Name = "vehicleType", EmitDefaultValue = true)]
        public string VehicleType { get; set; }

        /// <summary>
        /// Gets or Sets ExternalVehicleIdentifierTemplate
        /// </summary>
        [DataMember(Name = "externalVehicleIdentifierTemplate", EmitDefaultValue = true)]
        public string ExternalVehicleIdentifierTemplate { get; set; }

        /// <summary>
        /// Gets or Sets CreateInTelematicSystem
        /// </summary>
        [DataMember(Name = "createInTelematicSystem", EmitDefaultValue = true)]
        public bool CreateInTelematicSystem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AutomaticVehicleConfigurationCreationSettings {\n");
            sb.Append("  VehicleType: ").Append(VehicleType).Append("\n");
            sb.Append("  ExternalVehicleIdentifierTemplate: ").Append(ExternalVehicleIdentifierTemplate).Append("\n");
            sb.Append("  CreateInTelematicSystem: ").Append(CreateInTelematicSystem).Append("\n");
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
            return this.Equals(input as AutomaticVehicleConfigurationCreationSettings);
        }

        /// <summary>
        /// Returns true if AutomaticVehicleConfigurationCreationSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of AutomaticVehicleConfigurationCreationSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutomaticVehicleConfigurationCreationSettings input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VehicleType == input.VehicleType ||
                    (this.VehicleType != null &&
                    this.VehicleType.Equals(input.VehicleType))
                ) && 
                (
                    this.ExternalVehicleIdentifierTemplate == input.ExternalVehicleIdentifierTemplate ||
                    (this.ExternalVehicleIdentifierTemplate != null &&
                    this.ExternalVehicleIdentifierTemplate.Equals(input.ExternalVehicleIdentifierTemplate))
                ) && 
                (
                    this.CreateInTelematicSystem == input.CreateInTelematicSystem ||
                    this.CreateInTelematicSystem.Equals(input.CreateInTelematicSystem)
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
                if (this.VehicleType != null)
                {
                    hashCode = (hashCode * 59) + this.VehicleType.GetHashCode();
                }
                if (this.ExternalVehicleIdentifierTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalVehicleIdentifierTemplate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreateInTelematicSystem.GetHashCode();
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
