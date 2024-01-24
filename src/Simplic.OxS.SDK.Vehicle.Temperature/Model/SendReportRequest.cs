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
    /// SendReportRequest
    /// </summary>
    public partial class SendReportRequest : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public SendReportRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendReportRequest" /> class.
        /// </summary>
        /// <param name="attachments">attachments</param>
        /// <param name="eMailAddresses">eMailAddresses</param>
        /// <param name="endDate">endDate</param>
        /// <param name="note">note</param>
        /// <param name="startDate">startDate</param>
        /// <param name="vehicleId">vehicleId</param>
        //[JsonConstructor]
        public SendReportRequest(Option<List<ReportAttachment>> attachments = default, Option<List<string>> eMailAddresses = default, Option<DateTime> endDate = default, Option<string> note = default, Option<DateTime> startDate = default, Option<Guid> vehicleId = default)
        {
            AttachmentsOption = attachments;
            EMailAddressesOption = eMailAddresses;
            EndDateOption = endDate;
            NoteOption = note;
            StartDateOption = startDate;
            VehicleIdOption = vehicleId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Attachments
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<List<ReportAttachment>>))]
        public Option<List<ReportAttachment>> AttachmentsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [JsonPropertyName("attachments")]
        public List<ReportAttachment>? Attachments { get { return this. AttachmentsOption; } set { this.AttachmentsOption = new Option<List<ReportAttachment>>(value); } }

        /// <summary>
        /// Used to track the state of EMailAddresses
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<List<string>>))]
        public Option<List<string>> EMailAddressesOption { get; private set; }

        /// <summary>
        /// Gets or Sets EMailAddresses
        /// </summary>
        [JsonPropertyName("eMailAddresses")]
        public List<string>? EMailAddresses { get { return this. EMailAddressesOption; } set { this.EMailAddressesOption = new Option<List<string>>(value); } }

        /// <summary>
        /// Used to track the state of EndDate
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<DateTime>))]
        public Option<DateTime> EndDateOption { get; private set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get { return this. EndDateOption; } set { this.EndDateOption = new Option<DateTime>(value); } }

        /// <summary>
        /// Used to track the state of Note
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> NoteOption { get; private set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [JsonPropertyName("note")]
        public string? Note { get { return this. NoteOption; } set { this.NoteOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of StartDate
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<DateTime>))]
        public Option<DateTime> StartDateOption { get; private set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get { return this. StartDateOption; } set { this.StartDateOption = new Option<DateTime>(value); } }

        /// <summary>
        /// Used to track the state of VehicleId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> VehicleIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets VehicleId
        /// </summary>
        [JsonPropertyName("vehicleId")]
        public Guid? VehicleId { get { return this. VehicleIdOption; } set { this.VehicleIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SendReportRequest {\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  EMailAddresses: ").Append(EMailAddresses).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  VehicleId: ").Append(VehicleId).Append("\n");
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
    /// A Json converter for type <see cref="SendReportRequest" />
    /// </summary>
    public class SendReportRequestJsonConverter : JsonConverter<SendReportRequest>
    {
        /// <summary>
        /// The format to use to serialize EndDate
        /// </summary>
        public static string EndDateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize StartDate
        /// </summary>
        public static string StartDateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="SendReportRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SendReportRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<ReportAttachment>> attachments = default;
            Option<List<string>> eMailAddresses = default;
            Option<DateTime> endDate = default;
            Option<string> note = default;
            Option<DateTime> startDate = default;
            Option<Guid> vehicleId = default;

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
                        case "attachments":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                attachments = new Option<List<ReportAttachment>>(JsonSerializer.Deserialize<List<ReportAttachment>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "eMailAddresses":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                eMailAddresses = new Option<List<string>>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "endDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                endDate = new Option<DateTime>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "note":
                            note = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "startDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                startDate = new Option<DateTime>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "vehicleId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                vehicleId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (endDate.IsSet && endDate.Value == null)
                throw new ArgumentNullException(nameof(endDate), "Property is not nullable for class SendReportRequest.");

            if (startDate.IsSet && startDate.Value == null)
                throw new ArgumentNullException(nameof(startDate), "Property is not nullable for class SendReportRequest.");

            if (vehicleId.IsSet && vehicleId.Value == null)
                throw new ArgumentNullException(nameof(vehicleId), "Property is not nullable for class SendReportRequest.");

            //2return new SendReportRequest(attachments, eMailAddresses, endDate, note, startDate, vehicleId);
            return new SendReportRequest(attachments, eMailAddresses, endDate, note, startDate, vehicleId);
        }

        /// <summary>
        /// Serializes a <see cref="SendReportRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="sendReportRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SendReportRequest sendReportRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, sendReportRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="SendReportRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="sendReportRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, SendReportRequest sendReportRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (sendReportRequest.AttachmentsOption.IsSet)
                if (sendReportRequest.AttachmentsOption.Value != null)
                {
                    writer.WritePropertyName("attachments");
                    JsonSerializer.Serialize(writer, sendReportRequest.Attachments, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("attachments");
            if (sendReportRequest.EMailAddressesOption.IsSet)
                if (sendReportRequest.EMailAddressesOption.Value != null)
                {
                    writer.WritePropertyName("eMailAddresses");
                    JsonSerializer.Serialize(writer, sendReportRequest.EMailAddresses, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("eMailAddresses");
            if (sendReportRequest.EndDateOption.IsSet)
                writer.WriteString("endDate", sendReportRequest.EndDateOption!.Value.ToString(EndDateFormat));

            if (sendReportRequest.NoteOption.IsSet)
                if (sendReportRequest.NoteOption.Value != null)
                {
                    writer.WriteString("note", sendReportRequest.Note);
                    //var __value = sendReportRequest.NoteOption.Value;
                    //writer.WriteString("note", __value);
                }
                else
                    writer.WriteNull("note");

            if (sendReportRequest.StartDateOption.IsSet)
                writer.WriteString("startDate", sendReportRequest.StartDateOption!.Value.ToString(StartDateFormat));

            if (sendReportRequest.VehicleIdOption.IsSet)
                writer.WriteString("vehicleId", sendReportRequest.VehicleIdOption!.Value);
        }
    }
}
