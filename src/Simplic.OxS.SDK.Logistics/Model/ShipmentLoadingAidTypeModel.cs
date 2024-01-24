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
    /// Shared model of laoding aid type.
    /// </summary>
    public partial class ShipmentLoadingAidTypeModel : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public ShipmentLoadingAidTypeModel()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentLoadingAidTypeModel" /> class.
        /// </summary>
        /// <param name="displayName">Gets or sets the display name.</param>
        /// <param name="id">Gets or sets the guid.  &lt;br&gt;  Represents the unique identifier of a loading aid type.  </param>
        /// <param name="length">Gets or sets the length.</param>
        /// <param name="number">Gets or sets the number.  &lt;br&gt;  Represents a human readable identifier.  </param>
        /// <param name="shortText">Gets or sets the short text.</param>
        /// <param name="storagePosition">Gets or sets the storage position.</param>
        /// <param name="weight">Gets or sets the weight.</param>
        /// <param name="width">Gets or sets the width.</param>
        //[JsonConstructor]
        public ShipmentLoadingAidTypeModel(Option<string> displayName = default, Option<Guid> id = default, Option<int> length = default, Option<int> number = default, Option<string> shortText = default, Option<double> storagePosition = default, Option<double> weight = default, Option<int> width = default)
        {
            DisplayNameOption = displayName;
            IdOption = id;
            LengthOption = length;
            NumberOption = number;
            ShortTextOption = shortText;
            StoragePositionOption = storagePosition;
            WeightOption = weight;
            WidthOption = width;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of DisplayName
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> DisplayNameOption { get; private set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>Gets or sets the display name.</value>
        [JsonPropertyName("displayName")]
        public string? DisplayName { get { return this. DisplayNameOption; } set { this.DisplayNameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> IdOption { get; private set; }

        /// <summary>
        /// Gets or sets the guid.  &lt;br&gt;  Represents the unique identifier of a loading aid type.  
        /// </summary>
        /// <value>Gets or sets the guid.  &lt;br&gt;  Represents the unique identifier of a loading aid type.  </value>
        [JsonPropertyName("id")]
        public Guid? Id { get { return this. IdOption; } set { this.IdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of Length
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<int>))]
        public Option<int> LengthOption { get; private set; }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>Gets or sets the length.</value>
        [JsonPropertyName("length")]
        public int? Length { get { return this. LengthOption; } set { this.LengthOption = new Option<int>(value); } }

        /// <summary>
        /// Used to track the state of Number
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<int>))]
        public Option<int> NumberOption { get; private set; }

        /// <summary>
        /// Gets or sets the number.  &lt;br&gt;  Represents a human readable identifier.  
        /// </summary>
        /// <value>Gets or sets the number.  &lt;br&gt;  Represents a human readable identifier.  </value>
        [JsonPropertyName("number")]
        public int? Number { get { return this. NumberOption; } set { this.NumberOption = new Option<int>(value); } }

        /// <summary>
        /// Used to track the state of ShortText
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> ShortTextOption { get; private set; }

        /// <summary>
        /// Gets or sets the short text.
        /// </summary>
        /// <value>Gets or sets the short text.</value>
        [JsonPropertyName("shortText")]
        public string? ShortText { get { return this. ShortTextOption; } set { this.ShortTextOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of StoragePosition
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<double>))]
        public Option<double> StoragePositionOption { get; private set; }

        /// <summary>
        /// Gets or sets the storage position.
        /// </summary>
        /// <value>Gets or sets the storage position.</value>
        [JsonPropertyName("storagePosition")]
        public double? StoragePosition { get { return this. StoragePositionOption; } set { this.StoragePositionOption = new Option<double>(value); } }

        /// <summary>
        /// Used to track the state of Weight
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<double>))]
        public Option<double> WeightOption { get; private set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>Gets or sets the weight.</value>
        [JsonPropertyName("weight")]
        public double? Weight { get { return this. WeightOption; } set { this.WeightOption = new Option<double>(value); } }

        /// <summary>
        /// Used to track the state of Width
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<int>))]
        public Option<int> WidthOption { get; private set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>Gets or sets the width.</value>
        [JsonPropertyName("width")]
        public int? Width { get { return this. WidthOption; } set { this.WidthOption = new Option<int>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentLoadingAidTypeModel {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  ShortText: ").Append(ShortText).Append("\n");
            sb.Append("  StoragePosition: ").Append(StoragePosition).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
    /// A Json converter for type <see cref="ShipmentLoadingAidTypeModel" />
    /// </summary>
    public class ShipmentLoadingAidTypeModelJsonConverter : JsonConverter<ShipmentLoadingAidTypeModel>
    {
        /// <summary>
        /// Deserializes json to <see cref="ShipmentLoadingAidTypeModel" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ShipmentLoadingAidTypeModel Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> displayName = default;
            Option<Guid> id = default;
            Option<int> length = default;
            Option<int> number = default;
            Option<string> shortText = default;
            Option<double> storagePosition = default;
            Option<double> weight = default;
            Option<int> width = default;

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
                        case "displayName":
                            displayName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "length":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                length = new Option<int>(utf8JsonReader.GetInt32());
                            break;
                        case "number":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                number = new Option<int>(utf8JsonReader.GetInt32());
                            break;
                        case "shortText":
                            shortText = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "storagePosition":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                storagePosition = new Option<double>(utf8JsonReader.GetDouble());
                            break;
                        case "weight":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                weight = new Option<double>(utf8JsonReader.GetDouble());
                            break;
                        case "width":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                width = new Option<int>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class ShipmentLoadingAidTypeModel.");

            if (length.IsSet && length.Value == null)
                throw new ArgumentNullException(nameof(length), "Property is not nullable for class ShipmentLoadingAidTypeModel.");

            if (number.IsSet && number.Value == null)
                throw new ArgumentNullException(nameof(number), "Property is not nullable for class ShipmentLoadingAidTypeModel.");

            if (storagePosition.IsSet && storagePosition.Value == null)
                throw new ArgumentNullException(nameof(storagePosition), "Property is not nullable for class ShipmentLoadingAidTypeModel.");

            if (weight.IsSet && weight.Value == null)
                throw new ArgumentNullException(nameof(weight), "Property is not nullable for class ShipmentLoadingAidTypeModel.");

            if (width.IsSet && width.Value == null)
                throw new ArgumentNullException(nameof(width), "Property is not nullable for class ShipmentLoadingAidTypeModel.");

            //2return new ShipmentLoadingAidTypeModel(displayName, id, length, number, shortText, storagePosition, weight, width);
            return new ShipmentLoadingAidTypeModel(displayName, id, length, number, shortText, storagePosition, weight, width);
        }

        /// <summary>
        /// Serializes a <see cref="ShipmentLoadingAidTypeModel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="shipmentLoadingAidTypeModel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ShipmentLoadingAidTypeModel shipmentLoadingAidTypeModel, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, shipmentLoadingAidTypeModel, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ShipmentLoadingAidTypeModel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="shipmentLoadingAidTypeModel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, ShipmentLoadingAidTypeModel shipmentLoadingAidTypeModel, JsonSerializerOptions jsonSerializerOptions)
        {
            if (shipmentLoadingAidTypeModel.DisplayNameOption.IsSet)
                if (shipmentLoadingAidTypeModel.DisplayNameOption.Value != null)
                {
                    writer.WriteString("displayName", shipmentLoadingAidTypeModel.DisplayName);
                    //var __value = shipmentLoadingAidTypeModel.DisplayNameOption.Value;
                    //writer.WriteString("displayName", __value);
                }
                else
                    writer.WriteNull("displayName");

            if (shipmentLoadingAidTypeModel.IdOption.IsSet)
                writer.WriteString("id", shipmentLoadingAidTypeModel.IdOption!.Value);

            if (shipmentLoadingAidTypeModel.LengthOption.IsSet)
                writer.WriteNumber("length", shipmentLoadingAidTypeModel.LengthOption!.Value);

            if (shipmentLoadingAidTypeModel.NumberOption.IsSet)
                writer.WriteNumber("number", shipmentLoadingAidTypeModel.NumberOption!.Value);

            if (shipmentLoadingAidTypeModel.ShortTextOption.IsSet)
                if (shipmentLoadingAidTypeModel.ShortTextOption.Value != null)
                {
                    writer.WriteString("shortText", shipmentLoadingAidTypeModel.ShortText);
                    //var __value = shipmentLoadingAidTypeModel.ShortTextOption.Value;
                    //writer.WriteString("shortText", __value);
                }
                else
                    writer.WriteNull("shortText");

            if (shipmentLoadingAidTypeModel.StoragePositionOption.IsSet)
                writer.WriteNumber("storagePosition", shipmentLoadingAidTypeModel.StoragePositionOption!.Value);

            if (shipmentLoadingAidTypeModel.WeightOption.IsSet)
                writer.WriteNumber("weight", shipmentLoadingAidTypeModel.WeightOption!.Value);

            if (shipmentLoadingAidTypeModel.WidthOption.IsSet)
                writer.WriteNumber("width", shipmentLoadingAidTypeModel.WidthOption!.Value);
        }
    }
}
