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
    /// VehicleConfigurationModel
    /// </summary>
    [DataContract(Name = "VehicleConfigurationModel")]
    public partial class VehicleConfigurationModel : IEquatable<VehicleConfigurationModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleConfigurationModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="vehicleId">vehicleId.</param>
        /// <param name="matchCode">matchCode.</param>
        /// <param name="providerName">providerName.</param>
        /// <param name="externalVehicleIdentifier">externalVehicleIdentifier.</param>
        /// <param name="validFrom">validFrom.</param>
        /// <param name="validTo">validTo.</param>
        /// <param name="activeServices">activeServices.</param>
        public VehicleConfigurationModel(Guid id = default(Guid), Guid vehicleId = default(Guid), string matchCode = default(string), string providerName = default(string), string externalVehicleIdentifier = default(string), DateTime? validFrom = default(DateTime?), DateTime? validTo = default(DateTime?), List<string> activeServices = default(List<string>))
        {
            this.Id = id;
            this.VehicleId = vehicleId;
            this.MatchCode = matchCode;
            this.ProviderName = providerName;
            this.ExternalVehicleIdentifier = externalVehicleIdentifier;
            this.ValidFrom = validFrom;
            this.ValidTo = validTo;
            this.ActiveServices = activeServices;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets VehicleId
        /// </summary>
        [DataMember(Name = "vehicleId", EmitDefaultValue = false)]
        public Guid VehicleId { get; set; }

        /// <summary>
        /// Gets or Sets MatchCode
        /// </summary>
        [DataMember(Name = "matchCode", EmitDefaultValue = true)]
        public string MatchCode { get; set; }

        /// <summary>
        /// Gets or Sets ProviderName
        /// </summary>
        [DataMember(Name = "providerName", EmitDefaultValue = true)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Gets or Sets ExternalVehicleIdentifier
        /// </summary>
        [DataMember(Name = "externalVehicleIdentifier", EmitDefaultValue = true)]
        public string ExternalVehicleIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets ValidFrom
        /// </summary>
        [DataMember(Name = "validFrom", EmitDefaultValue = true)]
        public DateTime? ValidFrom { get; set; }

        /// <summary>
        /// Gets or Sets ValidTo
        /// </summary>
        [DataMember(Name = "validTo", EmitDefaultValue = true)]
        public DateTime? ValidTo { get; set; }

        /// <summary>
        /// Gets or Sets ActiveServices
        /// </summary>
        [DataMember(Name = "activeServices", EmitDefaultValue = true)]
        public List<string> ActiveServices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VehicleConfigurationModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VehicleId: ").Append(VehicleId).Append("\n");
            sb.Append("  MatchCode: ").Append(MatchCode).Append("\n");
            sb.Append("  ProviderName: ").Append(ProviderName).Append("\n");
            sb.Append("  ExternalVehicleIdentifier: ").Append(ExternalVehicleIdentifier).Append("\n");
            sb.Append("  ValidFrom: ").Append(ValidFrom).Append("\n");
            sb.Append("  ValidTo: ").Append(ValidTo).Append("\n");
            sb.Append("  ActiveServices: ").Append(ActiveServices).Append("\n");
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
            return this.Equals(input as VehicleConfigurationModel);
        }

        /// <summary>
        /// Returns true if VehicleConfigurationModel instances are equal
        /// </summary>
        /// <param name="input">Instance of VehicleConfigurationModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VehicleConfigurationModel input)
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
                    this.VehicleId == input.VehicleId ||
                    (this.VehicleId != null &&
                    this.VehicleId.Equals(input.VehicleId))
                ) && 
                (
                    this.MatchCode == input.MatchCode ||
                    (this.MatchCode != null &&
                    this.MatchCode.Equals(input.MatchCode))
                ) && 
                (
                    this.ProviderName == input.ProviderName ||
                    (this.ProviderName != null &&
                    this.ProviderName.Equals(input.ProviderName))
                ) && 
                (
                    this.ExternalVehicleIdentifier == input.ExternalVehicleIdentifier ||
                    (this.ExternalVehicleIdentifier != null &&
                    this.ExternalVehicleIdentifier.Equals(input.ExternalVehicleIdentifier))
                ) && 
                (
                    this.ValidFrom == input.ValidFrom ||
                    (this.ValidFrom != null &&
                    this.ValidFrom.Equals(input.ValidFrom))
                ) && 
                (
                    this.ValidTo == input.ValidTo ||
                    (this.ValidTo != null &&
                    this.ValidTo.Equals(input.ValidTo))
                ) && 
                (
                    this.ActiveServices == input.ActiveServices ||
                    this.ActiveServices != null &&
                    input.ActiveServices != null &&
                    this.ActiveServices.SequenceEqual(input.ActiveServices)
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
                if (this.VehicleId != null)
                {
                    hashCode = (hashCode * 59) + this.VehicleId.GetHashCode();
                }
                if (this.MatchCode != null)
                {
                    hashCode = (hashCode * 59) + this.MatchCode.GetHashCode();
                }
                if (this.ProviderName != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderName.GetHashCode();
                }
                if (this.ExternalVehicleIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalVehicleIdentifier.GetHashCode();
                }
                if (this.ValidFrom != null)
                {
                    hashCode = (hashCode * 59) + this.ValidFrom.GetHashCode();
                }
                if (this.ValidTo != null)
                {
                    hashCode = (hashCode * 59) + this.ValidTo.GetHashCode();
                }
                if (this.ActiveServices != null)
                {
                    hashCode = (hashCode * 59) + this.ActiveServices.GetHashCode();
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
