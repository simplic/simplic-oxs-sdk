// <auto-generated>
/*
 * Simplic.OxS.vehicle-temperature
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

namespace Simplic.OxS.SDK.Vehicle.Temperature
{
    /// <summary>
    /// ConfigurationModel
    /// </summary>
    public partial class ConfigurationModel : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public ConfigurationModel()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationModel" /> class.
        /// </summary>
        /// <param name="companyName">companyName</param>
        /// <param name="createDateTime">createDateTime</param>
        /// <param name="createUserId">createUserId</param>
        /// <param name="createUserName">createUserName</param>
        /// <param name="denmarkConfiguration">denmarkConfiguration</param>
        /// <param name="id">id</param>
        /// <param name="isDeleted">isDeleted</param>
        /// <param name="updateDateTime">updateDateTime</param>
        /// <param name="updateUserId">updateUserId</param>
        /// <param name="updateUserName">updateUserName</param>
        //[JsonConstructor]
        public ConfigurationModel(Option<string> companyName = default, Option<DateTime> createDateTime = default, Option<Guid> createUserId = default, Option<string> createUserName = default, Option<DenmarkProviderConfiguration> denmarkConfiguration = default, Option<Guid> id = default, Option<bool> isDeleted = default, Option<DateTime> updateDateTime = default, Option<Guid> updateUserId = default, Option<string> updateUserName = default)
        {
            CompanyNameOption = companyName;
            CreateDateTimeOption = createDateTime;
            CreateUserIdOption = createUserId;
            CreateUserNameOption = createUserName;
            DenmarkConfigurationOption = denmarkConfiguration;
            IdOption = id;
            IsDeletedOption = isDeleted;
            UpdateDateTimeOption = updateDateTime;
            UpdateUserIdOption = updateUserId;
            UpdateUserNameOption = updateUserName;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of CompanyName
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> CompanyNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [JsonPropertyName("companyName")]
        public string? CompanyName { get { return this. CompanyNameOption; } set { this.CompanyNameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of CreateDateTime
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<DateTime>))]
        public Option<DateTime> CreateDateTimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets CreateDateTime
        /// </summary>
        [JsonPropertyName("createDateTime")]
        public DateTime? CreateDateTime { get { return this. CreateDateTimeOption; } set { this.CreateDateTimeOption = new Option<DateTime>(value); } }

        /// <summary>
        /// Used to track the state of CreateUserId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> CreateUserIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets CreateUserId
        /// </summary>
        [JsonPropertyName("createUserId")]
        public Guid? CreateUserId { get { return this. CreateUserIdOption; } set { this.CreateUserIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of CreateUserName
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> CreateUserNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets CreateUserName
        /// </summary>
        [JsonPropertyName("createUserName")]
        public string? CreateUserName { get { return this. CreateUserNameOption; } set { this.CreateUserNameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of DenmarkConfiguration
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<DenmarkProviderConfiguration>))]
        public Option<DenmarkProviderConfiguration> DenmarkConfigurationOption { get; private set; }

        /// <summary>
        /// Gets or Sets DenmarkConfiguration
        /// </summary>
        [JsonPropertyName("denmarkConfiguration")]
        public DenmarkProviderConfiguration? DenmarkConfiguration { get { return this. DenmarkConfigurationOption; } set { this.DenmarkConfigurationOption = new Option<DenmarkProviderConfiguration>(value); } }

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
        /// Used to track the state of IsDeleted
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<bool>))]
        public Option<bool> IsDeletedOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsDeleted
        /// </summary>
        [JsonPropertyName("isDeleted")]
        public bool? IsDeleted { get { return this. IsDeletedOption; } set { this.IsDeletedOption = new Option<bool>(value); } }

        /// <summary>
        /// Used to track the state of UpdateDateTime
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<DateTime>))]
        public Option<DateTime> UpdateDateTimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets UpdateDateTime
        /// </summary>
        [JsonPropertyName("updateDateTime")]
        public DateTime? UpdateDateTime { get { return this. UpdateDateTimeOption; } set { this.UpdateDateTimeOption = new Option<DateTime>(value); } }

        /// <summary>
        /// Used to track the state of UpdateUserId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> UpdateUserIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets UpdateUserId
        /// </summary>
        [JsonPropertyName("updateUserId")]
        public Guid? UpdateUserId { get { return this. UpdateUserIdOption; } set { this.UpdateUserIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of UpdateUserName
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> UpdateUserNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets UpdateUserName
        /// </summary>
        [JsonPropertyName("updateUserName")]
        public string? UpdateUserName { get { return this. UpdateUserNameOption; } set { this.UpdateUserNameOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigurationModel {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  CreateDateTime: ").Append(CreateDateTime).Append("\n");
            sb.Append("  CreateUserId: ").Append(CreateUserId).Append("\n");
            sb.Append("  CreateUserName: ").Append(CreateUserName).Append("\n");
            sb.Append("  DenmarkConfiguration: ").Append(DenmarkConfiguration).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  UpdateDateTime: ").Append(UpdateDateTime).Append("\n");
            sb.Append("  UpdateUserId: ").Append(UpdateUserId).Append("\n");
            sb.Append("  UpdateUserName: ").Append(UpdateUserName).Append("\n");
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
    /// A Json converter for type <see cref="ConfigurationModel" />
    /// </summary>
    public class ConfigurationModelJsonConverter : JsonConverter<ConfigurationModel>
    {
        /// <summary>
        /// The format to use to serialize CreateDateTime
        /// </summary>
        public static string CreateDateTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize UpdateDateTime
        /// </summary>
        public static string UpdateDateTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="ConfigurationModel" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ConfigurationModel Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> companyName = default;
            Option<DateTime> createDateTime = default;
            Option<Guid> createUserId = default;
            Option<string> createUserName = default;
            Option<DenmarkProviderConfiguration> denmarkConfiguration = default;
            Option<Guid> id = default;
            Option<bool> isDeleted = default;
            Option<DateTime> updateDateTime = default;
            Option<Guid> updateUserId = default;
            Option<string> updateUserName = default;

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
                        case "companyName":
                            companyName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "createDateTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createDateTime = new Option<DateTime>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "createUserId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createUserId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "createUserName":
                            createUserName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "denmarkConfiguration":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                denmarkConfiguration = new Option<DenmarkProviderConfiguration>(JsonSerializer.Deserialize<DenmarkProviderConfiguration>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "isDeleted":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isDeleted = new Option<bool>(utf8JsonReader.GetBoolean());
                            break;
                        case "updateDateTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updateDateTime = new Option<DateTime>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "updateUserId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updateUserId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "updateUserName":
                            updateUserName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (createDateTime.IsSet && createDateTime.Value == null)
                throw new ArgumentNullException(nameof(createDateTime), "Property is not nullable for class ConfigurationModel.");

            if (denmarkConfiguration.IsSet && denmarkConfiguration.Value == null)
                throw new ArgumentNullException(nameof(denmarkConfiguration), "Property is not nullable for class ConfigurationModel.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class ConfigurationModel.");

            if (isDeleted.IsSet && isDeleted.Value == null)
                throw new ArgumentNullException(nameof(isDeleted), "Property is not nullable for class ConfigurationModel.");

            if (updateDateTime.IsSet && updateDateTime.Value == null)
                throw new ArgumentNullException(nameof(updateDateTime), "Property is not nullable for class ConfigurationModel.");

            //2return new ConfigurationModel(companyName, createDateTime, createUserId, createUserName, denmarkConfiguration, id, isDeleted, updateDateTime, updateUserId, updateUserName);
            return new ConfigurationModel(companyName, createDateTime, createUserId, createUserName, denmarkConfiguration, id, isDeleted, updateDateTime, updateUserId, updateUserName);
        }

        /// <summary>
        /// Serializes a <see cref="ConfigurationModel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="configurationModel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ConfigurationModel configurationModel, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, configurationModel, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ConfigurationModel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="configurationModel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, ConfigurationModel configurationModel, JsonSerializerOptions jsonSerializerOptions)
        {
            if (configurationModel.DenmarkConfigurationOption.IsSet && configurationModel.DenmarkConfiguration == null)
                throw new ArgumentNullException(nameof(configurationModel.DenmarkConfiguration), "Property is required for class ConfigurationModel.");

            if (configurationModel.CompanyNameOption.IsSet)
                if (configurationModel.CompanyNameOption.Value != null)
                {
                    writer.WriteString("companyName", configurationModel.CompanyName);
                    //var __value = configurationModel.CompanyNameOption.Value;
                    //writer.WriteString("companyName", __value);
                }
                else
                    writer.WriteNull("companyName");

            if (configurationModel.CreateDateTimeOption.IsSet)
                writer.WriteString("createDateTime", configurationModel.CreateDateTimeOption!.Value.ToString(CreateDateTimeFormat));

            if (configurationModel.CreateUserIdOption.IsSet)
                if (configurationModel.CreateUserIdOption.Value != null)
                {
                    writer.WriteString("createUserId", configurationModel.CreateUserIdOption!.Value);
                    //var __value = configurationModel.CreateUserIdOption.Value;
                    //writer.WriteString("createUserId", __value);
                }
                else
                    writer.WriteNull("createUserId");

            if (configurationModel.CreateUserNameOption.IsSet)
                if (configurationModel.CreateUserNameOption.Value != null)
                {
                    writer.WriteString("createUserName", configurationModel.CreateUserName);
                    //var __value = configurationModel.CreateUserNameOption.Value;
                    //writer.WriteString("createUserName", __value);
                }
                else
                    writer.WriteNull("createUserName");

            if (configurationModel.DenmarkConfigurationOption.IsSet)
            {
                writer.WritePropertyName("denmarkConfiguration");
                JsonSerializer.Serialize(writer, configurationModel.DenmarkConfiguration, jsonSerializerOptions);
            }
            if (configurationModel.IdOption.IsSet)
                writer.WriteString("id", configurationModel.IdOption!.Value);

            if (configurationModel.IsDeletedOption.IsSet)
                writer.WriteBoolean("isDeleted", configurationModel.IsDeletedOption!.Value);

            if (configurationModel.UpdateDateTimeOption.IsSet)
                writer.WriteString("updateDateTime", configurationModel.UpdateDateTimeOption!.Value.ToString(UpdateDateTimeFormat));

            if (configurationModel.UpdateUserIdOption.IsSet)
                if (configurationModel.UpdateUserIdOption.Value != null)
                {
                    writer.WriteString("updateUserId", configurationModel.UpdateUserIdOption!.Value);
                    //var __value = configurationModel.UpdateUserIdOption.Value;
                    //writer.WriteString("updateUserId", __value);
                }
                else
                    writer.WriteNull("updateUserId");

            if (configurationModel.UpdateUserNameOption.IsSet)
                if (configurationModel.UpdateUserNameOption.Value != null)
                {
                    writer.WriteString("updateUserName", configurationModel.UpdateUserName);
                    //var __value = configurationModel.UpdateUserNameOption.Value;
                    //writer.WriteString("updateUserName", __value);
                }
                else
                    writer.WriteNull("updateUserName");
        }
    }
}
