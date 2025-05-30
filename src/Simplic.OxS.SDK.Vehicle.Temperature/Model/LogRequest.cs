/*
 * Simplic.OxS.vehicle-temperature
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

namespace Simplic.OxS.SDK.Vehicle.Temperature
{
    /// <summary>
    /// LogRequest
    /// </summary>
    [DataContract(Name = "LogRequest")]
    public partial class LogRequest : IEquatable<LogRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogRequest" /> class.
        /// </summary>
        /// <param name="imei">imei.</param>
        /// <param name="sensorId">sensorId.</param>
        /// <param name="message">message.</param>
        /// <param name="type">type.</param>
        public LogRequest(string imei = default(string), string sensorId = default(string), string message = default(string), string type = default(string))
        {
            this.Imei = imei;
            this.SensorId = sensorId;
            this.Message = message;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Imei
        /// </summary>
        [DataMember(Name = "imei", EmitDefaultValue = true)]
        public string Imei { get; set; }

        /// <summary>
        /// Gets or Sets SensorId
        /// </summary>
        [DataMember(Name = "sensorId", EmitDefaultValue = true)]
        public string SensorId { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogRequest {\n");
            sb.Append("  Imei: ").Append(Imei).Append("\n");
            sb.Append("  SensorId: ").Append(SensorId).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as LogRequest);
        }

        /// <summary>
        /// Returns true if LogRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of LogRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Imei == input.Imei ||
                    (this.Imei != null &&
                    this.Imei.Equals(input.Imei))
                ) && 
                (
                    this.SensorId == input.SensorId ||
                    (this.SensorId != null &&
                    this.SensorId.Equals(input.SensorId))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Imei != null)
                {
                    hashCode = (hashCode * 59) + this.Imei.GetHashCode();
                }
                if (this.SensorId != null)
                {
                    hashCode = (hashCode * 59) + this.SensorId.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
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
