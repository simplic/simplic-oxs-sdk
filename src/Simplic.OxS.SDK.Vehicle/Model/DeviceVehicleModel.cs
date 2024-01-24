// <auto-generated>
/*
 * Simplic.OxS.Vehicle
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

namespace Simplic.OxS.SDK.Vehicle
{
    /// <summary>
    /// DeviceVehicleModel
    /// </summary>
    public partial class DeviceVehicleModel : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public DeviceVehicleModel()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceVehicleModel" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="matchCode">matchCode</param>
        /// <param name="registrationPlate">registrationPlate</param>
        /// <param name="type">type</param>
        //[JsonConstructor]
        public DeviceVehicleModel(Option<Guid> id = default, Option<string> matchCode = default, Option<string> registrationPlate = default, Option<string> type = default)
        {
            IdOption = id;
            MatchCodeOption = matchCode;
            RegistrationPlateOption = registrationPlate;
            TypeOption = type;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> IdOption { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public Guid? Id { get { return this. IdOption; } set { this.IdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of MatchCode
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> MatchCodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets MatchCode
        /// </summary>
        [JsonPropertyName("matchCode")]
        public string? MatchCode { get { return this. MatchCodeOption; } set { this.MatchCodeOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of RegistrationPlate
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> RegistrationPlateOption { get; private set; }

        /// <summary>
        /// Gets or Sets RegistrationPlate
        /// </summary>
        [JsonPropertyName("registrationPlate")]
        public string? RegistrationPlate { get { return this. RegistrationPlateOption; } set { this.RegistrationPlateOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Type
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> TypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get { return this. TypeOption; } set { this.TypeOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceVehicleModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MatchCode: ").Append(MatchCode).Append("\n");
            sb.Append("  RegistrationPlate: ").Append(RegistrationPlate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
    /// A Json converter for type <see cref="DeviceVehicleModel" />
    /// </summary>
    public class DeviceVehicleModelJsonConverter : JsonConverter<DeviceVehicleModel>
    {
        /// <summary>
        /// Deserializes json to <see cref="DeviceVehicleModel" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DeviceVehicleModel Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Guid> id = default;
            Option<string> matchCode = default;
            Option<string> registrationPlate = default;
            Option<string> type = default;

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
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "matchCode":
                            matchCode = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "registrationPlate":
                            registrationPlate = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "type":
                            type = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class DeviceVehicleModel.");

            //2return new DeviceVehicleModel(id, matchCode, registrationPlate, type);
            return new DeviceVehicleModel(id, matchCode, registrationPlate, type);
        }

        /// <summary>
        /// Serializes a <see cref="DeviceVehicleModel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="deviceVehicleModel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DeviceVehicleModel deviceVehicleModel, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, deviceVehicleModel, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DeviceVehicleModel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="deviceVehicleModel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, DeviceVehicleModel deviceVehicleModel, JsonSerializerOptions jsonSerializerOptions)
        {
            if (deviceVehicleModel.IdOption.IsSet)
                writer.WriteString("id", deviceVehicleModel.IdOption!.Value);

            if (deviceVehicleModel.MatchCodeOption.IsSet)
                if (deviceVehicleModel.MatchCodeOption.Value != null)
                {
                    writer.WriteString("matchCode", deviceVehicleModel.MatchCode);
                    //var __value = deviceVehicleModel.MatchCodeOption.Value;
                    //writer.WriteString("matchCode", __value);
                }
                else
                    writer.WriteNull("matchCode");

            if (deviceVehicleModel.RegistrationPlateOption.IsSet)
                if (deviceVehicleModel.RegistrationPlateOption.Value != null)
                {
                    writer.WriteString("registrationPlate", deviceVehicleModel.RegistrationPlate);
                    //var __value = deviceVehicleModel.RegistrationPlateOption.Value;
                    //writer.WriteString("registrationPlate", __value);
                }
                else
                    writer.WriteNull("registrationPlate");

            if (deviceVehicleModel.TypeOption.IsSet)
                if (deviceVehicleModel.TypeOption.Value != null)
                {
                    writer.WriteString("type", deviceVehicleModel.Type);
                    //var __value = deviceVehicleModel.TypeOption.Value;
                    //writer.WriteString("type", __value);
                }
                else
                    writer.WriteNull("type");
        }
    }
}
