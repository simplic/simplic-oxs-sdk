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
    /// DownloadReportRequest
    /// </summary>
    [DataContract(Name = "DownloadReportRequest")]
    public partial class DownloadReportRequest : IEquatable<DownloadReportRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadReportRequest" /> class.
        /// </summary>
        /// <param name="reportType">reportType.</param>
        /// <param name="vehicleId">vehicleId.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        public DownloadReportRequest(string reportType = default(string), Guid vehicleId = default(Guid), DateTime startDate = default(DateTime), DateTime endDate = default(DateTime))
        {
            this.ReportType = reportType;
            this.VehicleId = vehicleId;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// Gets or Sets ReportType
        /// </summary>
        [DataMember(Name = "reportType", EmitDefaultValue = true)]
        public string ReportType { get; set; }

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
            sb.Append("class DownloadReportRequest {\n");
            sb.Append("  ReportType: ").Append(ReportType).Append("\n");
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
            return this.Equals(input as DownloadReportRequest);
        }

        /// <summary>
        /// Returns true if DownloadReportRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DownloadReportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DownloadReportRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReportType == input.ReportType ||
                    (this.ReportType != null &&
                    this.ReportType.Equals(input.ReportType))
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
                if (this.ReportType != null)
                {
                    hashCode = (hashCode * 59) + this.ReportType.GetHashCode();
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
