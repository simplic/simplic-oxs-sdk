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
    /// Model to represent the tuple of a counry iso and a zip code.
    /// </summary>
    public partial class RegionModel : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public RegionModel()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionModel" /> class.
        /// </summary>
        /// <param name="countryIso">Represents the country iso for a region.</param>
        /// <param name="zipCode">Represents the zipcode, or the start of a zipcode for a region.</param>
        //[JsonConstructor]
        public RegionModel(Option<string> countryIso = default, Option<string> zipCode = default)
        {
            CountryIsoOption = countryIso;
            ZipCodeOption = zipCode;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of CountryIso
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> CountryIsoOption { get; private set; }

        /// <summary>
        /// Represents the country iso for a region.
        /// </summary>
        /// <value>Represents the country iso for a region.</value>
        [JsonPropertyName("countryIso")]
        public string? CountryIso { get { return this. CountryIsoOption; } set { this.CountryIsoOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of ZipCode
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> ZipCodeOption { get; private set; }

        /// <summary>
        /// Represents the zipcode, or the start of a zipcode for a region.
        /// </summary>
        /// <value>Represents the zipcode, or the start of a zipcode for a region.</value>
        [JsonPropertyName("zipCode")]
        public string? ZipCode { get { return this. ZipCodeOption; } set { this.ZipCodeOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RegionModel {\n");
            sb.Append("  CountryIso: ").Append(CountryIso).Append("\n");
            sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
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
    /// A Json converter for type <see cref="RegionModel" />
    /// </summary>
    public class RegionModelJsonConverter : JsonConverter<RegionModel>
    {
        /// <summary>
        /// Deserializes json to <see cref="RegionModel" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override RegionModel Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> countryIso = default;
            Option<string> zipCode = default;

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
                        case "countryIso":
                            countryIso = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "zipCode":
                            zipCode = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            //2return new RegionModel(countryIso, zipCode);
            return new RegionModel(countryIso, zipCode);
        }

        /// <summary>
        /// Serializes a <see cref="RegionModel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="regionModel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, RegionModel regionModel, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, regionModel, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="RegionModel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="regionModel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, RegionModel regionModel, JsonSerializerOptions jsonSerializerOptions)
        {
            if (regionModel.CountryIsoOption.IsSet)
                if (regionModel.CountryIsoOption.Value != null)
                {
                    writer.WriteString("countryIso", regionModel.CountryIso);
                    //var __value = regionModel.CountryIsoOption.Value;
                    //writer.WriteString("countryIso", __value);
                }
                else
                    writer.WriteNull("countryIso");

            if (regionModel.ZipCodeOption.IsSet)
                if (regionModel.ZipCodeOption.Value != null)
                {
                    writer.WriteString("zipCode", regionModel.ZipCode);
                    //var __value = regionModel.ZipCodeOption.Value;
                    //writer.WriteString("zipCode", __value);
                }
                else
                    writer.WriteNull("zipCode");
        }
    }
}
