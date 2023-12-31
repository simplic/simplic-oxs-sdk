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
    /// SendReportRequest
    /// </summary>
    [DataContract(Name = "SendReportRequest")]
    public partial class SendReportRequest : IEquatable<SendReportRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendReportRequest" /> class.
        /// </summary>
        /// <param name="eMailAddresses">eMailAddresses.</param>
        /// <param name="note">note.</param>
        /// <param name="attachments">attachments.</param>
        /// <param name="vehicleId">vehicleId.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        public SendReportRequest(List<string> eMailAddresses = default(List<string>), string note = default(string), List<ReportAttachment> attachments = default(List<ReportAttachment>), Guid vehicleId = default(Guid), DateTime startDate = default(DateTime), DateTime endDate = default(DateTime))
        {
            this.EMailAddresses = eMailAddresses;
            this.Note = note;
            this.Attachments = attachments;
            this.VehicleId = vehicleId;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// Gets or Sets EMailAddresses
        /// </summary>
        [DataMember(Name = "eMailAddresses", EmitDefaultValue = true)]
        public List<string> EMailAddresses { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name = "note", EmitDefaultValue = true)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<ReportAttachment> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets VehicleId
        /// </summary>
        [DataMember(Name = "vehicleId", EmitDefaultValue = false)]
        public Guid VehicleId { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SendReportRequest {\n");
            sb.Append("  EMailAddresses: ").Append(EMailAddresses).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  VehicleId: ").Append(VehicleId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(input as SendReportRequest);
        }

        /// <summary>
        /// Returns true if SendReportRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SendReportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendReportRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EMailAddresses == input.EMailAddresses ||
                    this.EMailAddresses != null &&
                    input.EMailAddresses != null &&
                    this.EMailAddresses.SequenceEqual(input.EMailAddresses)
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.VehicleId == input.VehicleId ||
                    (this.VehicleId != null &&
                    this.VehicleId.Equals(input.VehicleId))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
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
                if (this.EMailAddresses != null)
                {
                    hashCode = (hashCode * 59) + this.EMailAddresses.GetHashCode();
                }
                if (this.Note != null)
                {
                    hashCode = (hashCode * 59) + this.Note.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.VehicleId != null)
                {
                    hashCode = (hashCode * 59) + this.VehicleId.GetHashCode();
                }
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
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
