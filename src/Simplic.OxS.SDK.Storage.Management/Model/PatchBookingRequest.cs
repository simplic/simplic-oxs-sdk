// <auto-generated>
/*
 * Simplic.OxS.storage-management
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using Simplic.OxS.SDK;

using Simplic.OxS.SDK;

namespace Simplic.OxS.SDK.Storage.Management
{
    /// <summary>
    /// PatchBookingRequest
    /// </summary>
    public partial class PatchBookingRequest : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public PatchBookingRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchBookingRequest" /> class.
        /// </summary>
        /// <param name="carrierId">carrierId</param>
        /// <param name="customerId">customerId</param>
        /// <param name="date">date</param>
        /// <param name="deliveryNote">deliveryNote</param>
        /// <param name="driverId">driverId</param>
        /// <param name="ecoNumber">ecoNumber</param>
        /// <param name="externalCarrier">externalCarrier</param>
        /// <param name="externalDriver">externalDriver</param>
        /// <param name="externalVehicle">externalVehicle</param>
        /// <param name="images">images</param>
        /// <param name="loadingAids">loadingAids</param>
        /// <param name="locationId">locationId</param>
        /// <param name="signatureDriver">signatureDriver</param>
        /// <param name="signatureUser">signatureUser</param>
        /// <param name="vehicleId">vehicleId</param>
        //[JsonConstructor]
        public PatchBookingRequest(Option<Guid> carrierId = default, Option<Guid> customerId = default, Option<DateTime> date = default, Option<string> deliveryNote = default, Option<Guid> driverId = default, Option<string> ecoNumber = default, Option<string> externalCarrier = default, Option<string> externalDriver = default, Option<string> externalVehicle = default, Option<List<Guid>> images = default, Option<List<LoadingAidRequest>> loadingAids = default, Option<Guid> locationId = default, Option<SignatureUserModel> signatureDriver = default, Option<SignatureUserModel> signatureUser = default, Option<Guid> vehicleId = default)
        {
            CarrierIdOption = carrierId;
            CustomerIdOption = customerId;
            DateOption = date;
            DeliveryNoteOption = deliveryNote;
            DriverIdOption = driverId;
            EcoNumberOption = ecoNumber;
            ExternalCarrierOption = externalCarrier;
            ExternalDriverOption = externalDriver;
            ExternalVehicleOption = externalVehicle;
            ImagesOption = images;
            LoadingAidsOption = loadingAids;
            LocationIdOption = locationId;
            SignatureDriverOption = signatureDriver;
            SignatureUserOption = signatureUser;
            VehicleIdOption = vehicleId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of CarrierId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> CarrierIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets CarrierId
        /// </summary>
        [JsonPropertyName("carrierId")]
        public Guid? CarrierId { get { return this. CarrierIdOption; } set { this.CarrierIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of CustomerId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> CustomerIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [JsonPropertyName("customerId")]
        public Guid? CustomerId { get { return this. CustomerIdOption; } set { this.CustomerIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of Date
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<DateTime>))]
        public Option<DateTime> DateOption { get; private set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [JsonPropertyName("date")]
        public DateTime? Date { get { return this. DateOption; } set { this.DateOption = new Option<DateTime>(value); } }

        /// <summary>
        /// Used to track the state of DeliveryNote
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> DeliveryNoteOption { get; private set; }

        /// <summary>
        /// Gets or Sets DeliveryNote
        /// </summary>
        [JsonPropertyName("deliveryNote")]
        public string? DeliveryNote { get { return this. DeliveryNoteOption; } set { this.DeliveryNoteOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of DriverId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> DriverIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets DriverId
        /// </summary>
        [JsonPropertyName("driverId")]
        public Guid? DriverId { get { return this. DriverIdOption; } set { this.DriverIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of EcoNumber
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> EcoNumberOption { get; private set; }

        /// <summary>
        /// Gets or Sets EcoNumber
        /// </summary>
        [JsonPropertyName("ecoNumber")]
        public string? EcoNumber { get { return this. EcoNumberOption; } set { this.EcoNumberOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of ExternalCarrier
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> ExternalCarrierOption { get; private set; }

        /// <summary>
        /// Gets or Sets ExternalCarrier
        /// </summary>
        [JsonPropertyName("externalCarrier")]
        public string? ExternalCarrier { get { return this. ExternalCarrierOption; } set { this.ExternalCarrierOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of ExternalDriver
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> ExternalDriverOption { get; private set; }

        /// <summary>
        /// Gets or Sets ExternalDriver
        /// </summary>
        [JsonPropertyName("externalDriver")]
        public string? ExternalDriver { get { return this. ExternalDriverOption; } set { this.ExternalDriverOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of ExternalVehicle
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> ExternalVehicleOption { get; private set; }

        /// <summary>
        /// Gets or Sets ExternalVehicle
        /// </summary>
        [JsonPropertyName("externalVehicle")]
        public string? ExternalVehicle { get { return this. ExternalVehicleOption; } set { this.ExternalVehicleOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Images
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<List<Guid>>))]
        public Option<List<Guid>> ImagesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [JsonPropertyName("images")]
        public List<Guid>? Images { get { return this. ImagesOption; } set { this.ImagesOption = new Option<List<Guid>>(value); } }

        /// <summary>
        /// Used to track the state of LoadingAids
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<List<LoadingAidRequest>>))]
        public Option<List<LoadingAidRequest>> LoadingAidsOption { get; private set; }

        /// <summary>
        /// Gets or Sets LoadingAids
        /// </summary>
        [JsonPropertyName("loadingAids")]
        public List<LoadingAidRequest>? LoadingAids { get { return this. LoadingAidsOption; } set { this.LoadingAidsOption = new Option<List<LoadingAidRequest>>(value); } }

        /// <summary>
        /// Used to track the state of LocationId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> LocationIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [JsonPropertyName("locationId")]
        public Guid? LocationId { get { return this. LocationIdOption; } set { this.LocationIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of SignatureDriver
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<SignatureUserModel>))]
        public Option<SignatureUserModel> SignatureDriverOption { get; private set; }

        /// <summary>
        /// Gets or Sets SignatureDriver
        /// </summary>
        [JsonPropertyName("signatureDriver")]
        public SignatureUserModel? SignatureDriver { get { return this. SignatureDriverOption; } set { this.SignatureDriverOption = new Option<SignatureUserModel>(value); } }

        /// <summary>
        /// Used to track the state of SignatureUser
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<SignatureUserModel>))]
        public Option<SignatureUserModel> SignatureUserOption { get; private set; }

        /// <summary>
        /// Gets or Sets SignatureUser
        /// </summary>
        [JsonPropertyName("signatureUser")]
        public SignatureUserModel? SignatureUser { get { return this. SignatureUserOption; } set { this.SignatureUserOption = new Option<SignatureUserModel>(value); } }

        /// <summary>
        /// Used to track the state of VehicleId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> VehicleIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets VehicleId
        /// </summary>
        [JsonPropertyName("vehicleId")]
        public Guid? VehicleId { get { return this. VehicleIdOption; } set { this.VehicleIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchBookingRequest {\n");
            sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DeliveryNote: ").Append(DeliveryNote).Append("\n");
            sb.Append("  DriverId: ").Append(DriverId).Append("\n");
            sb.Append("  EcoNumber: ").Append(EcoNumber).Append("\n");
            sb.Append("  ExternalCarrier: ").Append(ExternalCarrier).Append("\n");
            sb.Append("  ExternalDriver: ").Append(ExternalDriver).Append("\n");
            sb.Append("  ExternalVehicle: ").Append(ExternalVehicle).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  LoadingAids: ").Append(LoadingAids).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  SignatureDriver: ").Append(SignatureDriver).Append("\n");
            sb.Append("  SignatureUser: ").Append(SignatureUser).Append("\n");
            sb.Append("  VehicleId: ").Append(VehicleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
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

    /// <summary>
    /// A Json converter for type <see cref="PatchBookingRequest" />
    /// </summary>
    public class PatchBookingRequestJsonConverter : JsonConverter<PatchBookingRequest>
    {
        /// <summary>
        /// The format to use to serialize Date
        /// </summary>
        public static string DateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="PatchBookingRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PatchBookingRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Guid> carrierId = default;
            Option<Guid> customerId = default;
            Option<DateTime> date = default;
            Option<string> deliveryNote = default;
            Option<Guid> driverId = default;
            Option<string> ecoNumber = default;
            Option<string> externalCarrier = default;
            Option<string> externalDriver = default;
            Option<string> externalVehicle = default;
            Option<List<Guid>> images = default;
            Option<List<LoadingAidRequest>> loadingAids = default;
            Option<Guid> locationId = default;
            Option<SignatureUserModel> signatureDriver = default;
            Option<SignatureUserModel> signatureUser = default;
            Option<Guid> vehicleId = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "carrierId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                carrierId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "customerId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                customerId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "date":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                date = new Option<DateTime>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "deliveryNote":
                            deliveryNote = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "driverId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                driverId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "ecoNumber":
                            ecoNumber = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "externalCarrier":
                            externalCarrier = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "externalDriver":
                            externalDriver = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "externalVehicle":
                            externalVehicle = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "images":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                images = new Option<List<Guid>>(JsonSerializer.Deserialize<List<Guid>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "loadingAids":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                loadingAids = new Option<List<LoadingAidRequest>>(JsonSerializer.Deserialize<List<LoadingAidRequest>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "locationId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                locationId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "signatureDriver":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                signatureDriver = new Option<SignatureUserModel>(JsonSerializer.Deserialize<SignatureUserModel>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "signatureUser":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                signatureUser = new Option<SignatureUserModel>(JsonSerializer.Deserialize<SignatureUserModel>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "vehicleId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                vehicleId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (signatureDriver.IsSet && signatureDriver.Value == null)
                throw new ArgumentNullException(nameof(signatureDriver), "Property is not nullable for class PatchBookingRequest.");

            if (signatureUser.IsSet && signatureUser.Value == null)
                throw new ArgumentNullException(nameof(signatureUser), "Property is not nullable for class PatchBookingRequest.");

            //2return new PatchBookingRequest(carrierId, customerId, date, deliveryNote, driverId, ecoNumber, externalCarrier, externalDriver, externalVehicle, images, loadingAids, locationId, signatureDriver, signatureUser, vehicleId);
            return new PatchBookingRequest(carrierId, customerId, date, deliveryNote, driverId, ecoNumber, externalCarrier, externalDriver, externalVehicle, images, loadingAids, locationId, signatureDriver, signatureUser, vehicleId);
        }

        /// <summary>
        /// Serializes a <see cref="PatchBookingRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="patchBookingRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PatchBookingRequest patchBookingRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, patchBookingRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PatchBookingRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="patchBookingRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, PatchBookingRequest patchBookingRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (patchBookingRequest.SignatureDriverOption.IsSet && patchBookingRequest.SignatureDriver == null)
                throw new ArgumentNullException(nameof(patchBookingRequest.SignatureDriver), "Property is required for class PatchBookingRequest.");

            if (patchBookingRequest.SignatureUserOption.IsSet && patchBookingRequest.SignatureUser == null)
                throw new ArgumentNullException(nameof(patchBookingRequest.SignatureUser), "Property is required for class PatchBookingRequest.");

            if (patchBookingRequest.CarrierIdOption.IsSet)
                if (patchBookingRequest.CarrierIdOption.Value != null)
                {
                    writer.WriteString("carrierId", patchBookingRequest.CarrierIdOption!.Value);
                    //var __value = patchBookingRequest.CarrierIdOption.Value;
                    //writer.WriteString("carrierId", __value);
                }
                else
                    writer.WriteNull("carrierId");

            if (patchBookingRequest.CustomerIdOption.IsSet)
                if (patchBookingRequest.CustomerIdOption.Value != null)
                {
                    writer.WriteString("customerId", patchBookingRequest.CustomerIdOption!.Value);
                    //var __value = patchBookingRequest.CustomerIdOption.Value;
                    //writer.WriteString("customerId", __value);
                }
                else
                    writer.WriteNull("customerId");

            if (patchBookingRequest.DateOption.IsSet)
                if (patchBookingRequest.DateOption.Value != null)
                {
                    writer.WriteString("date", patchBookingRequest.DateOption!.Value.ToString(DateFormat));
                    //var __value = patchBookingRequest.DateOption.Value;
                    //writer.WriteString("date", __value);
                }
                else
                    writer.WriteNull("date");

            if (patchBookingRequest.DeliveryNoteOption.IsSet)
                if (patchBookingRequest.DeliveryNoteOption.Value != null)
                {
                    writer.WriteString("deliveryNote", patchBookingRequest.DeliveryNote);
                    //var __value = patchBookingRequest.DeliveryNoteOption.Value;
                    //writer.WriteString("deliveryNote", __value);
                }
                else
                    writer.WriteNull("deliveryNote");

            if (patchBookingRequest.DriverIdOption.IsSet)
                if (patchBookingRequest.DriverIdOption.Value != null)
                {
                    writer.WriteString("driverId", patchBookingRequest.DriverIdOption!.Value);
                    //var __value = patchBookingRequest.DriverIdOption.Value;
                    //writer.WriteString("driverId", __value);
                }
                else
                    writer.WriteNull("driverId");

            if (patchBookingRequest.EcoNumberOption.IsSet)
                if (patchBookingRequest.EcoNumberOption.Value != null)
                {
                    writer.WriteString("ecoNumber", patchBookingRequest.EcoNumber);
                    //var __value = patchBookingRequest.EcoNumberOption.Value;
                    //writer.WriteString("ecoNumber", __value);
                }
                else
                    writer.WriteNull("ecoNumber");

            if (patchBookingRequest.ExternalCarrierOption.IsSet)
                if (patchBookingRequest.ExternalCarrierOption.Value != null)
                {
                    writer.WriteString("externalCarrier", patchBookingRequest.ExternalCarrier);
                    //var __value = patchBookingRequest.ExternalCarrierOption.Value;
                    //writer.WriteString("externalCarrier", __value);
                }
                else
                    writer.WriteNull("externalCarrier");

            if (patchBookingRequest.ExternalDriverOption.IsSet)
                if (patchBookingRequest.ExternalDriverOption.Value != null)
                {
                    writer.WriteString("externalDriver", patchBookingRequest.ExternalDriver);
                    //var __value = patchBookingRequest.ExternalDriverOption.Value;
                    //writer.WriteString("externalDriver", __value);
                }
                else
                    writer.WriteNull("externalDriver");

            if (patchBookingRequest.ExternalVehicleOption.IsSet)
                if (patchBookingRequest.ExternalVehicleOption.Value != null)
                {
                    writer.WriteString("externalVehicle", patchBookingRequest.ExternalVehicle);
                    //var __value = patchBookingRequest.ExternalVehicleOption.Value;
                    //writer.WriteString("externalVehicle", __value);
                }
                else
                    writer.WriteNull("externalVehicle");

            if (patchBookingRequest.ImagesOption.IsSet)
                if (patchBookingRequest.ImagesOption.Value != null)
                {
                    writer.WritePropertyName("images");
                    JsonSerializer.Serialize(writer, patchBookingRequest.Images, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("images");
            if (patchBookingRequest.LoadingAidsOption.IsSet)
                if (patchBookingRequest.LoadingAidsOption.Value != null)
                {
                    writer.WritePropertyName("loadingAids");
                    JsonSerializer.Serialize(writer, patchBookingRequest.LoadingAids, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("loadingAids");
            if (patchBookingRequest.LocationIdOption.IsSet)
                if (patchBookingRequest.LocationIdOption.Value != null)
                {
                    writer.WriteString("locationId", patchBookingRequest.LocationIdOption!.Value);
                    //var __value = patchBookingRequest.LocationIdOption.Value;
                    //writer.WriteString("locationId", __value);
                }
                else
                    writer.WriteNull("locationId");

            if (patchBookingRequest.SignatureDriverOption.IsSet)
            {
                writer.WritePropertyName("signatureDriver");
                JsonSerializer.Serialize(writer, patchBookingRequest.SignatureDriver, jsonSerializerOptions);
            }
            if (patchBookingRequest.SignatureUserOption.IsSet)
            {
                writer.WritePropertyName("signatureUser");
                JsonSerializer.Serialize(writer, patchBookingRequest.SignatureUser, jsonSerializerOptions);
            }
            if (patchBookingRequest.VehicleIdOption.IsSet)
                if (patchBookingRequest.VehicleIdOption.Value != null)
                {
                    writer.WriteString("vehicleId", patchBookingRequest.VehicleIdOption!.Value);
                    //var __value = patchBookingRequest.VehicleIdOption.Value;
                    //writer.WriteString("vehicleId", __value);
                }
                else
                    writer.WriteNull("vehicleId");
        }
    }
}
