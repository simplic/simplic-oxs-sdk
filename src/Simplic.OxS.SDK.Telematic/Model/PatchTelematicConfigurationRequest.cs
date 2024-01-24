// <auto-generated>
/*
 * Simplic.OxS.Telematic
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

namespace Simplic.OxS.SDK.Telematic
{
    /// <summary>
    /// PatchTelematicConfigurationRequest
    /// </summary>
    public partial class PatchTelematicConfigurationRequest : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public PatchTelematicConfigurationRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTelematicConfigurationRequest" /> class.
        /// </summary>
        /// <param name="providerConfiguration">providerConfiguration</param>
        //[JsonConstructor]
        public PatchTelematicConfigurationRequest(Option<PatchProviderConfiguration> providerConfiguration = default)
        {
            ProviderConfigurationOption = providerConfiguration;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ProviderConfiguration
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<PatchProviderConfiguration>))]
        public Option<PatchProviderConfiguration> ProviderConfigurationOption { get; private set; }

        /// <summary>
        /// Gets or Sets ProviderConfiguration
        /// </summary>
        [JsonPropertyName("providerConfiguration")]
        public PatchProviderConfiguration? ProviderConfiguration { get { return this. ProviderConfigurationOption; } set { this.ProviderConfigurationOption = new Option<PatchProviderConfiguration>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PatchTelematicConfigurationRequest {\n");
            sb.Append("  ProviderConfiguration: ").Append(ProviderConfiguration).Append("\n");
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
    /// A Json converter for type <see cref="PatchTelematicConfigurationRequest" />
    /// </summary>
    public class PatchTelematicConfigurationRequestJsonConverter : JsonConverter<PatchTelematicConfigurationRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="PatchTelematicConfigurationRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PatchTelematicConfigurationRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<PatchProviderConfiguration> providerConfiguration = default;

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
                        case "providerConfiguration":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                providerConfiguration = new Option<PatchProviderConfiguration>(JsonSerializer.Deserialize<PatchProviderConfiguration>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (providerConfiguration.IsSet && providerConfiguration.Value == null)
                throw new ArgumentNullException(nameof(providerConfiguration), "Property is not nullable for class PatchTelematicConfigurationRequest.");

            //2return new PatchTelematicConfigurationRequest(providerConfiguration);
            return new PatchTelematicConfigurationRequest(providerConfiguration);
        }

        /// <summary>
        /// Serializes a <see cref="PatchTelematicConfigurationRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="patchTelematicConfigurationRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PatchTelematicConfigurationRequest patchTelematicConfigurationRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, patchTelematicConfigurationRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PatchTelematicConfigurationRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="patchTelematicConfigurationRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, PatchTelematicConfigurationRequest patchTelematicConfigurationRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (patchTelematicConfigurationRequest.ProviderConfigurationOption.IsSet && patchTelematicConfigurationRequest.ProviderConfiguration == null)
                throw new ArgumentNullException(nameof(patchTelematicConfigurationRequest.ProviderConfiguration), "Property is required for class PatchTelematicConfigurationRequest.");

            if (patchTelematicConfigurationRequest.ProviderConfigurationOption.IsSet)
            {
                writer.WritePropertyName("providerConfiguration");
                JsonSerializer.Serialize(writer, patchTelematicConfigurationRequest.ProviderConfiguration, jsonSerializerOptions);
            }
        }
    }
}
