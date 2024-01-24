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
    /// TermsOfPaymentRequest
    /// </summary>
    public partial class TermsOfPaymentRequest : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public TermsOfPaymentRequest()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TermsOfPaymentRequest" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="number">number</param>
        /// <param name="paymentDeadlineDays">paymentDeadlineDays</param>
        /// <param name="cashDiscount">cashDiscount</param>
        /// <param name="cashDiscountDays">cashDiscountDays</param>
        /// <param name="formattedText">formattedText</param>
        /// <param name="states">states</param>
        //[JsonConstructor]
        public TermsOfPaymentRequest(string name, int number, int paymentDeadlineDays, Option<double> cashDiscount = default, Option<int> cashDiscountDays = default, Option<string> formattedText = default, Option<List<string>> states = default)
        {
            Name = name;
            Number = number;
            PaymentDeadlineDays = paymentDeadlineDays;
            CashDiscountOption = cashDiscount;
            CashDiscountDaysOption = cashDiscountDays;
            FormattedTextOption = formattedText;
            StatesOption = states;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [JsonPropertyName("number")]
        public int Number { get; set; }

        /// <summary>
        /// Gets or Sets PaymentDeadlineDays
        /// </summary>
        [JsonPropertyName("paymentDeadlineDays")]
        public int PaymentDeadlineDays { get; set; }

        /// <summary>
        /// Used to track the state of CashDiscount
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<double>))]
        public Option<double> CashDiscountOption { get; private set; }

        /// <summary>
        /// Gets or Sets CashDiscount
        /// </summary>
        [JsonPropertyName("cashDiscount")]
        public double? CashDiscount { get { return this. CashDiscountOption; } set { this.CashDiscountOption = new Option<double>(value); } }

        /// <summary>
        /// Used to track the state of CashDiscountDays
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<int>))]
        public Option<int> CashDiscountDaysOption { get; private set; }

        /// <summary>
        /// Gets or Sets CashDiscountDays
        /// </summary>
        [JsonPropertyName("cashDiscountDays")]
        public int? CashDiscountDays { get { return this. CashDiscountDaysOption; } set { this.CashDiscountDaysOption = new Option<int>(value); } }

        /// <summary>
        /// Used to track the state of FormattedText
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> FormattedTextOption { get; private set; }

        /// <summary>
        /// Gets or Sets FormattedText
        /// </summary>
        [JsonPropertyName("formattedText")]
        public string? FormattedText { get { return this. FormattedTextOption; } set { this.FormattedTextOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of States
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<List<string>>))]
        public Option<List<string>> StatesOption { get; private set; }

        /// <summary>
        /// Gets or Sets States
        /// </summary>
        [JsonPropertyName("states")]
        public List<string>? States { get { return this. StatesOption; } set { this.StatesOption = new Option<List<string>>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TermsOfPaymentRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  PaymentDeadlineDays: ").Append(PaymentDeadlineDays).Append("\n");
            sb.Append("  CashDiscount: ").Append(CashDiscount).Append("\n");
            sb.Append("  CashDiscountDays: ").Append(CashDiscountDays).Append("\n");
            sb.Append("  FormattedText: ").Append(FormattedText).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 2.", new [] { "Name" });
            }

            // PaymentDeadlineDays (int) minimum
            if (this.PaymentDeadlineDays < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentDeadlineDays, must be a value greater than or equal to 0.", new [] { "PaymentDeadlineDays" });
            }

            // CashDiscountDays (int) minimum
            if (this.CashDiscountDays < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CashDiscountDays, must be a value greater than or equal to 0.", new [] { "CashDiscountDays" });
            }

            // FormattedText (string) maxLength
            if (this.FormattedText != null && this.FormattedText.Length > 10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FormattedText, length must be less than 10000.", new [] { "FormattedText" });
            }

            // FormattedText (string) minLength
            if (this.FormattedText != null && this.FormattedText.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FormattedText, length must be greater than 1.", new [] { "FormattedText" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="TermsOfPaymentRequest" />
    /// </summary>
    public class TermsOfPaymentRequestJsonConverter : JsonConverter<TermsOfPaymentRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="TermsOfPaymentRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TermsOfPaymentRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> name = default;
            Option<int> number = default;
            Option<int> paymentDeadlineDays = default;
            Option<double> cashDiscount = default;
            Option<int> cashDiscountDays = default;
            Option<string> formattedText = default;
            Option<List<string>> states = default;

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
                        case "name":
                            name = new Option<string>(utf8JsonReader.GetString()!);
                            break;
                        case "number":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                number = new Option<int>(utf8JsonReader.GetInt32());
                            break;
                        case "paymentDeadlineDays":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                paymentDeadlineDays = new Option<int>(utf8JsonReader.GetInt32());
                            break;
                        case "cashDiscount":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                cashDiscount = new Option<double>(utf8JsonReader.GetDouble());
                            break;
                        case "cashDiscountDays":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                cashDiscountDays = new Option<int>(utf8JsonReader.GetInt32());
                            break;
                        case "formattedText":
                            formattedText = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "states":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                states = new Option<List<string>>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!name.IsSet)
                throw new ArgumentException("Property is required for class TermsOfPaymentRequest.", nameof(name));

            if (!number.IsSet)
                throw new ArgumentException("Property is required for class TermsOfPaymentRequest.", nameof(number));

            if (!paymentDeadlineDays.IsSet)
                throw new ArgumentException("Property is required for class TermsOfPaymentRequest.", nameof(paymentDeadlineDays));

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class TermsOfPaymentRequest.");

            if (number.IsSet && number.Value == null)
                throw new ArgumentNullException(nameof(number), "Property is not nullable for class TermsOfPaymentRequest.");

            if (paymentDeadlineDays.IsSet && paymentDeadlineDays.Value == null)
                throw new ArgumentNullException(nameof(paymentDeadlineDays), "Property is not nullable for class TermsOfPaymentRequest.");

            if (cashDiscount.IsSet && cashDiscount.Value == null)
                throw new ArgumentNullException(nameof(cashDiscount), "Property is not nullable for class TermsOfPaymentRequest.");

            if (cashDiscountDays.IsSet && cashDiscountDays.Value == null)
                throw new ArgumentNullException(nameof(cashDiscountDays), "Property is not nullable for class TermsOfPaymentRequest.");

            //2return new TermsOfPaymentRequest(name.Value!, number.Value!.Value!, paymentDeadlineDays.Value!.Value!, cashDiscount, cashDiscountDays, formattedText, states);
            return new TermsOfPaymentRequest(name.Value!, number.Value!, paymentDeadlineDays.Value!, cashDiscount, cashDiscountDays, formattedText, states);
        }

        /// <summary>
        /// Serializes a <see cref="TermsOfPaymentRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="termsOfPaymentRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TermsOfPaymentRequest termsOfPaymentRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, termsOfPaymentRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TermsOfPaymentRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="termsOfPaymentRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, TermsOfPaymentRequest termsOfPaymentRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (termsOfPaymentRequest.Name == null)
                throw new ArgumentNullException(nameof(termsOfPaymentRequest.Name), "Property is required for class TermsOfPaymentRequest.");

            writer.WriteString("name", termsOfPaymentRequest.Name);

            writer.WriteNumber("number", termsOfPaymentRequest.Number);

            writer.WriteNumber("paymentDeadlineDays", termsOfPaymentRequest.PaymentDeadlineDays);

            if (termsOfPaymentRequest.CashDiscountOption.IsSet)
                writer.WriteNumber("cashDiscount", termsOfPaymentRequest.CashDiscountOption!.Value);

            if (termsOfPaymentRequest.CashDiscountDaysOption.IsSet)
                writer.WriteNumber("cashDiscountDays", termsOfPaymentRequest.CashDiscountDaysOption!.Value);

            if (termsOfPaymentRequest.FormattedTextOption.IsSet)
                if (termsOfPaymentRequest.FormattedTextOption.Value != null)
                {
                    writer.WriteString("formattedText", termsOfPaymentRequest.FormattedText);
                    //var __value = termsOfPaymentRequest.FormattedTextOption.Value;
                    //writer.WriteString("formattedText", __value);
                }
                else
                    writer.WriteNull("formattedText");

            if (termsOfPaymentRequest.StatesOption.IsSet)
                if (termsOfPaymentRequest.StatesOption.Value != null)
                {
                    writer.WritePropertyName("states");
                    JsonSerializer.Serialize(writer, termsOfPaymentRequest.States, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("states");
        }
    }
}
