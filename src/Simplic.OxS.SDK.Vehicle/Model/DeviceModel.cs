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
    /// DeviceModel
    /// </summary>
    [DataContract(Name = "DeviceModel")]
    public partial class DeviceModel : IEquatable<DeviceModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceModel" /> class.
        /// </summary>
        /// <param name="vehicles">vehicles.</param>
        public DeviceModel(List<DeviceVehicleModel> vehicles = default(List<DeviceVehicleModel>))
        {
            this.Vehicles = vehicles;
        }

        /// <summary>
        /// Gets or Sets Vehicles
        /// </summary>
        [DataMember(Name = "vehicles", EmitDefaultValue = true)]
        public List<DeviceVehicleModel> Vehicles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceModel {\n");
            sb.Append("  Vehicles: ").Append(Vehicles).Append("\n");
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
            return this.Equals(input as DeviceModel);
        }

        /// <summary>
        /// Returns true if DeviceModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Vehicles == input.Vehicles ||
                    this.Vehicles != null &&
                    input.Vehicles != null &&
                    this.Vehicles.SequenceEqual(input.Vehicles)
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
                if (this.Vehicles != null)
                {
                    hashCode = (hashCode * 59) + this.Vehicles.GetHashCode();
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