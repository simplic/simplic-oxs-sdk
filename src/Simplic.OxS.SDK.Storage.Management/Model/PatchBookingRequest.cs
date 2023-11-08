/*
 * Simplic.OxS.storage-management
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

namespace Simplic.OxS.SDK.Storage.Management
{
    /// <summary>
    /// PatchBookingRequest
    /// </summary>
    [DataContract(Name = "PatchBookingRequest")]
    public partial class PatchBookingRequest : IEquatable<PatchBookingRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatchBookingRequest" /> class.
        /// </summary>
        /// <param name="customerId">customerId.</param>
        /// <param name="locationId">locationId.</param>
        /// <param name="isExternalDriver">isExternalDriver.</param>
        /// <param name="driverExt">driverExt.</param>
        /// <param name="driverId">driverId.</param>
        /// <param name="isExternalTractorUnit">isExternalTractorUnit.</param>
        /// <param name="tractorUnitExt">tractorUnitExt.</param>
        /// <param name="tractorUnitId">tractorUnitId.</param>
        /// <param name="isUnknownCarrier">isUnknownCarrier.</param>
        /// <param name="carrierExt">carrierExt.</param>
        /// <param name="carrierId">carrierId.</param>
        /// <param name="date">date.</param>
        /// <param name="signatureUrl">signatureUrl.</param>
        /// <param name="loadingAids">loadingAids.</param>
        /// <param name="images">images.</param>
        public PatchBookingRequest(Guid customerId = default(Guid), Guid locationId = default(Guid), bool? isExternalDriver = default(bool?), string driverExt = default(string), Guid? driverId = default(Guid?), bool? isExternalTractorUnit = default(bool?), string tractorUnitExt = default(string), Guid? tractorUnitId = default(Guid?), bool? isUnknownCarrier = default(bool?), string carrierExt = default(string), Guid? carrierId = default(Guid?), DateTime? date = default(DateTime?), Guid? signatureUrl = default(Guid?), List<LoadingAid> loadingAids = default(List<LoadingAid>), List<Guid> images = default(List<Guid>))
        {
            this.CustomerId = customerId;
            this.LocationId = locationId;
            this.IsExternalDriver = isExternalDriver;
            this.DriverExt = driverExt;
            this.DriverId = driverId;
            this.IsExternalTractorUnit = isExternalTractorUnit;
            this.TractorUnitExt = tractorUnitExt;
            this.TractorUnitId = tractorUnitId;
            this.IsUnknownCarrier = isUnknownCarrier;
            this.CarrierExt = carrierExt;
            this.CarrierId = carrierId;
            this.Date = date;
            this.SignatureUrl = signatureUrl;
            this.LoadingAids = loadingAids;
            this.Images = images;
        }

        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name = "customerId", EmitDefaultValue = false)]
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name = "locationId", EmitDefaultValue = false)]
        public Guid LocationId { get; set; }

        /// <summary>
        /// Gets or Sets IsExternalDriver
        /// </summary>
        [DataMember(Name = "isExternalDriver", EmitDefaultValue = true)]
        public bool? IsExternalDriver { get; set; }

        /// <summary>
        /// Gets or Sets DriverExt
        /// </summary>
        [DataMember(Name = "driverExt", EmitDefaultValue = true)]
        public string DriverExt { get; set; }

        /// <summary>
        /// Gets or Sets DriverId
        /// </summary>
        [DataMember(Name = "driverId", EmitDefaultValue = true)]
        public Guid? DriverId { get; set; }

        /// <summary>
        /// Gets or Sets IsExternalTractorUnit
        /// </summary>
        [DataMember(Name = "isExternalTractorUnit", EmitDefaultValue = true)]
        public bool? IsExternalTractorUnit { get; set; }

        /// <summary>
        /// Gets or Sets TractorUnitExt
        /// </summary>
        [DataMember(Name = "tractorUnitExt", EmitDefaultValue = true)]
        public string TractorUnitExt { get; set; }

        /// <summary>
        /// Gets or Sets TractorUnitId
        /// </summary>
        [DataMember(Name = "tractorUnitId", EmitDefaultValue = true)]
        public Guid? TractorUnitId { get; set; }

        /// <summary>
        /// Gets or Sets IsUnknownCarrier
        /// </summary>
        [DataMember(Name = "isUnknownCarrier", EmitDefaultValue = true)]
        public bool? IsUnknownCarrier { get; set; }

        /// <summary>
        /// Gets or Sets CarrierExt
        /// </summary>
        [DataMember(Name = "carrierExt", EmitDefaultValue = true)]
        public string CarrierExt { get; set; }

        /// <summary>
        /// Gets or Sets CarrierId
        /// </summary>
        [DataMember(Name = "carrierId", EmitDefaultValue = true)]
        public Guid? CarrierId { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = true)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or Sets SignatureUrl
        /// </summary>
        [DataMember(Name = "signatureUrl", EmitDefaultValue = true)]
        public Guid? SignatureUrl { get; set; }

        /// <summary>
        /// Gets or Sets LoadingAids
        /// </summary>
        [DataMember(Name = "loadingAids", EmitDefaultValue = true)]
        public List<LoadingAid> LoadingAids { get; set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name = "images", EmitDefaultValue = true)]
        public List<Guid> Images { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchBookingRequest {\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  IsExternalDriver: ").Append(IsExternalDriver).Append("\n");
            sb.Append("  DriverExt: ").Append(DriverExt).Append("\n");
            sb.Append("  DriverId: ").Append(DriverId).Append("\n");
            sb.Append("  IsExternalTractorUnit: ").Append(IsExternalTractorUnit).Append("\n");
            sb.Append("  TractorUnitExt: ").Append(TractorUnitExt).Append("\n");
            sb.Append("  TractorUnitId: ").Append(TractorUnitId).Append("\n");
            sb.Append("  IsUnknownCarrier: ").Append(IsUnknownCarrier).Append("\n");
            sb.Append("  CarrierExt: ").Append(CarrierExt).Append("\n");
            sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  SignatureUrl: ").Append(SignatureUrl).Append("\n");
            sb.Append("  LoadingAids: ").Append(LoadingAids).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
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
            return this.Equals(input as PatchBookingRequest);
        }

        /// <summary>
        /// Returns true if PatchBookingRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PatchBookingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PatchBookingRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.LocationId == input.LocationId ||
                    (this.LocationId != null &&
                    this.LocationId.Equals(input.LocationId))
                ) && 
                (
                    this.IsExternalDriver == input.IsExternalDriver ||
                    (this.IsExternalDriver != null &&
                    this.IsExternalDriver.Equals(input.IsExternalDriver))
                ) && 
                (
                    this.DriverExt == input.DriverExt ||
                    (this.DriverExt != null &&
                    this.DriverExt.Equals(input.DriverExt))
                ) && 
                (
                    this.DriverId == input.DriverId ||
                    (this.DriverId != null &&
                    this.DriverId.Equals(input.DriverId))
                ) && 
                (
                    this.IsExternalTractorUnit == input.IsExternalTractorUnit ||
                    (this.IsExternalTractorUnit != null &&
                    this.IsExternalTractorUnit.Equals(input.IsExternalTractorUnit))
                ) && 
                (
                    this.TractorUnitExt == input.TractorUnitExt ||
                    (this.TractorUnitExt != null &&
                    this.TractorUnitExt.Equals(input.TractorUnitExt))
                ) && 
                (
                    this.TractorUnitId == input.TractorUnitId ||
                    (this.TractorUnitId != null &&
                    this.TractorUnitId.Equals(input.TractorUnitId))
                ) && 
                (
                    this.IsUnknownCarrier == input.IsUnknownCarrier ||
                    (this.IsUnknownCarrier != null &&
                    this.IsUnknownCarrier.Equals(input.IsUnknownCarrier))
                ) && 
                (
                    this.CarrierExt == input.CarrierExt ||
                    (this.CarrierExt != null &&
                    this.CarrierExt.Equals(input.CarrierExt))
                ) && 
                (
                    this.CarrierId == input.CarrierId ||
                    (this.CarrierId != null &&
                    this.CarrierId.Equals(input.CarrierId))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.SignatureUrl == input.SignatureUrl ||
                    (this.SignatureUrl != null &&
                    this.SignatureUrl.Equals(input.SignatureUrl))
                ) && 
                (
                    this.LoadingAids == input.LoadingAids ||
                    this.LoadingAids != null &&
                    input.LoadingAids != null &&
                    this.LoadingAids.SequenceEqual(input.LoadingAids)
                ) && 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
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
                if (this.CustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerId.GetHashCode();
                }
                if (this.LocationId != null)
                {
                    hashCode = (hashCode * 59) + this.LocationId.GetHashCode();
                }
                if (this.IsExternalDriver != null)
                {
                    hashCode = (hashCode * 59) + this.IsExternalDriver.GetHashCode();
                }
                if (this.DriverExt != null)
                {
                    hashCode = (hashCode * 59) + this.DriverExt.GetHashCode();
                }
                if (this.DriverId != null)
                {
                    hashCode = (hashCode * 59) + this.DriverId.GetHashCode();
                }
                if (this.IsExternalTractorUnit != null)
                {
                    hashCode = (hashCode * 59) + this.IsExternalTractorUnit.GetHashCode();
                }
                if (this.TractorUnitExt != null)
                {
                    hashCode = (hashCode * 59) + this.TractorUnitExt.GetHashCode();
                }
                if (this.TractorUnitId != null)
                {
                    hashCode = (hashCode * 59) + this.TractorUnitId.GetHashCode();
                }
                if (this.IsUnknownCarrier != null)
                {
                    hashCode = (hashCode * 59) + this.IsUnknownCarrier.GetHashCode();
                }
                if (this.CarrierExt != null)
                {
                    hashCode = (hashCode * 59) + this.CarrierExt.GetHashCode();
                }
                if (this.CarrierId != null)
                {
                    hashCode = (hashCode * 59) + this.CarrierId.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.SignatureUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureUrl.GetHashCode();
                }
                if (this.LoadingAids != null)
                {
                    hashCode = (hashCode * 59) + this.LoadingAids.GetHashCode();
                }
                if (this.Images != null)
                {
                    hashCode = (hashCode * 59) + this.Images.GetHashCode();
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