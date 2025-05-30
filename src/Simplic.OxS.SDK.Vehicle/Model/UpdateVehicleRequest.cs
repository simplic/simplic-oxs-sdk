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
    /// UpdateVehicleRequest
    /// </summary>
    [DataContract(Name = "UpdateVehicleRequest")]
    public partial class UpdateVehicleRequest : IEquatable<UpdateVehicleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVehicleRequest" /> class.
        /// </summary>
        /// <param name="location">location.</param>
        /// <param name="matchCode">matchCode.</param>
        /// <param name="status">status.</param>
        /// <param name="mileage">mileage.</param>
        /// <param name="mileageDate">mileageDate.</param>
        /// <param name="operatingHours">operatingHours.</param>
        /// <param name="fuelTankCapacity">fuelTankCapacity.</param>
        /// <param name="remark">remark.</param>
        /// <param name="dispositionSortingKey">dispositionSortingKey.</param>
        /// <param name="yearOfManufacturing">yearOfManufacturing.</param>
        /// <param name="registrationDocument">registrationDocument.</param>
        /// <param name="vehicleRegistration">vehicleRegistration.</param>
        /// <param name="isSystemVehicle">isSystemVehicle.</param>
        /// <param name="department">department.</param>
        /// <param name="vehicleTypeSubType">vehicleTypeSubType.</param>
        /// <param name="additionalTechnicalData">additionalTechnicalData.</param>
        /// <param name="registrationCertificate">registrationCertificate.</param>
        /// <param name="registrationPlate">registrationPlate.</param>
        /// <param name="registrationDocumentLocation">registrationDocumentLocation.</param>
        /// <param name="toll">toll.</param>
        /// <param name="usableUntil">usableUntil.</param>
        /// <param name="loadingSlots">loadingSlots.</param>
        /// <param name="qrCode">qrCode.</param>
        public UpdateVehicleRequest(string location = default(string), string matchCode = default(string), VehicleStatusModel status = default(VehicleStatusModel), double? mileage = default(double?), DateTime? mileageDate = default(DateTime?), double? operatingHours = default(double?), int? fuelTankCapacity = default(int?), string remark = default(string), string dispositionSortingKey = default(string), DateTime? yearOfManufacturing = default(DateTime?), string registrationDocument = default(string), string vehicleRegistration = default(string), bool? isSystemVehicle = default(bool?), DepartmentModel department = default(DepartmentModel), VehicleTypeSubTypeModel vehicleTypeSubType = default(VehicleTypeSubTypeModel), AdditionalTechnicalDataModel additionalTechnicalData = default(AdditionalTechnicalDataModel), RegistrationCertificateModel registrationCertificate = default(RegistrationCertificateModel), RegistrationPlateModel registrationPlate = default(RegistrationPlateModel), RegistrationDocumentLocationModel registrationDocumentLocation = default(RegistrationDocumentLocationModel), TollModel toll = default(TollModel), DateTime? usableUntil = default(DateTime?), List<LoadingSlotModel> loadingSlots = default(List<LoadingSlotModel>), string qrCode = default(string))
        {
            this.Location = location;
            this.MatchCode = matchCode;
            this.Status = status;
            this.Mileage = mileage;
            this.MileageDate = mileageDate;
            this.OperatingHours = operatingHours;
            this.FuelTankCapacity = fuelTankCapacity;
            this.Remark = remark;
            this.DispositionSortingKey = dispositionSortingKey;
            this.YearOfManufacturing = yearOfManufacturing;
            this.RegistrationDocument = registrationDocument;
            this.VehicleRegistration = vehicleRegistration;
            this.IsSystemVehicle = isSystemVehicle;
            this.Department = department;
            this.VehicleTypeSubType = vehicleTypeSubType;
            this.AdditionalTechnicalData = additionalTechnicalData;
            this.RegistrationCertificate = registrationCertificate;
            this.RegistrationPlate = registrationPlate;
            this.RegistrationDocumentLocation = registrationDocumentLocation;
            this.Toll = toll;
            this.UsableUntil = usableUntil;
            this.LoadingSlots = loadingSlots;
            this.QrCode = qrCode;
        }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = true)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets MatchCode
        /// </summary>
        [DataMember(Name = "matchCode", EmitDefaultValue = true)]
        public string MatchCode { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public VehicleStatusModel Status { get; set; }

        /// <summary>
        /// Gets or Sets Mileage
        /// </summary>
        [DataMember(Name = "mileage", EmitDefaultValue = true)]
        public double? Mileage { get; set; }

        /// <summary>
        /// Gets or Sets MileageDate
        /// </summary>
        [DataMember(Name = "mileageDate", EmitDefaultValue = true)]
        public DateTime? MileageDate { get; set; }

        /// <summary>
        /// Gets or Sets OperatingHours
        /// </summary>
        [DataMember(Name = "operatingHours", EmitDefaultValue = true)]
        public double? OperatingHours { get; set; }

        /// <summary>
        /// Gets or Sets FuelTankCapacity
        /// </summary>
        [DataMember(Name = "fuelTankCapacity", EmitDefaultValue = true)]
        public int? FuelTankCapacity { get; set; }

        /// <summary>
        /// Gets or Sets Remark
        /// </summary>
        [DataMember(Name = "remark", EmitDefaultValue = true)]
        public string Remark { get; set; }

        /// <summary>
        /// Gets or Sets DispositionSortingKey
        /// </summary>
        [DataMember(Name = "dispositionSortingKey", EmitDefaultValue = true)]
        public string DispositionSortingKey { get; set; }

        /// <summary>
        /// Gets or Sets YearOfManufacturing
        /// </summary>
        [DataMember(Name = "yearOfManufacturing", EmitDefaultValue = true)]
        public DateTime? YearOfManufacturing { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationDocument
        /// </summary>
        [DataMember(Name = "registrationDocument", EmitDefaultValue = true)]
        public string RegistrationDocument { get; set; }

        /// <summary>
        /// Gets or Sets VehicleRegistration
        /// </summary>
        [DataMember(Name = "vehicleRegistration", EmitDefaultValue = true)]
        public string VehicleRegistration { get; set; }

        /// <summary>
        /// Gets or Sets IsSystemVehicle
        /// </summary>
        [DataMember(Name = "isSystemVehicle", EmitDefaultValue = true)]
        public bool? IsSystemVehicle { get; set; }

        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name = "department", EmitDefaultValue = false)]
        public DepartmentModel Department { get; set; }

        /// <summary>
        /// Gets or Sets VehicleTypeSubType
        /// </summary>
        [DataMember(Name = "vehicleTypeSubType", EmitDefaultValue = false)]
        public VehicleTypeSubTypeModel VehicleTypeSubType { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalTechnicalData
        /// </summary>
        [DataMember(Name = "additionalTechnicalData", EmitDefaultValue = false)]
        public AdditionalTechnicalDataModel AdditionalTechnicalData { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationCertificate
        /// </summary>
        [DataMember(Name = "registrationCertificate", EmitDefaultValue = false)]
        public RegistrationCertificateModel RegistrationCertificate { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationPlate
        /// </summary>
        [DataMember(Name = "registrationPlate", EmitDefaultValue = false)]
        public RegistrationPlateModel RegistrationPlate { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationDocumentLocation
        /// </summary>
        [DataMember(Name = "registrationDocumentLocation", EmitDefaultValue = false)]
        public RegistrationDocumentLocationModel RegistrationDocumentLocation { get; set; }

        /// <summary>
        /// Gets or Sets Toll
        /// </summary>
        [DataMember(Name = "toll", EmitDefaultValue = false)]
        public TollModel Toll { get; set; }

        /// <summary>
        /// Gets or Sets UsableUntil
        /// </summary>
        [DataMember(Name = "usableUntil", EmitDefaultValue = true)]
        public DateTime? UsableUntil { get; set; }

        /// <summary>
        /// Gets or Sets LoadingSlots
        /// </summary>
        [DataMember(Name = "loadingSlots", EmitDefaultValue = true)]
        public List<LoadingSlotModel> LoadingSlots { get; set; }

        /// <summary>
        /// Gets or Sets QrCode
        /// </summary>
        [DataMember(Name = "qrCode", EmitDefaultValue = true)]
        public string QrCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateVehicleRequest {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  MatchCode: ").Append(MatchCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Mileage: ").Append(Mileage).Append("\n");
            sb.Append("  MileageDate: ").Append(MileageDate).Append("\n");
            sb.Append("  OperatingHours: ").Append(OperatingHours).Append("\n");
            sb.Append("  FuelTankCapacity: ").Append(FuelTankCapacity).Append("\n");
            sb.Append("  Remark: ").Append(Remark).Append("\n");
            sb.Append("  DispositionSortingKey: ").Append(DispositionSortingKey).Append("\n");
            sb.Append("  YearOfManufacturing: ").Append(YearOfManufacturing).Append("\n");
            sb.Append("  RegistrationDocument: ").Append(RegistrationDocument).Append("\n");
            sb.Append("  VehicleRegistration: ").Append(VehicleRegistration).Append("\n");
            sb.Append("  IsSystemVehicle: ").Append(IsSystemVehicle).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  VehicleTypeSubType: ").Append(VehicleTypeSubType).Append("\n");
            sb.Append("  AdditionalTechnicalData: ").Append(AdditionalTechnicalData).Append("\n");
            sb.Append("  RegistrationCertificate: ").Append(RegistrationCertificate).Append("\n");
            sb.Append("  RegistrationPlate: ").Append(RegistrationPlate).Append("\n");
            sb.Append("  RegistrationDocumentLocation: ").Append(RegistrationDocumentLocation).Append("\n");
            sb.Append("  Toll: ").Append(Toll).Append("\n");
            sb.Append("  UsableUntil: ").Append(UsableUntil).Append("\n");
            sb.Append("  LoadingSlots: ").Append(LoadingSlots).Append("\n");
            sb.Append("  QrCode: ").Append(QrCode).Append("\n");
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
            return this.Equals(input as UpdateVehicleRequest);
        }

        /// <summary>
        /// Returns true if UpdateVehicleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateVehicleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateVehicleRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.MatchCode == input.MatchCode ||
                    (this.MatchCode != null &&
                    this.MatchCode.Equals(input.MatchCode))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Mileage == input.Mileage ||
                    (this.Mileage != null &&
                    this.Mileage.Equals(input.Mileage))
                ) && 
                (
                    this.MileageDate == input.MileageDate ||
                    (this.MileageDate != null &&
                    this.MileageDate.Equals(input.MileageDate))
                ) && 
                (
                    this.OperatingHours == input.OperatingHours ||
                    (this.OperatingHours != null &&
                    this.OperatingHours.Equals(input.OperatingHours))
                ) && 
                (
                    this.FuelTankCapacity == input.FuelTankCapacity ||
                    (this.FuelTankCapacity != null &&
                    this.FuelTankCapacity.Equals(input.FuelTankCapacity))
                ) && 
                (
                    this.Remark == input.Remark ||
                    (this.Remark != null &&
                    this.Remark.Equals(input.Remark))
                ) && 
                (
                    this.DispositionSortingKey == input.DispositionSortingKey ||
                    (this.DispositionSortingKey != null &&
                    this.DispositionSortingKey.Equals(input.DispositionSortingKey))
                ) && 
                (
                    this.YearOfManufacturing == input.YearOfManufacturing ||
                    (this.YearOfManufacturing != null &&
                    this.YearOfManufacturing.Equals(input.YearOfManufacturing))
                ) && 
                (
                    this.RegistrationDocument == input.RegistrationDocument ||
                    (this.RegistrationDocument != null &&
                    this.RegistrationDocument.Equals(input.RegistrationDocument))
                ) && 
                (
                    this.VehicleRegistration == input.VehicleRegistration ||
                    (this.VehicleRegistration != null &&
                    this.VehicleRegistration.Equals(input.VehicleRegistration))
                ) && 
                (
                    this.IsSystemVehicle == input.IsSystemVehicle ||
                    (this.IsSystemVehicle != null &&
                    this.IsSystemVehicle.Equals(input.IsSystemVehicle))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.VehicleTypeSubType == input.VehicleTypeSubType ||
                    (this.VehicleTypeSubType != null &&
                    this.VehicleTypeSubType.Equals(input.VehicleTypeSubType))
                ) && 
                (
                    this.AdditionalTechnicalData == input.AdditionalTechnicalData ||
                    (this.AdditionalTechnicalData != null &&
                    this.AdditionalTechnicalData.Equals(input.AdditionalTechnicalData))
                ) && 
                (
                    this.RegistrationCertificate == input.RegistrationCertificate ||
                    (this.RegistrationCertificate != null &&
                    this.RegistrationCertificate.Equals(input.RegistrationCertificate))
                ) && 
                (
                    this.RegistrationPlate == input.RegistrationPlate ||
                    (this.RegistrationPlate != null &&
                    this.RegistrationPlate.Equals(input.RegistrationPlate))
                ) && 
                (
                    this.RegistrationDocumentLocation == input.RegistrationDocumentLocation ||
                    (this.RegistrationDocumentLocation != null &&
                    this.RegistrationDocumentLocation.Equals(input.RegistrationDocumentLocation))
                ) && 
                (
                    this.Toll == input.Toll ||
                    (this.Toll != null &&
                    this.Toll.Equals(input.Toll))
                ) && 
                (
                    this.UsableUntil == input.UsableUntil ||
                    (this.UsableUntil != null &&
                    this.UsableUntil.Equals(input.UsableUntil))
                ) && 
                (
                    this.LoadingSlots == input.LoadingSlots ||
                    this.LoadingSlots != null &&
                    input.LoadingSlots != null &&
                    this.LoadingSlots.SequenceEqual(input.LoadingSlots)
                ) && 
                (
                    this.QrCode == input.QrCode ||
                    (this.QrCode != null &&
                    this.QrCode.Equals(input.QrCode))
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
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                if (this.MatchCode != null)
                {
                    hashCode = (hashCode * 59) + this.MatchCode.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Mileage != null)
                {
                    hashCode = (hashCode * 59) + this.Mileage.GetHashCode();
                }
                if (this.MileageDate != null)
                {
                    hashCode = (hashCode * 59) + this.MileageDate.GetHashCode();
                }
                if (this.OperatingHours != null)
                {
                    hashCode = (hashCode * 59) + this.OperatingHours.GetHashCode();
                }
                if (this.FuelTankCapacity != null)
                {
                    hashCode = (hashCode * 59) + this.FuelTankCapacity.GetHashCode();
                }
                if (this.Remark != null)
                {
                    hashCode = (hashCode * 59) + this.Remark.GetHashCode();
                }
                if (this.DispositionSortingKey != null)
                {
                    hashCode = (hashCode * 59) + this.DispositionSortingKey.GetHashCode();
                }
                if (this.YearOfManufacturing != null)
                {
                    hashCode = (hashCode * 59) + this.YearOfManufacturing.GetHashCode();
                }
                if (this.RegistrationDocument != null)
                {
                    hashCode = (hashCode * 59) + this.RegistrationDocument.GetHashCode();
                }
                if (this.VehicleRegistration != null)
                {
                    hashCode = (hashCode * 59) + this.VehicleRegistration.GetHashCode();
                }
                if (this.IsSystemVehicle != null)
                {
                    hashCode = (hashCode * 59) + this.IsSystemVehicle.GetHashCode();
                }
                if (this.Department != null)
                {
                    hashCode = (hashCode * 59) + this.Department.GetHashCode();
                }
                if (this.VehicleTypeSubType != null)
                {
                    hashCode = (hashCode * 59) + this.VehicleTypeSubType.GetHashCode();
                }
                if (this.AdditionalTechnicalData != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalTechnicalData.GetHashCode();
                }
                if (this.RegistrationCertificate != null)
                {
                    hashCode = (hashCode * 59) + this.RegistrationCertificate.GetHashCode();
                }
                if (this.RegistrationPlate != null)
                {
                    hashCode = (hashCode * 59) + this.RegistrationPlate.GetHashCode();
                }
                if (this.RegistrationDocumentLocation != null)
                {
                    hashCode = (hashCode * 59) + this.RegistrationDocumentLocation.GetHashCode();
                }
                if (this.Toll != null)
                {
                    hashCode = (hashCode * 59) + this.Toll.GetHashCode();
                }
                if (this.UsableUntil != null)
                {
                    hashCode = (hashCode * 59) + this.UsableUntil.GetHashCode();
                }
                if (this.LoadingSlots != null)
                {
                    hashCode = (hashCode * 59) + this.LoadingSlots.GetHashCode();
                }
                if (this.QrCode != null)
                {
                    hashCode = (hashCode * 59) + this.QrCode.GetHashCode();
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
