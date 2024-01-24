// <auto-generated>
/*
 * Simplic.OxS.Construction-Site
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

namespace Simplic.OxS.SDK.Construction.Site
{
    /// <summary>
    /// CreateConstructionSiteStatusRequest
    /// </summary>
    public partial class CreateConstructionSiteStatusRequest : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public CreateConstructionSiteStatusRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConstructionSiteStatusRequest" /> class.
        /// </summary>
        /// <param name="hexCode">hexCode</param>
        /// <param name="name">name</param>
        /// <param name="number">number</param>
        /// <param name="roles">roles</param>
        //[JsonConstructor]
        public CreateConstructionSiteStatusRequest(Option<string> hexCode = default, Option<string> name = default, Option<string> number = default, Option<List<string>> roles = default)
        {
            HexCodeOption = hexCode;
            NameOption = name;
            NumberOption = number;
            RolesOption = roles;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of HexCode
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> HexCodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets HexCode
        /// </summary>
        [JsonPropertyName("hexCode")]
        public string? HexCode { get { return this. HexCodeOption; } set { this.HexCodeOption = new Option<string>(value); } }

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
        /// Used to track the state of Number
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> NumberOption { get; private set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [JsonPropertyName("number")]
        public string? Number { get { return this. NumberOption; } set { this.NumberOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Roles
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<List<string>>))]
        public Option<List<string>> RolesOption { get; private set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [JsonPropertyName("roles")]
        public List<string>? Roles { get { return this. RolesOption; } set { this.RolesOption = new Option<List<string>>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateConstructionSiteStatusRequest {\n");
            sb.Append("  HexCode: ").Append(HexCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
    /// A Json converter for type <see cref="CreateConstructionSiteStatusRequest" />
    /// </summary>
    public class CreateConstructionSiteStatusRequestJsonConverter : JsonConverter<CreateConstructionSiteStatusRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="CreateConstructionSiteStatusRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CreateConstructionSiteStatusRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> hexCode = default;
            Option<string> name = default;
            Option<string> number = default;
            Option<List<string>> roles = default;

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
                        case "hexCode":
                            hexCode = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "name":
                            name = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "number":
                            number = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "roles":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                roles = new Option<List<string>>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            //2return new CreateConstructionSiteStatusRequest(hexCode, name, number, roles);
            return new CreateConstructionSiteStatusRequest(hexCode, name, number, roles);
        }

        /// <summary>
        /// Serializes a <see cref="CreateConstructionSiteStatusRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createConstructionSiteStatusRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CreateConstructionSiteStatusRequest createConstructionSiteStatusRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, createConstructionSiteStatusRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CreateConstructionSiteStatusRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="createConstructionSiteStatusRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, CreateConstructionSiteStatusRequest createConstructionSiteStatusRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (createConstructionSiteStatusRequest.HexCodeOption.IsSet)
                if (createConstructionSiteStatusRequest.HexCodeOption.Value != null)
                {
                    writer.WriteString("hexCode", createConstructionSiteStatusRequest.HexCode);
                    //var __value = createConstructionSiteStatusRequest.HexCodeOption.Value;
                    //writer.WriteString("hexCode", __value);
                }
                else
                    writer.WriteNull("hexCode");

            if (createConstructionSiteStatusRequest.NameOption.IsSet)
                if (createConstructionSiteStatusRequest.NameOption.Value != null)
                {
                    writer.WriteString("name", createConstructionSiteStatusRequest.Name);
                    //var __value = createConstructionSiteStatusRequest.NameOption.Value;
                    //writer.WriteString("name", __value);
                }
                else
                    writer.WriteNull("name");

            if (createConstructionSiteStatusRequest.NumberOption.IsSet)
                if (createConstructionSiteStatusRequest.NumberOption.Value != null)
                {
                    writer.WriteString("number", createConstructionSiteStatusRequest.Number);
                    //var __value = createConstructionSiteStatusRequest.NumberOption.Value;
                    //writer.WriteString("number", __value);
                }
                else
                    writer.WriteNull("number");

            if (createConstructionSiteStatusRequest.RolesOption.IsSet)
                if (createConstructionSiteStatusRequest.RolesOption.Value != null)
                {
                    writer.WritePropertyName("roles");
                    JsonSerializer.Serialize(writer, createConstructionSiteStatusRequest.Roles, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("roles");
        }
    }
}
