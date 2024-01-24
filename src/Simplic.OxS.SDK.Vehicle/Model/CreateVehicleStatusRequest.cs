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
    /// CreateVehicleStatusRequest
    /// </summary>
    public partial class CreateVehicleStatusRequest : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public CreateVehicleStatusRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVehicleStatusRequest" /> class.
        /// </summary>
        /// <param name="isSelectable">isSelectable</param>
        /// <param name="name">name</param>
        //[JsonConstructor]
        public CreateVehicleStatusRequest(Option<bool> isSelectable = default, Option<string> name = default)
        {
            IsSelectableOption = isSelectable;
            NameOption = name;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of IsSelectable
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<bool>))]
        public Option<bool> IsSelectableOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsSelectable
        /// </summary>
        [JsonPropertyName("isSelectable")]
        public bool? IsSelectable { get { return this. IsSelectableOption; } set { this.IsSelectableOption = new Option<bool>(value); } }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get { return this. NameOption; } set { this.NameOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateVehicleStatusRequest {\n");
            sb.Append("  IsSelectable: ").Append(IsSelectable).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
    /// A Json converter for type <see cref="CreateVehicleStatusRequest" />
    /// </summary>
    public class CreateVehicleStatusRequestJsonConverter : JsonConverter<CreateVehicleStatusRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="CreateVehicleStatusRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CreateVehicleStatusRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<bool> isSelectable = default;
            Option<string> name = default;

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
                        case "isSelectable":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isSelectable = new Option<bool>(utf8JsonReader.GetBoolean());
                            break;
                        case "name":
                            name = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            //2return new CreateVehicleStatusRequest(isSelectable, name);
            return new CreateVehicleStatusRequest(isSelectable, name);
        }

        /// <summary>
        /// Serializes a <see cref="CreateVehicleStatusRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createVehicleStatusRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CreateVehicleStatusRequest createVehicleStatusRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, createVehicleStatusRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CreateVehicleStatusRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createVehicleStatusRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, CreateVehicleStatusRequest createVehicleStatusRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (createVehicleStatusRequest.IsSelectableOption.IsSet)
                if (createVehicleStatusRequest.IsSelectableOption.Value != null)
                {
                    writer.WriteBoolean("isSelectable", createVehicleStatusRequest.IsSelectableOption!.Value);
                    //var __value = createVehicleStatusRequest.IsSelectableOption.Value;
                    //writer.WriteString("isSelectable", __value);
                }
                else
                    writer.WriteNull("isSelectable");

            if (createVehicleStatusRequest.NameOption.IsSet)
                if (createVehicleStatusRequest.NameOption.Value != null)
                {
                    writer.WriteString("name", createVehicleStatusRequest.Name);
                    //var __value = createVehicleStatusRequest.NameOption.Value;
                    //writer.WriteString("name", __value);
                }
                else
                    writer.WriteNull("name");
        }
    }
}
