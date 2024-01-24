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
    /// GetTemperatureResponse
    /// </summary>
    public partial class GetTemperatureResponse : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public GetTemperatureResponse()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTemperatureResponse" /> class.
        /// </summary>
        /// <param name="dateTime">dateTime</param>
        /// <param name="location">location</param>
        /// <param name="sensor">sensor</param>
        /// <param name="state">state</param>
        /// <param name="temperature">temperature</param>
        /// <param name="vehicle">vehicle</param>
        //[JsonConstructor]
        public GetTemperatureResponse(Option<DateTime> dateTime = default, Option<Location> location = default, Option<Sensor> sensor = default, Option<string> state = default, Option<double> temperature = default, Option<Vehicle> vehicle = default)
        {
            DateTimeOption = dateTime;
            LocationOption = location;
            SensorOption = sensor;
            StateOption = state;
            TemperatureOption = temperature;
            VehicleOption = vehicle;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of DateTime
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<DateTime>))]
        public Option<DateTime> DateTimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [JsonPropertyName("dateTime")]
        public DateTime? DateTime { get { return this. DateTimeOption; } set { this.DateTimeOption = new Option<DateTime>(value); } }

        /// <summary>
        /// Used to track the state of Location
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Location>))]
        public Option<Location> LocationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [JsonPropertyName("location")]
        public Location? Location { get { return this. LocationOption; } set { this.LocationOption = new Option<Location>(value); } }

        /// <summary>
        /// Used to track the state of Sensor
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Sensor>))]
        public Option<Sensor> SensorOption { get; private set; }

        /// <summary>
        /// Gets or Sets Sensor
        /// </summary>
        [JsonPropertyName("sensor")]
        public Sensor? Sensor { get { return this. SensorOption; } set { this.SensorOption = new Option<Sensor>(value); } }

        /// <summary>
        /// Used to track the state of State
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> StateOption { get; private set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonPropertyName("state")]
        public string? State { get { return this. StateOption; } set { this.StateOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Temperature
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<double>))]
        public Option<double> TemperatureOption { get; private set; }

        /// <summary>
        /// Gets or Sets Temperature
        /// </summary>
        [JsonPropertyName("temperature")]
        public double? Temperature { get { return this. TemperatureOption; } set { this.TemperatureOption = new Option<double>(value); } }

        /// <summary>
        /// Used to track the state of Vehicle
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Vehicle>))]
        public Option<Vehicle> VehicleOption { get; private set; }

        /// <summary>
        /// Gets or Sets Vehicle
        /// </summary>
        [JsonPropertyName("vehicle")]
        public Vehicle? Vehicle { get { return this. VehicleOption; } set { this.VehicleOption = new Option<Vehicle>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetTemperatureResponse {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Sensor: ").Append(Sensor).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  Vehicle: ").Append(Vehicle).Append("\n");
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
    /// A Json converter for type <see cref="GetTemperatureResponse" />
    /// </summary>
    public class GetTemperatureResponseJsonConverter : JsonConverter<GetTemperatureResponse>
    {
        /// <summary>
        /// The format to use to serialize DateTime
        /// </summary>
        public static string DateTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="GetTemperatureResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetTemperatureResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTime> dateTime = default;
            Option<Location> location = default;
            Option<Sensor> sensor = default;
            Option<string> state = default;
            Option<double> temperature = default;
            Option<Vehicle> vehicle = default;

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
                        case "dateTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dateTime = new Option<DateTime>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "location":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                location = new Option<Location>(JsonSerializer.Deserialize<Location>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "sensor":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                sensor = new Option<Sensor>(JsonSerializer.Deserialize<Sensor>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "state":
                            state = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "temperature":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                temperature = new Option<double>(utf8JsonReader.GetDouble());
                            break;
                        case "vehicle":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                vehicle = new Option<Vehicle>(JsonSerializer.Deserialize<Vehicle>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (location.IsSet && location.Value == null)
                throw new ArgumentNullException(nameof(location), "Property is not nullable for class GetTemperatureResponse.");

            if (sensor.IsSet && sensor.Value == null)
                throw new ArgumentNullException(nameof(sensor), "Property is not nullable for class GetTemperatureResponse.");

            if (vehicle.IsSet && vehicle.Value == null)
                throw new ArgumentNullException(nameof(vehicle), "Property is not nullable for class GetTemperatureResponse.");

            //2return new GetTemperatureResponse(dateTime, location, sensor, state, temperature, vehicle);
            return new GetTemperatureResponse(dateTime, location, sensor, state, temperature, vehicle);
        }

        /// <summary>
        /// Serializes a <see cref="GetTemperatureResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTemperatureResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetTemperatureResponse getTemperatureResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, getTemperatureResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetTemperatureResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getTemperatureResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, GetTemperatureResponse getTemperatureResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getTemperatureResponse.LocationOption.IsSet && getTemperatureResponse.Location == null)
                throw new ArgumentNullException(nameof(getTemperatureResponse.Location), "Property is required for class GetTemperatureResponse.");

            if (getTemperatureResponse.SensorOption.IsSet && getTemperatureResponse.Sensor == null)
                throw new ArgumentNullException(nameof(getTemperatureResponse.Sensor), "Property is required for class GetTemperatureResponse.");

            if (getTemperatureResponse.VehicleOption.IsSet && getTemperatureResponse.Vehicle == null)
                throw new ArgumentNullException(nameof(getTemperatureResponse.Vehicle), "Property is required for class GetTemperatureResponse.");

            if (getTemperatureResponse.DateTimeOption.IsSet)
                if (getTemperatureResponse.DateTimeOption.Value != null)
                {
                    writer.WriteString("dateTime", getTemperatureResponse.DateTimeOption!.Value.ToString(DateTimeFormat));
                    //var __value = getTemperatureResponse.DateTimeOption.Value;
                    //writer.WriteString("dateTime", __value);
                }
                else
                    writer.WriteNull("dateTime");

            if (getTemperatureResponse.LocationOption.IsSet)
            {
                writer.WritePropertyName("location");
                JsonSerializer.Serialize(writer, getTemperatureResponse.Location, jsonSerializerOptions);
            }
            if (getTemperatureResponse.SensorOption.IsSet)
            {
                writer.WritePropertyName("sensor");
                JsonSerializer.Serialize(writer, getTemperatureResponse.Sensor, jsonSerializerOptions);
            }
            if (getTemperatureResponse.StateOption.IsSet)
                if (getTemperatureResponse.StateOption.Value != null)
                {
                    writer.WriteString("state", getTemperatureResponse.State);
                    //var __value = getTemperatureResponse.StateOption.Value;
                    //writer.WriteString("state", __value);
                }
                else
                    writer.WriteNull("state");

            if (getTemperatureResponse.TemperatureOption.IsSet)
                if (getTemperatureResponse.TemperatureOption.Value != null)
                {
                    writer.WriteNumber("temperature", getTemperatureResponse.TemperatureOption!.Value);
                    //var __value = getTemperatureResponse.TemperatureOption.Value;
                    //writer.WriteString("temperature", __value);
                }
                else
                    writer.WriteNull("temperature");

            if (getTemperatureResponse.VehicleOption.IsSet)
            {
                writer.WritePropertyName("vehicle");
                JsonSerializer.Serialize(writer, getTemperatureResponse.Vehicle, jsonSerializerOptions);
            }
        }
    }
}
