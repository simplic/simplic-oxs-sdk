// <auto-generated>
/*
 * Simplic.OxS.ERP
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

namespace Simplic.OxS.SDK.ERP
{
    /// <summary>
    /// UpdatePersonalAccountRequest
    /// </summary>
    public partial class UpdatePersonalAccountRequest : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public UpdatePersonalAccountRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePersonalAccountRequest" /> class.
        /// </summary>
        /// <param name="creditLimit">creditLimit</param>
        /// <param name="id">id</param>
        /// <param name="number">number</param>
        /// <param name="purchaseTermsOfPaymentId">purchaseTermsOfPaymentId</param>
        /// <param name="saleTermsOfPaymentId">saleTermsOfPaymentId</param>
        /// <param name="taxGroupId">taxGroupId</param>
        /// <param name="type">type</param>
        /// <param name="vatId">vatId</param>
        //[JsonConstructor]
        public UpdatePersonalAccountRequest(Option<CreditLimitModel> creditLimit = default, Option<Guid> id = default, Option<string> number = default, Option<Guid> purchaseTermsOfPaymentId = default, Option<Guid> saleTermsOfPaymentId = default, Option<Guid> taxGroupId = default, Option<string> type = default, Option<string> vatId = default)
        {
            CreditLimitOption = creditLimit;
            IdOption = id;
            NumberOption = number;
            PurchaseTermsOfPaymentIdOption = purchaseTermsOfPaymentId;
            SaleTermsOfPaymentIdOption = saleTermsOfPaymentId;
            TaxGroupIdOption = taxGroupId;
            TypeOption = type;
            VatIdOption = vatId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of CreditLimit
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<CreditLimitModel>))]
        public Option<CreditLimitModel> CreditLimitOption { get; private set; }

        /// <summary>
        /// Gets or Sets CreditLimit
        /// </summary>
        [JsonPropertyName("creditLimit")]
        public CreditLimitModel? CreditLimit { get { return this. CreditLimitOption; } set { this.CreditLimitOption = new Option<CreditLimitModel>(value); } }

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
        /// Used to track the state of PurchaseTermsOfPaymentId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> PurchaseTermsOfPaymentIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets PurchaseTermsOfPaymentId
        /// </summary>
        [JsonPropertyName("purchaseTermsOfPaymentId")]
        public Guid? PurchaseTermsOfPaymentId { get { return this. PurchaseTermsOfPaymentIdOption; } set { this.PurchaseTermsOfPaymentIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of SaleTermsOfPaymentId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> SaleTermsOfPaymentIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets SaleTermsOfPaymentId
        /// </summary>
        [JsonPropertyName("saleTermsOfPaymentId")]
        public Guid? SaleTermsOfPaymentId { get { return this. SaleTermsOfPaymentIdOption; } set { this.SaleTermsOfPaymentIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of TaxGroupId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> TaxGroupIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets TaxGroupId
        /// </summary>
        [JsonPropertyName("taxGroupId")]
        public Guid? TaxGroupId { get { return this. TaxGroupIdOption; } set { this.TaxGroupIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of Type
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> TypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get { return this. TypeOption; } set { this.TypeOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of VatId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> VatIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets VatId
        /// </summary>
        [JsonPropertyName("vatId")]
        public string? VatId { get { return this. VatIdOption; } set { this.VatIdOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdatePersonalAccountRequest {\n");
            sb.Append("  CreditLimit: ").Append(CreditLimit).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  PurchaseTermsOfPaymentId: ").Append(PurchaseTermsOfPaymentId).Append("\n");
            sb.Append("  SaleTermsOfPaymentId: ").Append(SaleTermsOfPaymentId).Append("\n");
            sb.Append("  TaxGroupId: ").Append(TaxGroupId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VatId: ").Append(VatId).Append("\n");
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
    /// A Json converter for type <see cref="UpdatePersonalAccountRequest" />
    /// </summary>
    public class UpdatePersonalAccountRequestJsonConverter : JsonConverter<UpdatePersonalAccountRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="UpdatePersonalAccountRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UpdatePersonalAccountRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<CreditLimitModel> creditLimit = default;
            Option<Guid> id = default;
            Option<string> number = default;
            Option<Guid> purchaseTermsOfPaymentId = default;
            Option<Guid> saleTermsOfPaymentId = default;
            Option<Guid> taxGroupId = default;
            Option<string> type = default;
            Option<string> vatId = default;

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
                        case "creditLimit":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                creditLimit = new Option<CreditLimitModel>(JsonSerializer.Deserialize<CreditLimitModel>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "number":
                            number = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "purchaseTermsOfPaymentId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                purchaseTermsOfPaymentId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "saleTermsOfPaymentId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                saleTermsOfPaymentId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "taxGroupId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                taxGroupId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "type":
                            type = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "vatId":
                            vatId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (creditLimit.IsSet && creditLimit.Value == null)
                throw new ArgumentNullException(nameof(creditLimit), "Property is not nullable for class UpdatePersonalAccountRequest.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class UpdatePersonalAccountRequest.");

            //2return new UpdatePersonalAccountRequest(creditLimit, id, number, purchaseTermsOfPaymentId, saleTermsOfPaymentId, taxGroupId, type, vatId);
            return new UpdatePersonalAccountRequest(creditLimit, id, number, purchaseTermsOfPaymentId, saleTermsOfPaymentId, taxGroupId, type, vatId);
        }

        /// <summary>
        /// Serializes a <see cref="UpdatePersonalAccountRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="updatePersonalAccountRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UpdatePersonalAccountRequest updatePersonalAccountRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, updatePersonalAccountRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UpdatePersonalAccountRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="updatePersonalAccountRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, UpdatePersonalAccountRequest updatePersonalAccountRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (updatePersonalAccountRequest.CreditLimitOption.IsSet && updatePersonalAccountRequest.CreditLimit == null)
                throw new ArgumentNullException(nameof(updatePersonalAccountRequest.CreditLimit), "Property is required for class UpdatePersonalAccountRequest.");

            if (updatePersonalAccountRequest.CreditLimitOption.IsSet)
            {
                writer.WritePropertyName("creditLimit");
                JsonSerializer.Serialize(writer, updatePersonalAccountRequest.CreditLimit, jsonSerializerOptions);
            }
            if (updatePersonalAccountRequest.IdOption.IsSet)
                writer.WriteString("id", updatePersonalAccountRequest.IdOption!.Value);

            if (updatePersonalAccountRequest.NumberOption.IsSet)
                if (updatePersonalAccountRequest.NumberOption.Value != null)
                {
                    writer.WriteString("number", updatePersonalAccountRequest.Number);
                    //var __value = updatePersonalAccountRequest.NumberOption.Value;
                    //writer.WriteString("number", __value);
                }
                else
                    writer.WriteNull("number");

            if (updatePersonalAccountRequest.PurchaseTermsOfPaymentIdOption.IsSet)
                if (updatePersonalAccountRequest.PurchaseTermsOfPaymentIdOption.Value != null)
                {
                    writer.WriteString("purchaseTermsOfPaymentId", updatePersonalAccountRequest.PurchaseTermsOfPaymentIdOption!.Value);
                    //var __value = updatePersonalAccountRequest.PurchaseTermsOfPaymentIdOption.Value;
                    //writer.WriteString("purchaseTermsOfPaymentId", __value);
                }
                else
                    writer.WriteNull("purchaseTermsOfPaymentId");

            if (updatePersonalAccountRequest.SaleTermsOfPaymentIdOption.IsSet)
                if (updatePersonalAccountRequest.SaleTermsOfPaymentIdOption.Value != null)
                {
                    writer.WriteString("saleTermsOfPaymentId", updatePersonalAccountRequest.SaleTermsOfPaymentIdOption!.Value);
                    //var __value = updatePersonalAccountRequest.SaleTermsOfPaymentIdOption.Value;
                    //writer.WriteString("saleTermsOfPaymentId", __value);
                }
                else
                    writer.WriteNull("saleTermsOfPaymentId");

            if (updatePersonalAccountRequest.TaxGroupIdOption.IsSet)
                if (updatePersonalAccountRequest.TaxGroupIdOption.Value != null)
                {
                    writer.WriteString("taxGroupId", updatePersonalAccountRequest.TaxGroupIdOption!.Value);
                    //var __value = updatePersonalAccountRequest.TaxGroupIdOption.Value;
                    //writer.WriteString("taxGroupId", __value);
                }
                else
                    writer.WriteNull("taxGroupId");

            if (updatePersonalAccountRequest.TypeOption.IsSet)
                if (updatePersonalAccountRequest.TypeOption.Value != null)
                {
                    writer.WriteString("type", updatePersonalAccountRequest.Type);
                    //var __value = updatePersonalAccountRequest.TypeOption.Value;
                    //writer.WriteString("type", __value);
                }
                else
                    writer.WriteNull("type");

            if (updatePersonalAccountRequest.VatIdOption.IsSet)
                if (updatePersonalAccountRequest.VatIdOption.Value != null)
                {
                    writer.WriteString("vatId", updatePersonalAccountRequest.VatId);
                    //var __value = updatePersonalAccountRequest.VatIdOption.Value;
                    //writer.WriteString("vatId", __value);
                }
                else
                    writer.WriteNull("vatId");
        }
    }
}
