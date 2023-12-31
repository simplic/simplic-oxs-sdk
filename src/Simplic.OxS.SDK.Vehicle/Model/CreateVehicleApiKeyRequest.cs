/*
 * Simplic.OxS.Vehicle
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

namespace Simplic.OxS.SDK.Vehicle
{
    /// <summary>
    /// CreateVehicleApiKeyRequest
    /// </summary>
    [DataContract(Name = "CreateVehicleApiKeyRequest")]
    public partial class CreateVehicleApiKeyRequest : IEquatable<CreateVehicleApiKeyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVehicleApiKeyRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateVehicleApiKeyRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVehicleApiKeyRequest" /> class.
        /// </summary>
        /// <param name="vehicleId">vehicleId (required).</param>
        public CreateVehicleApiKeyRequest(Guid vehicleId = default(Guid))
        {
            this.VehicleId = vehicleId;
        }

        /// <summary>
        /// Gets or Sets VehicleId
        /// </summary>
        [DataMember(Name = "vehicleId", IsRequired = true, EmitDefaultValue = true)]
        public Guid VehicleId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateVehicleApiKeyRequest {\n");
            sb.Append("  VehicleId: ").Append(VehicleId).Append("\n");
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
            return this.Equals(input as CreateVehicleApiKeyRequest);
        }

        /// <summary>
        /// Returns true if CreateVehicleApiKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateVehicleApiKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateVehicleApiKeyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VehicleId == input.VehicleId ||
                    (this.VehicleId != null &&
                    this.VehicleId.Equals(input.VehicleId))
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
                if (this.VehicleId != null)
                {
                    hashCode = (hashCode * 59) + this.VehicleId.GetHashCode();
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
