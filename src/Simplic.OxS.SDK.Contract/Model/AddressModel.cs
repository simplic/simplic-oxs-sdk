// <auto-generated>
/*
 * Simplic.OxS.Contract
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

namespace Simplic.OxS.SDK.Contract
{
    /// <summary>
    /// AddressModel
    /// </summary>
    public partial class AddressModel : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public AddressModel()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressModel" /> class.
        /// </summary>
        /// <param name="additional01">additional01</param>
        /// <param name="additional02">additional02</param>
        /// <param name="city">city</param>
        /// <param name="companyName">companyName</param>
        /// <param name="contactId">contactId</param>
        /// <param name="country">country</param>
        /// <param name="countryIso">countryIso</param>
        /// <param name="district">district</param>
        /// <param name="federalState">federalState</param>
        /// <param name="firstName">firstName</param>
        /// <param name="houseNumber">houseNumber</param>
        /// <param name="lastName">lastName</param>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        /// <param name="street">street</param>
        /// <param name="zipcode">zipcode</param>
        //[JsonConstructor]
        public AddressModel(Option<string> additional01 = default, Option<string> additional02 = default, Option<string> city = default, Option<string> companyName = default, Option<Guid> contactId = default, Option<string> country = default, Option<string> countryIso = default, Option<string> district = default, Option<string> federalState = default, Option<string> firstName = default, Option<string> houseNumber = default, Option<string> lastName = default, Option<double> latitude = default, Option<double> longitude = default, Option<string> street = default, Option<string> zipcode = default)
        {
            Additional01Option = additional01;
            Additional02Option = additional02;
            CityOption = city;
            CompanyNameOption = companyName;
            ContactIdOption = contactId;
            CountryOption = country;
            CountryIsoOption = countryIso;
            DistrictOption = district;
            FederalStateOption = federalState;
            FirstNameOption = firstName;
            HouseNumberOption = houseNumber;
            LastNameOption = lastName;
            LatitudeOption = latitude;
            LongitudeOption = longitude;
            StreetOption = street;
            ZipcodeOption = zipcode;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Additional01
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> Additional01Option { get; private set; }

        /// <summary>
        /// Gets or Sets Additional01
        /// </summary>
        [JsonPropertyName("additional01")]
        public string? Additional01 { get { return this. Additional01Option; } set { this.Additional01Option = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Additional02
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> Additional02Option { get; private set; }

        /// <summary>
        /// Gets or Sets Additional02
        /// </summary>
        [JsonPropertyName("additional02")]
        public string? Additional02 { get { return this. Additional02Option; } set { this.Additional02Option = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of City
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> CityOption { get; private set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [JsonPropertyName("city")]
        public string? City { get { return this. CityOption; } set { this.CityOption = new Option<string>(value); } }

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
        /// Used to track the state of ContactId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> ContactIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets ContactId
        /// </summary>
        [JsonPropertyName("contactId")]
        public Guid? ContactId { get { return this. ContactIdOption; } set { this.ContactIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of Country
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> CountryOption { get; private set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [JsonPropertyName("country")]
        public string? Country { get { return this. CountryOption; } set { this.CountryOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of CountryIso
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> CountryIsoOption { get; private set; }

        /// <summary>
        /// Gets or Sets CountryIso
        /// </summary>
        [JsonPropertyName("countryIso")]
        public string? CountryIso { get { return this. CountryIsoOption; } set { this.CountryIsoOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of District
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> DistrictOption { get; private set; }

        /// <summary>
        /// Gets or Sets District
        /// </summary>
        [JsonPropertyName("district")]
        public string? District { get { return this. DistrictOption; } set { this.DistrictOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of FederalState
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> FederalStateOption { get; private set; }

        /// <summary>
        /// Gets or Sets FederalState
        /// </summary>
        [JsonPropertyName("federalState")]
        public string? FederalState { get { return this. FederalStateOption; } set { this.FederalStateOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of FirstName
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> FirstNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [JsonPropertyName("firstName")]
        public string? FirstName { get { return this. FirstNameOption; } set { this.FirstNameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of HouseNumber
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> HouseNumberOption { get; private set; }

        /// <summary>
        /// Gets or Sets HouseNumber
        /// </summary>
        [JsonPropertyName("houseNumber")]
        public string? HouseNumber { get { return this. HouseNumberOption; } set { this.HouseNumberOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of LastName
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> LastNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [JsonPropertyName("lastName")]
        public string? LastName { get { return this. LastNameOption; } set { this.LastNameOption = new Option<string>(value); } }

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
        /// Used to track the state of Street
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> StreetOption { get; private set; }

        /// <summary>
        /// Gets or Sets Street
        /// </summary>
        [JsonPropertyName("street")]
        public string? Street { get { return this. StreetOption; } set { this.StreetOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Zipcode
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> ZipcodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Zipcode
        /// </summary>
        [JsonPropertyName("zipcode")]
        public string? Zipcode { get { return this. ZipcodeOption; } set { this.ZipcodeOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AddressModel {\n");
            sb.Append("  Additional01: ").Append(Additional01).Append("\n");
            sb.Append("  Additional02: ").Append(Additional02).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryIso: ").Append(CountryIso).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  FederalState: ").Append(FederalState).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  HouseNumber: ").Append(HouseNumber).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Zipcode: ").Append(Zipcode).Append("\n");
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
    /// A Json converter for type <see cref="AddressModel" />
    /// </summary>
    public class AddressModelJsonConverter : JsonConverter<AddressModel>
    {
        /// <summary>
        /// Deserializes json to <see cref="AddressModel" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AddressModel Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> additional01 = default;
            Option<string> additional02 = default;
            Option<string> city = default;
            Option<string> companyName = default;
            Option<Guid> contactId = default;
            Option<string> country = default;
            Option<string> countryIso = default;
            Option<string> district = default;
            Option<string> federalState = default;
            Option<string> firstName = default;
            Option<string> houseNumber = default;
            Option<string> lastName = default;
            Option<double> latitude = default;
            Option<double> longitude = default;
            Option<string> street = default;
            Option<string> zipcode = default;

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
                        case "additional01":
                            additional01 = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "additional02":
                            additional02 = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "city":
                            city = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "companyName":
                            companyName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "contactId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                contactId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "country":
                            country = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "countryIso":
                            countryIso = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "district":
                            district = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "federalState":
                            federalState = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "firstName":
                            firstName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "houseNumber":
                            houseNumber = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "lastName":
                            lastName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "latitude":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                latitude = new Option<double>(utf8JsonReader.GetDouble());
                            break;
                        case "longitude":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                longitude = new Option<double>(utf8JsonReader.GetDouble());
                            break;
                        case "street":
                            street = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "zipcode":
                            zipcode = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (contactId.IsSet && contactId.Value == null)
                throw new ArgumentNullException(nameof(contactId), "Property is not nullable for class AddressModel.");

            if (latitude.IsSet && latitude.Value == null)
                throw new ArgumentNullException(nameof(latitude), "Property is not nullable for class AddressModel.");

            if (longitude.IsSet && longitude.Value == null)
                throw new ArgumentNullException(nameof(longitude), "Property is not nullable for class AddressModel.");

            //2return new AddressModel(additional01, additional02, city, companyName, contactId, country, countryIso, district, federalState, firstName, houseNumber, lastName, latitude, longitude, street, zipcode);
            return new AddressModel(additional01, additional02, city, companyName, contactId, country, countryIso, district, federalState, firstName, houseNumber, lastName, latitude, longitude, street, zipcode);
        }

        /// <summary>
        /// Serializes a <see cref="AddressModel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="addressModel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AddressModel addressModel, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, addressModel, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AddressModel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="addressModel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, AddressModel addressModel, JsonSerializerOptions jsonSerializerOptions)
        {
            if (addressModel.Additional01Option.IsSet)
                if (addressModel.Additional01Option.Value != null)
                {
                    writer.WriteString("additional01", addressModel.Additional01);
                    //var __value = addressModel.Additional01Option.Value;
                    //writer.WriteString("additional01", __value);
                }
                else
                    writer.WriteNull("additional01");

            if (addressModel.Additional02Option.IsSet)
                if (addressModel.Additional02Option.Value != null)
                {
                    writer.WriteString("additional02", addressModel.Additional02);
                    //var __value = addressModel.Additional02Option.Value;
                    //writer.WriteString("additional02", __value);
                }
                else
                    writer.WriteNull("additional02");

            if (addressModel.CityOption.IsSet)
                if (addressModel.CityOption.Value != null)
                {
                    writer.WriteString("city", addressModel.City);
                    //var __value = addressModel.CityOption.Value;
                    //writer.WriteString("city", __value);
                }
                else
                    writer.WriteNull("city");

            if (addressModel.CompanyNameOption.IsSet)
                if (addressModel.CompanyNameOption.Value != null)
                {
                    writer.WriteString("companyName", addressModel.CompanyName);
                    //var __value = addressModel.CompanyNameOption.Value;
                    //writer.WriteString("companyName", __value);
                }
                else
                    writer.WriteNull("companyName");

            if (addressModel.ContactIdOption.IsSet)
                writer.WriteString("contactId", addressModel.ContactIdOption!.Value);

            if (addressModel.CountryOption.IsSet)
                if (addressModel.CountryOption.Value != null)
                {
                    writer.WriteString("country", addressModel.Country);
                    //var __value = addressModel.CountryOption.Value;
                    //writer.WriteString("country", __value);
                }
                else
                    writer.WriteNull("country");

            if (addressModel.CountryIsoOption.IsSet)
                if (addressModel.CountryIsoOption.Value != null)
                {
                    writer.WriteString("countryIso", addressModel.CountryIso);
                    //var __value = addressModel.CountryIsoOption.Value;
                    //writer.WriteString("countryIso", __value);
                }
                else
                    writer.WriteNull("countryIso");

            if (addressModel.DistrictOption.IsSet)
                if (addressModel.DistrictOption.Value != null)
                {
                    writer.WriteString("district", addressModel.District);
                    //var __value = addressModel.DistrictOption.Value;
                    //writer.WriteString("district", __value);
                }
                else
                    writer.WriteNull("district");

            if (addressModel.FederalStateOption.IsSet)
                if (addressModel.FederalStateOption.Value != null)
                {
                    writer.WriteString("federalState", addressModel.FederalState);
                    //var __value = addressModel.FederalStateOption.Value;
                    //writer.WriteString("federalState", __value);
                }
                else
                    writer.WriteNull("federalState");

            if (addressModel.FirstNameOption.IsSet)
                if (addressModel.FirstNameOption.Value != null)
                {
                    writer.WriteString("firstName", addressModel.FirstName);
                    //var __value = addressModel.FirstNameOption.Value;
                    //writer.WriteString("firstName", __value);
                }
                else
                    writer.WriteNull("firstName");

            if (addressModel.HouseNumberOption.IsSet)
                if (addressModel.HouseNumberOption.Value != null)
                {
                    writer.WriteString("houseNumber", addressModel.HouseNumber);
                    //var __value = addressModel.HouseNumberOption.Value;
                    //writer.WriteString("houseNumber", __value);
                }
                else
                    writer.WriteNull("houseNumber");

            if (addressModel.LastNameOption.IsSet)
                if (addressModel.LastNameOption.Value != null)
                {
                    writer.WriteString("lastName", addressModel.LastName);
                    //var __value = addressModel.LastNameOption.Value;
                    //writer.WriteString("lastName", __value);
                }
                else
                    writer.WriteNull("lastName");

            if (addressModel.LatitudeOption.IsSet)
                writer.WriteNumber("latitude", addressModel.LatitudeOption!.Value);

            if (addressModel.LongitudeOption.IsSet)
                writer.WriteNumber("longitude", addressModel.LongitudeOption!.Value);

            if (addressModel.StreetOption.IsSet)
                if (addressModel.StreetOption.Value != null)
                {
                    writer.WriteString("street", addressModel.Street);
                    //var __value = addressModel.StreetOption.Value;
                    //writer.WriteString("street", __value);
                }
                else
                    writer.WriteNull("street");

            if (addressModel.ZipcodeOption.IsSet)
                if (addressModel.ZipcodeOption.Value != null)
                {
                    writer.WriteString("zipcode", addressModel.Zipcode);
                    //var __value = addressModel.ZipcodeOption.Value;
                    //writer.WriteString("zipcode", __value);
                }
                else
                    writer.WriteNull("zipcode");
        }
    }
}
