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
    /// Shared model of resource.
    /// </summary>
    public partial class ResourceModel : IValidatableObject
    {

        /// <summary>
        /// Default constructor.
        /// </summary>
        [JsonConstructor]
        public ResourceModel()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceModel" /> class.
        /// </summary>
        /// <param name="createDateTime">Gets or sets the create date time.</param>
        /// <param name="createUserId">Gets or sets the create user id.</param>
        /// <param name="createUserName">Gets or sets the create user name.</param>
        /// <param name="displayName">Gets or sets the user-friendly display name  &lt;br&gt;  This will be the display-name of the resource. E.g. for drivers  this might be the first- and lastname. For vehicles this might be   the registration plate.  </param>
        /// <param name="id">Gets or sets the id.</param>
        /// <param name="isDeleted">Gets or sets whether the resource is deleted.</param>
        /// <param name="isLoadable">Gets or sets whether the resource is loadable</param>
        /// <param name="loadingSlots">Gets or sets the loading slots of the resource.</param>
        /// <param name="location">location</param>
        /// <param name="matchCode">Gets or sets the match code.  &lt;br&gt;  This will be a non unique human readable number for the resource.  </param>
        /// <param name="notes">Gets or sets resource notes</param>
        /// <param name="organizationId">Gets or sets the organization id for the contact.</param>
        /// <param name="planningOrderKey">Gets or sets an order key for the disposition</param>
        /// <param name="type">Gets the type of the resource.  &lt;br&gt;  E.g. \&quot;Driver\&quot; or \&quot;Tractor Unit\&quot;  </param>
        /// <param name="updateDateTime">Gets or sets the update date time.</param>
        /// <param name="updateUserId">Gets or sets the update user id.</param>
        /// <param name="updateUserName">Gets or sets the update user name.</param>
        /// <param name="usableUntil">Gets or sets a date, until</param>
        //[JsonConstructor]
        public ResourceModel(Option<DateTime> createDateTime = default, Option<Guid> createUserId = default, Option<string> createUserName = default, Option<string> displayName = default, Option<Guid> id = default, Option<bool> isDeleted = default, Option<bool> isLoadable = default, Option<List<LoadingSlotModel>> loadingSlots = default, Option<ResourceLocationModel> location = default, Option<string> matchCode = default, Option<string> notes = default, Option<Guid> organizationId = default, Option<string> planningOrderKey = default, Option<string> type = default, Option<DateTime> updateDateTime = default, Option<Guid> updateUserId = default, Option<string> updateUserName = default, Option<DateTime> usableUntil = default)
        {
            CreateDateTimeOption = createDateTime;
            CreateUserIdOption = createUserId;
            CreateUserNameOption = createUserName;
            DisplayNameOption = displayName;
            IdOption = id;
            IsDeletedOption = isDeleted;
            IsLoadableOption = isLoadable;
            LoadingSlotsOption = loadingSlots;
            LocationOption = location;
            MatchCodeOption = matchCode;
            NotesOption = notes;
            OrganizationIdOption = organizationId;
            PlanningOrderKeyOption = planningOrderKey;
            TypeOption = type;
            UpdateDateTimeOption = updateDateTime;
            UpdateUserIdOption = updateUserId;
            UpdateUserNameOption = updateUserName;
            UsableUntilOption = usableUntil;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of CreateDateTime
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<DateTime>))]
        public Option<DateTime> CreateDateTimeOption { get; private set; }

        /// <summary>
        /// Gets or sets the create date time.
        /// </summary>
        /// <value>Gets or sets the create date time.</value>
        [JsonPropertyName("createDateTime")]
        public DateTime? CreateDateTime { get { return this. CreateDateTimeOption; } set { this.CreateDateTimeOption = new Option<DateTime>(value); } }

        /// <summary>
        /// Used to track the state of CreateUserId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> CreateUserIdOption { get; private set; }

        /// <summary>
        /// Gets or sets the create user id.
        /// </summary>
        /// <value>Gets or sets the create user id.</value>
        [JsonPropertyName("createUserId")]
        public Guid? CreateUserId { get { return this. CreateUserIdOption; } set { this.CreateUserIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of CreateUserName
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> CreateUserNameOption { get; private set; }

        /// <summary>
        /// Gets or sets the create user name.
        /// </summary>
        /// <value>Gets or sets the create user name.</value>
        [JsonPropertyName("createUserName")]
        public string? CreateUserName { get { return this. CreateUserNameOption; } set { this.CreateUserNameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of DisplayName
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> DisplayNameOption { get; private set; }

        /// <summary>
        /// Gets or sets the user-friendly display name  &lt;br&gt;  This will be the display-name of the resource. E.g. for drivers  this might be the first- and lastname. For vehicles this might be   the registration plate.  
        /// </summary>
        /// <value>Gets or sets the user-friendly display name  &lt;br&gt;  This will be the display-name of the resource. E.g. for drivers  this might be the first- and lastname. For vehicles this might be   the registration plate.  </value>
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
        /// Gets or sets the id.
        /// </summary>
        /// <value>Gets or sets the id.</value>
        [JsonPropertyName("id")]
        public Guid? Id { get { return this. IdOption; } set { this.IdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of IsDeleted
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<bool>))]
        public Option<bool> IsDeletedOption { get; private set; }

        /// <summary>
        /// Gets or sets whether the resource is deleted.
        /// </summary>
        /// <value>Gets or sets whether the resource is deleted.</value>
        [JsonPropertyName("isDeleted")]
        public bool? IsDeleted { get { return this. IsDeletedOption; } set { this.IsDeletedOption = new Option<bool>(value); } }

        /// <summary>
        /// Used to track the state of IsLoadable
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<bool>))]
        public Option<bool> IsLoadableOption { get; private set; }

        /// <summary>
        /// Gets or sets whether the resource is loadable
        /// </summary>
        /// <value>Gets or sets whether the resource is loadable</value>
        [JsonPropertyName("isLoadable")]
        public bool? IsLoadable { get { return this. IsLoadableOption; } set { this.IsLoadableOption = new Option<bool>(value); } }

        /// <summary>
        /// Used to track the state of LoadingSlots
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<List<LoadingSlotModel>>))]
        public Option<List<LoadingSlotModel>> LoadingSlotsOption { get; private set; }

        /// <summary>
        /// Gets or sets the loading slots of the resource.
        /// </summary>
        /// <value>Gets or sets the loading slots of the resource.</value>
        [JsonPropertyName("loadingSlots")]
        public List<LoadingSlotModel>? LoadingSlots { get { return this. LoadingSlotsOption; } set { this.LoadingSlotsOption = new Option<List<LoadingSlotModel>>(value); } }

        /// <summary>
        /// Used to track the state of Location
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<ResourceLocationModel>))]
        public Option<ResourceLocationModel> LocationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [JsonPropertyName("location")]
        public ResourceLocationModel? Location { get { return this. LocationOption; } set { this.LocationOption = new Option<ResourceLocationModel>(value); } }

        /// <summary>
        /// Used to track the state of MatchCode
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> MatchCodeOption { get; private set; }

        /// <summary>
        /// Gets or sets the match code.  &lt;br&gt;  This will be a non unique human readable number for the resource.  
        /// </summary>
        /// <value>Gets or sets the match code.  &lt;br&gt;  This will be a non unique human readable number for the resource.  </value>
        [JsonPropertyName("matchCode")]
        public string? MatchCode { get { return this. MatchCodeOption; } set { this.MatchCodeOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Notes
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> NotesOption { get; private set; }

        /// <summary>
        /// Gets or sets resource notes
        /// </summary>
        /// <value>Gets or sets resource notes</value>
        [JsonPropertyName("notes")]
        public string? Notes { get { return this. NotesOption; } set { this.NotesOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of OrganizationId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> OrganizationIdOption { get; private set; }

        /// <summary>
        /// Gets or sets the organization id for the contact.
        /// </summary>
        /// <value>Gets or sets the organization id for the contact.</value>
        [JsonPropertyName("organizationId")]
        public Guid? OrganizationId { get { return this. OrganizationIdOption; } set { this.OrganizationIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of PlanningOrderKey
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> PlanningOrderKeyOption { get; private set; }

        /// <summary>
        /// Gets or sets an order key for the disposition
        /// </summary>
        /// <value>Gets or sets an order key for the disposition</value>
        [JsonPropertyName("planningOrderKey")]
        public string? PlanningOrderKey { get { return this. PlanningOrderKeyOption; } set { this.PlanningOrderKeyOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Type
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> TypeOption { get; private set; }

        /// <summary>
        /// Gets the type of the resource.  &lt;br&gt;  E.g. \&quot;Driver\&quot; or \&quot;Tractor Unit\&quot;  
        /// </summary>
        /// <value>Gets the type of the resource.  &lt;br&gt;  E.g. \&quot;Driver\&quot; or \&quot;Tractor Unit\&quot;  </value>
        [JsonPropertyName("type")]
        public string? Type { get { return this. TypeOption; } set { this.TypeOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of UpdateDateTime
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<DateTime>))]
        public Option<DateTime> UpdateDateTimeOption { get; private set; }

        /// <summary>
        /// Gets or sets the update date time.
        /// </summary>
        /// <value>Gets or sets the update date time.</value>
        [JsonPropertyName("updateDateTime")]
        public DateTime? UpdateDateTime { get { return this. UpdateDateTimeOption; } set { this.UpdateDateTimeOption = new Option<DateTime>(value); } }

        /// <summary>
        /// Used to track the state of UpdateUserId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<Guid>))]
        public Option<Guid> UpdateUserIdOption { get; private set; }

        /// <summary>
        /// Gets or sets the update user id.
        /// </summary>
        /// <value>Gets or sets the update user id.</value>
        [JsonPropertyName("updateUserId")]
        public Guid? UpdateUserId { get { return this. UpdateUserIdOption; } set { this.UpdateUserIdOption = new Option<Guid>(value); } }

        /// <summary>
        /// Used to track the state of UpdateUserName
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<string>))]
        public Option<string> UpdateUserNameOption { get; private set; }

        /// <summary>
        /// Gets or sets the update user name.
        /// </summary>
        /// <value>Gets or sets the update user name.</value>
        [JsonPropertyName("updateUserName")]
        public string? UpdateUserName { get { return this. UpdateUserNameOption; } set { this.UpdateUserNameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of UsableUntil
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        //[JsonConverter(typeof(OptionJsonConverter<DateTime>))]
        public Option<DateTime> UsableUntilOption { get; private set; }

        /// <summary>
        /// Gets or sets a date, until
        /// </summary>
        /// <value>Gets or sets a date, until</value>
        [JsonPropertyName("usableUntil")]
        public DateTime? UsableUntil { get { return this. UsableUntilOption; } set { this.UsableUntilOption = new Option<DateTime>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResourceModel {\n");
            sb.Append("  CreateDateTime: ").Append(CreateDateTime).Append("\n");
            sb.Append("  CreateUserId: ").Append(CreateUserId).Append("\n");
            sb.Append("  CreateUserName: ").Append(CreateUserName).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  IsLoadable: ").Append(IsLoadable).Append("\n");
            sb.Append("  LoadingSlots: ").Append(LoadingSlots).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  MatchCode: ").Append(MatchCode).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  PlanningOrderKey: ").Append(PlanningOrderKey).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UpdateDateTime: ").Append(UpdateDateTime).Append("\n");
            sb.Append("  UpdateUserId: ").Append(UpdateUserId).Append("\n");
            sb.Append("  UpdateUserName: ").Append(UpdateUserName).Append("\n");
            sb.Append("  UsableUntil: ").Append(UsableUntil).Append("\n");
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
    /// A Json converter for type <see cref="ResourceModel" />
    /// </summary>
    public class ResourceModelJsonConverter : JsonConverter<ResourceModel>
    {
        /// <summary>
        /// The format to use to serialize CreateDateTime
        /// </summary>
        public static string CreateDateTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize UpdateDateTime
        /// </summary>
        public static string UpdateDateTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize UsableUntil
        /// </summary>
        public static string UsableUntilFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="ResourceModel" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ResourceModel Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTime> createDateTime = default;
            Option<Guid> createUserId = default;
            Option<string> createUserName = default;
            Option<string> displayName = default;
            Option<Guid> id = default;
            Option<bool> isDeleted = default;
            Option<bool> isLoadable = default;
            Option<List<LoadingSlotModel>> loadingSlots = default;
            Option<ResourceLocationModel> location = default;
            Option<string> matchCode = default;
            Option<string> notes = default;
            Option<Guid> organizationId = default;
            Option<string> planningOrderKey = default;
            Option<string> type = default;
            Option<DateTime> updateDateTime = default;
            Option<Guid> updateUserId = default;
            Option<string> updateUserName = default;
            Option<DateTime> usableUntil = default;

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
                        case "createDateTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createDateTime = new Option<DateTime>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "createUserId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createUserId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "createUserName":
                            createUserName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "displayName":
                            displayName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "isDeleted":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isDeleted = new Option<bool>(utf8JsonReader.GetBoolean());
                            break;
                        case "isLoadable":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isLoadable = new Option<bool>(utf8JsonReader.GetBoolean());
                            break;
                        case "loadingSlots":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                loadingSlots = new Option<List<LoadingSlotModel>>(JsonSerializer.Deserialize<List<LoadingSlotModel>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "location":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                location = new Option<ResourceLocationModel>(JsonSerializer.Deserialize<ResourceLocationModel>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "matchCode":
                            matchCode = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "notes":
                            notes = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "organizationId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                organizationId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "planningOrderKey":
                            planningOrderKey = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "type":
                            type = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "updateDateTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updateDateTime = new Option<DateTime>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "updateUserId":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updateUserId = new Option<Guid>(utf8JsonReader.GetGuid());
                            break;
                        case "updateUserName":
                            updateUserName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "usableUntil":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                usableUntil = new Option<DateTime>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (createDateTime.IsSet && createDateTime.Value == null)
                throw new ArgumentNullException(nameof(createDateTime), "Property is not nullable for class ResourceModel.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class ResourceModel.");

            if (isDeleted.IsSet && isDeleted.Value == null)
                throw new ArgumentNullException(nameof(isDeleted), "Property is not nullable for class ResourceModel.");

            if (isLoadable.IsSet && isLoadable.Value == null)
                throw new ArgumentNullException(nameof(isLoadable), "Property is not nullable for class ResourceModel.");

            if (location.IsSet && location.Value == null)
                throw new ArgumentNullException(nameof(location), "Property is not nullable for class ResourceModel.");

            if (organizationId.IsSet && organizationId.Value == null)
                throw new ArgumentNullException(nameof(organizationId), "Property is not nullable for class ResourceModel.");

            if (updateDateTime.IsSet && updateDateTime.Value == null)
                throw new ArgumentNullException(nameof(updateDateTime), "Property is not nullable for class ResourceModel.");

            //2return new ResourceModel(createDateTime, createUserId, createUserName, displayName, id, isDeleted, isLoadable, loadingSlots, location, matchCode, notes, organizationId, planningOrderKey, type, updateDateTime, updateUserId, updateUserName, usableUntil);
            return new ResourceModel(createDateTime, createUserId, createUserName, displayName, id, isDeleted, isLoadable, loadingSlots, location, matchCode, notes, organizationId, planningOrderKey, type, updateDateTime, updateUserId, updateUserName, usableUntil);
        }

        /// <summary>
        /// Serializes a <see cref="ResourceModel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="resourceModel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ResourceModel resourceModel, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, resourceModel, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ResourceModel" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="resourceModel"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, ResourceModel resourceModel, JsonSerializerOptions jsonSerializerOptions)
        {
            if (resourceModel.LocationOption.IsSet && resourceModel.Location == null)
                throw new ArgumentNullException(nameof(resourceModel.Location), "Property is required for class ResourceModel.");

            if (resourceModel.CreateDateTimeOption.IsSet)
                writer.WriteString("createDateTime", resourceModel.CreateDateTimeOption!.Value.ToString(CreateDateTimeFormat));

            if (resourceModel.CreateUserIdOption.IsSet)
                if (resourceModel.CreateUserIdOption.Value != null)
                {
                    writer.WriteString("createUserId", resourceModel.CreateUserIdOption!.Value);
                    //var __value = resourceModel.CreateUserIdOption.Value;
                    //writer.WriteString("createUserId", __value);
                }
                else
                    writer.WriteNull("createUserId");

            if (resourceModel.CreateUserNameOption.IsSet)
                if (resourceModel.CreateUserNameOption.Value != null)
                {
                    writer.WriteString("createUserName", resourceModel.CreateUserName);
                    //var __value = resourceModel.CreateUserNameOption.Value;
                    //writer.WriteString("createUserName", __value);
                }
                else
                    writer.WriteNull("createUserName");

            if (resourceModel.DisplayNameOption.IsSet)
                if (resourceModel.DisplayNameOption.Value != null)
                {
                    writer.WriteString("displayName", resourceModel.DisplayName);
                    //var __value = resourceModel.DisplayNameOption.Value;
                    //writer.WriteString("displayName", __value);
                }
                else
                    writer.WriteNull("displayName");

            if (resourceModel.IdOption.IsSet)
                writer.WriteString("id", resourceModel.IdOption!.Value);

            if (resourceModel.IsDeletedOption.IsSet)
                writer.WriteBoolean("isDeleted", resourceModel.IsDeletedOption!.Value);

            if (resourceModel.IsLoadableOption.IsSet)
                writer.WriteBoolean("isLoadable", resourceModel.IsLoadableOption!.Value);

            if (resourceModel.LoadingSlotsOption.IsSet)
                if (resourceModel.LoadingSlotsOption.Value != null)
                {
                    writer.WritePropertyName("loadingSlots");
                    JsonSerializer.Serialize(writer, resourceModel.LoadingSlots, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("loadingSlots");
            if (resourceModel.LocationOption.IsSet)
            {
                writer.WritePropertyName("location");
                JsonSerializer.Serialize(writer, resourceModel.Location, jsonSerializerOptions);
            }
            if (resourceModel.MatchCodeOption.IsSet)
                if (resourceModel.MatchCodeOption.Value != null)
                {
                    writer.WriteString("matchCode", resourceModel.MatchCode);
                    //var __value = resourceModel.MatchCodeOption.Value;
                    //writer.WriteString("matchCode", __value);
                }
                else
                    writer.WriteNull("matchCode");

            if (resourceModel.NotesOption.IsSet)
                if (resourceModel.NotesOption.Value != null)
                {
                    writer.WriteString("notes", resourceModel.Notes);
                    //var __value = resourceModel.NotesOption.Value;
                    //writer.WriteString("notes", __value);
                }
                else
                    writer.WriteNull("notes");

            if (resourceModel.OrganizationIdOption.IsSet)
                writer.WriteString("organizationId", resourceModel.OrganizationIdOption!.Value);

            if (resourceModel.PlanningOrderKeyOption.IsSet)
                if (resourceModel.PlanningOrderKeyOption.Value != null)
                {
                    writer.WriteString("planningOrderKey", resourceModel.PlanningOrderKey);
                    //var __value = resourceModel.PlanningOrderKeyOption.Value;
                    //writer.WriteString("planningOrderKey", __value);
                }
                else
                    writer.WriteNull("planningOrderKey");

            if (resourceModel.TypeOption.IsSet)
                if (resourceModel.TypeOption.Value != null)
                {
                    writer.WriteString("type", resourceModel.Type);
                    //var __value = resourceModel.TypeOption.Value;
                    //writer.WriteString("type", __value);
                }
                else
                    writer.WriteNull("type");

            if (resourceModel.UpdateDateTimeOption.IsSet)
                writer.WriteString("updateDateTime", resourceModel.UpdateDateTimeOption!.Value.ToString(UpdateDateTimeFormat));

            if (resourceModel.UpdateUserIdOption.IsSet)
                if (resourceModel.UpdateUserIdOption.Value != null)
                {
                    writer.WriteString("updateUserId", resourceModel.UpdateUserIdOption!.Value);
                    //var __value = resourceModel.UpdateUserIdOption.Value;
                    //writer.WriteString("updateUserId", __value);
                }
                else
                    writer.WriteNull("updateUserId");

            if (resourceModel.UpdateUserNameOption.IsSet)
                if (resourceModel.UpdateUserNameOption.Value != null)
                {
                    writer.WriteString("updateUserName", resourceModel.UpdateUserName);
                    //var __value = resourceModel.UpdateUserNameOption.Value;
                    //writer.WriteString("updateUserName", __value);
                }
                else
                    writer.WriteNull("updateUserName");

            if (resourceModel.UsableUntilOption.IsSet)
                if (resourceModel.UsableUntilOption.Value != null)
                {
                    writer.WriteString("usableUntil", resourceModel.UsableUntilOption!.Value.ToString(UsableUntilFormat));
                    //var __value = resourceModel.UsableUntilOption.Value;
                    //writer.WriteString("usableUntil", __value);
                }
                else
                    writer.WriteNull("usableUntil");
        }
    }
}
