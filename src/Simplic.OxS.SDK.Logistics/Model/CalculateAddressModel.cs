/*
 * Simplic.OxS.Logistics
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Simplic.OxS.SDK.Client.OpenAPIDateConverter;

namespace Simplic.OxS.SDK.Logistics.Model
{
    /// <summary>
    /// Represents an address to calculate tours.
    /// </summary>
    [DataContract(Name = "CalculateAddressModel")]
    public partial class CalculateAddressModel : IEquatable<CalculateAddressModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateAddressModel" /> class.
        /// </summary>
        /// <param name="contactId">Gets or sets the contact id..</param>
        /// <param name="companyName">Gets or sets the company name.</param>
        /// <param name="firstName">Gets or sets the first name.</param>
        /// <param name="lastName">Gets or sets the last name.</param>
        /// <param name="street">Gets or sets the street.</param>
        /// <param name="houseNumber">Gets or sets the house number..</param>
        /// <param name="additional01">Gets or sets the first additional information..</param>
        /// <param name="additional02">Gets or sets the second additional information..</param>
        /// <param name="zipcode">Gets or sets the zipcode..</param>
        /// <param name="district">Gets or sets the district.</param>
        /// <param name="federalState">Gets or sets the land. E.g. lower saxony or bavaria..</param>
        /// <param name="country">Gets or sets the country..</param>
        /// <param name="countryIso">Gets or sets the country..</param>
        /// <param name="city">Gets or sets the city..</param>
        /// <param name="latitude">Gets or sets the latitude.</param>
        /// <param name="longitude">Gets or sets the longitude.</param>
        public CalculateAddressModel(Guid contactId = default(Guid), string companyName = default(string), string firstName = default(string), string lastName = default(string), string street = default(string), string houseNumber = default(string), string additional01 = default(string), string additional02 = default(string), string zipcode = default(string), string district = default(string), string federalState = default(string), string country = default(string), string countryIso = default(string), string city = default(string), double? latitude = default(double?), double? longitude = default(double?))
        {
            this.ContactId = contactId;
            this.CompanyName = companyName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Street = street;
            this.HouseNumber = houseNumber;
            this.Additional01 = additional01;
            this.Additional02 = additional02;
            this.Zipcode = zipcode;
            this.District = district;
            this.FederalState = federalState;
            this.Country = country;
            this.CountryIso = countryIso;
            this.City = city;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        /// <summary>
        /// Gets or sets the contact id.
        /// </summary>
        /// <value>Gets or sets the contact id.</value>
        [DataMember(Name = "contactId", EmitDefaultValue = false)]
        public Guid ContactId { get; set; }

        /// <summary>
        /// Gets or sets the company name
        /// </summary>
        /// <value>Gets or sets the company name</value>
        [DataMember(Name = "companyName", EmitDefaultValue = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        /// <value>Gets or sets the first name</value>
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name
        /// </summary>
        /// <value>Gets or sets the last name</value>
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the street
        /// </summary>
        /// <value>Gets or sets the street</value>
        [DataMember(Name = "street", EmitDefaultValue = true)]
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the house number.
        /// </summary>
        /// <value>Gets or sets the house number.</value>
        [DataMember(Name = "houseNumber", EmitDefaultValue = true)]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Gets or sets the first additional information.
        /// </summary>
        /// <value>Gets or sets the first additional information.</value>
        [DataMember(Name = "additional01", EmitDefaultValue = true)]
        public string Additional01 { get; set; }

        /// <summary>
        /// Gets or sets the second additional information.
        /// </summary>
        /// <value>Gets or sets the second additional information.</value>
        [DataMember(Name = "additional02", EmitDefaultValue = true)]
        public string Additional02 { get; set; }

        /// <summary>
        /// Gets or sets the zipcode.
        /// </summary>
        /// <value>Gets or sets the zipcode.</value>
        [DataMember(Name = "zipcode", EmitDefaultValue = true)]
        public string Zipcode { get; set; }

        /// <summary>
        /// Gets or sets the district
        /// </summary>
        /// <value>Gets or sets the district</value>
        [DataMember(Name = "district", EmitDefaultValue = true)]
        public string District { get; set; }

        /// <summary>
        /// Gets or sets the land. E.g. lower saxony or bavaria.
        /// </summary>
        /// <value>Gets or sets the land. E.g. lower saxony or bavaria.</value>
        [DataMember(Name = "federalState", EmitDefaultValue = true)]
        public string FederalState { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>Gets or sets the country.</value>
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>Gets or sets the country.</value>
        [DataMember(Name = "countryIso", EmitDefaultValue = true)]
        public string CountryIso { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>Gets or sets the city.</value>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the latitude
        /// </summary>
        /// <value>Gets or sets the latitude</value>
        [DataMember(Name = "latitude", EmitDefaultValue = true)]
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude
        /// </summary>
        /// <value>Gets or sets the longitude</value>
        [DataMember(Name = "longitude", EmitDefaultValue = true)]
        public double? Longitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CalculateAddressModel {\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  HouseNumber: ").Append(HouseNumber).Append("\n");
            sb.Append("  Additional01: ").Append(Additional01).Append("\n");
            sb.Append("  Additional02: ").Append(Additional02).Append("\n");
            sb.Append("  Zipcode: ").Append(Zipcode).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  FederalState: ").Append(FederalState).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryIso: ").Append(CountryIso).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CalculateAddressModel);
        }

        /// <summary>
        /// Returns true if CalculateAddressModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CalculateAddressModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalculateAddressModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.HouseNumber == input.HouseNumber ||
                    (this.HouseNumber != null &&
                    this.HouseNumber.Equals(input.HouseNumber))
                ) && 
                (
                    this.Additional01 == input.Additional01 ||
                    (this.Additional01 != null &&
                    this.Additional01.Equals(input.Additional01))
                ) && 
                (
                    this.Additional02 == input.Additional02 ||
                    (this.Additional02 != null &&
                    this.Additional02.Equals(input.Additional02))
                ) && 
                (
                    this.Zipcode == input.Zipcode ||
                    (this.Zipcode != null &&
                    this.Zipcode.Equals(input.Zipcode))
                ) && 
                (
                    this.District == input.District ||
                    (this.District != null &&
                    this.District.Equals(input.District))
                ) && 
                (
                    this.FederalState == input.FederalState ||
                    (this.FederalState != null &&
                    this.FederalState.Equals(input.FederalState))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CountryIso == input.CountryIso ||
                    (this.CountryIso != null &&
                    this.CountryIso.Equals(input.CountryIso))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ContactId != null)
                {
                    hashCode = (hashCode * 59) + this.ContactId.GetHashCode();
                }
                if (this.CompanyName != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyName.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.Street != null)
                {
                    hashCode = (hashCode * 59) + this.Street.GetHashCode();
                }
                if (this.HouseNumber != null)
                {
                    hashCode = (hashCode * 59) + this.HouseNumber.GetHashCode();
                }
                if (this.Additional01 != null)
                {
                    hashCode = (hashCode * 59) + this.Additional01.GetHashCode();
                }
                if (this.Additional02 != null)
                {
                    hashCode = (hashCode * 59) + this.Additional02.GetHashCode();
                }
                if (this.Zipcode != null)
                {
                    hashCode = (hashCode * 59) + this.Zipcode.GetHashCode();
                }
                if (this.District != null)
                {
                    hashCode = (hashCode * 59) + this.District.GetHashCode();
                }
                if (this.FederalState != null)
                {
                    hashCode = (hashCode * 59) + this.FederalState.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.CountryIso != null)
                {
                    hashCode = (hashCode * 59) + this.CountryIso.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.Latitude != null)
                {
                    hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                }
                if (this.Longitude != null)
                {
                    hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                }
                return hashCode;
            }
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

}
