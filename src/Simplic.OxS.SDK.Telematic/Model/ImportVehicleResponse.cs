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
    /// ImportVehicleResponse
    /// </summary>
    [DataContract(Name = "ImportVehicleResponse")]
    public partial class ImportVehicleResponse : IEquatable<ImportVehicleResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportVehicleResponse" /> class.
        /// </summary>
        /// <param name="registrationPlate">registrationPlate.</param>
        /// <param name="matchCode">matchCode.</param>
        /// <param name="externalIdentifier">externalIdentifier.</param>
        /// <param name="type">type.</param>
        public ImportVehicleResponse(string registrationPlate = default(string), string matchCode = default(string), string externalIdentifier = default(string), ImportVehicleTypeResponse type = default(ImportVehicleTypeResponse))
        {
            this.RegistrationPlate = registrationPlate;
            this.MatchCode = matchCode;
            this.ExternalIdentifier = externalIdentifier;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets RegistrationPlate
        /// </summary>
        [DataMember(Name = "registrationPlate", EmitDefaultValue = true)]
        public string RegistrationPlate { get; set; }

        /// <summary>
        /// Gets or Sets MatchCode
        /// </summary>
        [DataMember(Name = "matchCode", EmitDefaultValue = true)]
        public string MatchCode { get; set; }

        /// <summary>
        /// Gets or Sets ExternalIdentifier
        /// </summary>
        [DataMember(Name = "externalIdentifier", EmitDefaultValue = true)]
        public string ExternalIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ImportVehicleTypeResponse Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImportVehicleResponse {\n");
            sb.Append("  RegistrationPlate: ").Append(RegistrationPlate).Append("\n");
            sb.Append("  MatchCode: ").Append(MatchCode).Append("\n");
            sb.Append("  ExternalIdentifier: ").Append(ExternalIdentifier).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ImportVehicleResponse);
        }

        /// <summary>
        /// Returns true if ImportVehicleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ImportVehicleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportVehicleResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RegistrationPlate == input.RegistrationPlate ||
                    (this.RegistrationPlate != null &&
                    this.RegistrationPlate.Equals(input.RegistrationPlate))
                ) && 
                (
                    this.MatchCode == input.MatchCode ||
                    (this.MatchCode != null &&
                    this.MatchCode.Equals(input.MatchCode))
                ) && 
                (
                    this.ExternalIdentifier == input.ExternalIdentifier ||
                    (this.ExternalIdentifier != null &&
                    this.ExternalIdentifier.Equals(input.ExternalIdentifier))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.RegistrationPlate != null)
                {
                    hashCode = (hashCode * 59) + this.RegistrationPlate.GetHashCode();
                }
                if (this.MatchCode != null)
                {
                    hashCode = (hashCode * 59) + this.MatchCode.GetHashCode();
                }
                if (this.ExternalIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalIdentifier.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
