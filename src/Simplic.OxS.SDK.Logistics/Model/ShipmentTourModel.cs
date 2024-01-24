// <auto-generated>
/*
 * Simplic.OxS.Logistics
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

namespace Simplic.OxS.SDK.Logistics
{
    /// <summary>
    /// Represents a connection between a shipment and a tour.
    /// </summary>
    public partial class ShipmentTourModel : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public ShipmentTourModel()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentTourModel" /> class.
        /// </summary>
        /// <param name="endAddress">endAddress</param>
        /// <param name="endDateTime">Gets or sets the end date (detach action date time)</param>
        /// <param name="number">Gets or sets the tour number</param>
        /// <param name="resource">resource</param>
        /// <param name="startAddress">startAddress</param>
        /// <param name="startDateTime">Gets or sets the start date (attach action date time)</param>
        /// <param name="tourId">Gets or sets the tour-id</param>
        //[JsonConstructor]
        public ShipmentTourModel(Option<AddressModel> endAddress = default, Option<DateTime> endDateTime = default, Option<string> number = default, Option<ResourceModel> resource = default, Option<AddressModel> startAddress = default, Option<DateTime> startDateTime = default, Option<Guid> tourId = default)
        {
            EndAddressOption = endAddress;
            EndDateTimeOption = endDateTime;
            NumberOption = number;
            ResourceOption = resource;
            StartAddressOption = startAddress;
            StartDateTimeOption = startDateTime;
            TourIdOption = tourId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of EndAddress
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<AddressModel>))]
        public Option<AddressModel> EndAddressOption { get; private set; }

        /// <summary>
        /// Gets or Sets EndAddress
        /// </summary>
        [JsonPropertyName("endAddress")]
        public AddressModel? EndAddress { get { return this. EndAddressOption; } set { this.EndAddressOption = new Option<AddressModel>(value); } }

        /// <summary>
        /// Used to track the state of EndDateTime
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<DateTime>))]
        public Option<DateTime> EndDateTimeOption { get; private set; }

        /// <summary>
        /// Gets or sets the end date (detach action date time)
        /// </summary>
        /// <value>Gets or sets the end date (detach action date time)</value>
        [JsonPropertyName("endDateTime")]
        public DateTime? EndDateTime { get { return this. EndDateTimeOption; } set { this.EndDateTimeOption = new Option<DateTime>(value); } }

        /// <summary>
        /// Used to track the state of Number
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> NumberOption { get; private set; }

        /// <summary>
        /// Gets or sets the tour number
        /// </summary>
        /// <value>Gets or sets the tour number</value>
        [JsonPropertyName("number")]
        public string? Number { get { return this. NumberOption; } set { this.NumberOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Resource
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<ResourceModel>))]
        public Option<ResourceModel> ResourceOption { get; private set; }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [JsonPropertyName("resource")]
        public ResourceModel? Resource { get { return this. ResourceOption; } set { this.ResourceOption = new Option<ResourceModel>(value); } }

        /// <summary>
        /// Used to track the state of StartAddress
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<AddressModel>))]
        public Option<AddressModel> StartAddressOption { get; private set; }

        /// <summary>
        /// Gets or Sets StartAddress
        /// </summary>
        [JsonPropertyName("startAddress")]
        public AddressModel? StartAddress { get { return this. StartAddressOption; } set { this.StartAddressOption = new Option<AddressModel>(value); } }

        /// <summary>
        /// Used to track the state of StartDateTime
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<DateTime>))]
        public Option<DateTime> StartDateTimeOption { get; private set; }

        /// <summary>
        /// Gets or sets the start date (attach action date time)
        /// </summary>
        /// <value>Gets or sets the start date (attach action date time)</value>
        [JsonPropertyName("startDateTime")]
        public DateTime? StartDateTime { get { return this. StartDateTimeOption; } set { this.StartDateTimeOption = new Option<DateTime>(value); } }

        /// <summary>
        /// Used to track the state of TourId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> TourIdOption { get; private set; }

        /// <summary>
        /// Gets or sets the tour-id
        /// </summary>
        /// <value>Gets or sets the tour-id</value>
        [JsonPropertyName("tourId")]
        public Guid? TourId { get { return this. TourIdOption; } set { this.TourIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentTourModel {\n");
            sb.Append("  EndAddress: ").Append(EndAddress).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  StartAddress: ").Append(StartAddress).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  TourId: ").Append(TourId).Append("\n");
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
    /// A Json converter for type <see cref="ShipmentTourModel" />
    /// </summary>
    public class ShipmentTourModelJsonConverter : JsonConverter<ShipmentTourModel>
    {
        /// <summary>
        /// The format to use to serialize EndDateTime
        /// </summary>
        public static string EndDateTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize StartDateTime
        /// </summary>
        public static string StartDateTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="ShipmentTourModel" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ShipmentTourModel Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<AddressModel> endAddress = default;
            Option<DateTime> endDateTime = default;
            Option<string> number = default;
            Option<ResourceModel> resource = default;
            Option<AddressModel> startAddress = default;
            Option<DateTime> startDateTime = default;
            Option<Guid> tourId = default;

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
                        case "endAddress":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                endAddress = new Option<AddressModel>(JsonSerializer.Deserialize<AddressModel>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "endDateTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                endDateTime = new Option<DateTime>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "number":
                            number = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "resource":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                resource = new Option<ResourceModel>(JsonSerializer.Deserialize<ResourceModel>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "startAddress":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                startAddress = new Option<AddressModel>(JsonSerializer.Deserialize<AddressModel>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "startDateTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                startDateTime = new Option<DateTime>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "tourId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                tourId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (endAddress.IsSet && endAddress.Value == null)
                throw new ArgumentNullException(nameof(endAddress), "Property is not nullable for class ShipmentTourModel.");

            if (endDateTime.IsSet && endDateTime.Value == null)
                throw new ArgumentNullException(nameof(endDateTime), "Property is not nullable for class ShipmentTourModel.");

            if (resource.IsSet && resource.Value == null)
                throw new ArgumentNullException(nameof(resource), "Property is not nullable for class ShipmentTourModel.");

            if (startAddress.IsSet && startAddress.Value == null)
                throw new ArgumentNullException(nameof(startAddress), "Property is not nullable for class ShipmentTourModel.");

            if (startDateTime.IsSet && startDateTime.Value == null)
                throw new ArgumentNullException(nameof(startDateTime), "Property is not nullable for class ShipmentTourModel.");

            if (tourId.IsSet && tourId.Value == null)
                throw new ArgumentNullException(nameof(tourId), "Property is not nullable for class ShipmentTourModel.");

            //2return new ShipmentTourModel(endAddress, endDateTime, number, resource, startAddress, startDateTime, tourId);
            return new ShipmentTourModel(endAddress, endDateTime, number, resource, startAddress, startDateTime, tourId);
        }

        /// <summary>
        /// Serializes a <see cref="ShipmentTourModel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="shipmentTourModel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ShipmentTourModel shipmentTourModel, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, shipmentTourModel, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ShipmentTourModel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="shipmentTourModel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, ShipmentTourModel shipmentTourModel, JsonSerializerOptions jsonSerializerOptions)
        {
            if (shipmentTourModel.EndAddressOption.IsSet && shipmentTourModel.EndAddress == null)
                throw new ArgumentNullException(nameof(shipmentTourModel.EndAddress), "Property is required for class ShipmentTourModel.");

            if (shipmentTourModel.ResourceOption.IsSet && shipmentTourModel.Resource == null)
                throw new ArgumentNullException(nameof(shipmentTourModel.Resource), "Property is required for class ShipmentTourModel.");

            if (shipmentTourModel.StartAddressOption.IsSet && shipmentTourModel.StartAddress == null)
                throw new ArgumentNullException(nameof(shipmentTourModel.StartAddress), "Property is required for class ShipmentTourModel.");

            if (shipmentTourModel.EndAddressOption.IsSet)
            {
                writer.WritePropertyName("endAddress");
                JsonSerializer.Serialize(writer, shipmentTourModel.EndAddress, jsonSerializerOptions);
            }
            if (shipmentTourModel.EndDateTimeOption.IsSet)
                writer.WriteString("endDateTime", shipmentTourModel.EndDateTimeOption!.Value.ToString(EndDateTimeFormat));

            if (shipmentTourModel.NumberOption.IsSet)
                if (shipmentTourModel.NumberOption.Value != null)
                {
                    writer.WriteString("number", shipmentTourModel.Number);
                    //var __value = shipmentTourModel.NumberOption.Value;
                    //writer.WriteString("number", __value);
                }
                else
                    writer.WriteNull("number");

            if (shipmentTourModel.ResourceOption.IsSet)
            {
                writer.WritePropertyName("resource");
                JsonSerializer.Serialize(writer, shipmentTourModel.Resource, jsonSerializerOptions);
            }
            if (shipmentTourModel.StartAddressOption.IsSet)
            {
                writer.WritePropertyName("startAddress");
                JsonSerializer.Serialize(writer, shipmentTourModel.StartAddress, jsonSerializerOptions);
            }
            if (shipmentTourModel.StartDateTimeOption.IsSet)
                writer.WriteString("startDateTime", shipmentTourModel.StartDateTimeOption!.Value.ToString(StartDateTimeFormat));

            if (shipmentTourModel.TourIdOption.IsSet)
                writer.WriteString("tourId", shipmentTourModel.TourIdOption!.Value);
        }
    }
}
