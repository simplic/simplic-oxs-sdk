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
    /// GeoLocation
    /// </summary>
    public partial class GeoLocation : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public GeoLocation()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeoLocation" /> class.
        /// </summary>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        //[JsonConstructor]
        public GeoLocation(Option<double> latitude = default, Option<double> longitude = default)
        {
            LatitudeOption = latitude;
            LongitudeOption = longitude;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Latitude
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<double>))]
        public Option<double> LatitudeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [JsonPropertyName("latitude")]
        public double? Latitude { get { return this. LatitudeOption; } set { this.LatitudeOption = new Option<double>(value); } }

        /// <summary>
        /// Used to track the state of Longitude
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<double>))]
        public Option<double> LongitudeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [JsonPropertyName("longitude")]
        public double? Longitude { get { return this. LongitudeOption; } set { this.LongitudeOption = new Option<double>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GeoLocation {\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
    /// A Json converter for type <see cref="GeoLocation" />
    /// </summary>
    public class GeoLocationJsonConverter : JsonConverter<GeoLocation>
    {
        /// <summary>
        /// Deserializes json to <see cref="GeoLocation" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GeoLocation Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<double> latitude = default;
            Option<double> longitude = default;

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
                        case "latitude":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                latitude = new Option<double>(utf8JsonReader.GetDouble());
                            break;
                        case "longitude":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                longitude = new Option<double>(utf8JsonReader.GetDouble());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (latitude.IsSet && latitude.Value == null)
                throw new ArgumentNullException(nameof(latitude), "Property is not nullable for class GeoLocation.");

            if (longitude.IsSet && longitude.Value == null)
                throw new ArgumentNullException(nameof(longitude), "Property is not nullable for class GeoLocation.");

            //2return new GeoLocation(latitude, longitude);
            return new GeoLocation(latitude, longitude);
        }

        /// <summary>
        /// Serializes a <see cref="GeoLocation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="geoLocation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GeoLocation geoLocation, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, geoLocation, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GeoLocation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="geoLocation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GeoLocation geoLocation, JsonSerializerOptions jsonSerializerOptions)
        {
            if (geoLocation.LatitudeOption.IsSet)
                writer.WriteNumber("latitude", geoLocation.LatitudeOption!.Value);

            if (geoLocation.LongitudeOption.IsSet)
                writer.WriteNumber("longitude", geoLocation.LongitudeOption!.Value);
        }
    }
}
