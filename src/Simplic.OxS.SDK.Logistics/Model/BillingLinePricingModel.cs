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
    /// Shared model of billing line pricing.
    /// </summary>
    public partial class BillingLinePricingModel : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public BillingLinePricingModel()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingLinePricingModel" /> class.
        /// </summary>
        /// <param name="id">Gets or sets the id of the selected pricing configuration.</param>
        /// <param name="name">Gets or sets the name of the selected pricing configuration.</param>
        //[JsonConstructor]
        public BillingLinePricingModel(Option<Guid> id = default, Option<string> name = default)
        {
            IdOption = id;
            NameOption = name;
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
        /// Gets or sets the id of the selected pricing configuration.
        /// </summary>
        /// <value>Gets or sets the id of the selected pricing configuration.</value>
        [JsonPropertyName("id")]
        public Guid? Id { get { return this. IdOption; } set { this.IdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> NameOption { get; private set; }

        /// <summary>
        /// Gets or sets the name of the selected pricing configuration.
        /// </summary>
        /// <value>Gets or sets the name of the selected pricing configuration.</value>
        [JsonPropertyName("name")]
        public string? Name { get { return this. NameOption; } set { this.NameOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BillingLinePricingModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
    /// A Json converter for type <see cref="BillingLinePricingModel" />
    /// </summary>
    public class BillingLinePricingModelJsonConverter : JsonConverter<BillingLinePricingModel>
    {
        /// <summary>
        /// Deserializes json to <see cref="BillingLinePricingModel" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override BillingLinePricingModel Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<Guid> id = default;
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
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "name":
                            name = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class BillingLinePricingModel.");

            //2return new BillingLinePricingModel(id, name);
            return new BillingLinePricingModel(id, name);
        }

        /// <summary>
        /// Serializes a <see cref="BillingLinePricingModel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="billingLinePricingModel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, BillingLinePricingModel billingLinePricingModel, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, billingLinePricingModel, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="BillingLinePricingModel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="billingLinePricingModel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, BillingLinePricingModel billingLinePricingModel, JsonSerializerOptions jsonSerializerOptions)
        {
            if (billingLinePricingModel.IdOption.IsSet)
                writer.WriteString("id", billingLinePricingModel.IdOption!.Value);

            if (billingLinePricingModel.NameOption.IsSet)
                if (billingLinePricingModel.NameOption.Value != null)
                {
                    writer.WriteString("name", billingLinePricingModel.Name);
                    //var __value = billingLinePricingModel.NameOption.Value;
                    //writer.WriteString("name", __value);
                }
                else
                    writer.WriteNull("name");
        }
    }
}
