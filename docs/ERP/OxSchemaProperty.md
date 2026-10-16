# Simplic.OxS.SDK.ERP.OxSchemaProperty
A property descriptor. On a type's property list it describes a member; nested as an array's `of` or a dictionary's `value` it describes a shape and carries no member facts.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The camelCase wire name. Absent on a nested descriptor. | [optional] 
**StorageName** | **string** | The name the member is stored and queried under, present only where it is not &#x60;name&#x60; with its first letter upper-cased. A query uses the wire spelling; this is for consumers that address storage themselves, where the derivation is wrong exactly on acronym runs (&#x60;qrCode&#x60; is stored as &#x60;QRCode&#x60;). | [optional] 
**Kind** | **string** | One of &#x60;string&#x60;, &#x60;int&#x60;, &#x60;long&#x60;, &#x60;decimal&#x60;, &#x60;double&#x60;, &#x60;bool&#x60;, &#x60;guid&#x60;, &#x60;date&#x60;, &#x60;dateTime&#x60;, &#x60;timeSpan&#x60;, &#x60;enum&#x60;, &#x60;binary&#x60;, &#x60;unknown&#x60;, &#x60;object&#x60;, &#x60;array&#x60;, &#x60;dictionary&#x60;. | 
**Type** | **string** | A pointer into the pool, &#x60;#/types/&lt;id&gt;&#x60;. Present on object and enum kinds. | [optional] 
**Of** | [**OxSchemaProperty**](OxSchemaProperty.md) |  | [optional] 
**Value** | [**OxSchemaProperty**](OxSchemaProperty.md) |  | [optional] 
**Nullable** | **bool?** | Whether a client can read null out of the member. Absent on a nested descriptor. | [optional] 
**DisplayName** | **string** | The human label, present only where it is not the de-camelCased &#x60;name&#x60;, which again is the acronym case (&#x60;qrCode&#x60; labels as \&quot;QR Code\&quot;, not \&quot;Qr Code\&quot;). | [optional] 
**Description** | **string** | A description, when the model declares one. | [optional] 
**SnapshotOf** | **string** | The entity this member is an embedded copy of. Travels with the pointer, so it appears on a nested descriptor too. A copy is never joinable. | [optional] 
**References** | [**OxSchemaReference**](OxSchemaReference.md) |  | [optional] 
**Constraints** | [**OxSchemaConstraints**](OxSchemaConstraints.md) |  | [optional] 
**Deprecated** | [**OxSchemaDeprecation**](OxSchemaDeprecation.md) |  | [optional] 
**Values** | [**List&lt;OxSchemaValue&gt;**](OxSchemaValue.md) | A closed value list. An addon definition descriptor (&#x60;GET /schema/addons&#x60;) carries the organisation&#39;s list with labels. In the schema document only a member that holds one value per variant carries it (&#x60;byVariant&#x60;): the distinct values, ordinally sorted, without labels, so a reader can offer them as it offers an enum&#39;s. | [optional] 
**OnlyFor** | **List&lt;string&gt;** | The variants of the holding type that carry this member, when not all of them do (format 1.1). A reader treats the member as absent on every other stored value. | [optional] 
**ReferenceCases** | [**List&lt;OxSchemaReferenceCase&gt;**](OxSchemaReferenceCase.md) | Every case of a reference that is not simple, in declaration order (format 1.1): a condition, an item target, a key conversion or several targets. Never beside &#x60;references&#x60;. | [optional] 
**Stored** | **bool?** | &#x60;false&#x60; on a member the service returns and does not store (format 1.1): no row of a query carries it and the query engine refuses every use of it, a projection included, for the member and for everything below it; unless it carries &#x60;byVariant&#x60;. Absent on a stored member, and on a nested descriptor. | [optional] 
**StoredAs** | **string** | How the value is stored where its kind does not say it, one of &#x60;codePoint&#x60;, &#x60;document&#x60;, &#x60;arrayOfDocuments&#x60;, &#x60;arrayOfArrays&#x60; (format 1.1). It travels with the shape, so it appears on a nested descriptor too. Absent: the kind&#39;s own representation. | [optional] 
**Relation** | [**OxSchemaRelation**](OxSchemaRelation.md) |  | [optional] 
**ByVariant** | **Dictionary&lt;string, string&gt;** | The value the member holds for each variant of the type it is a member of, by variant name as &#x60;variants&#x60; and &#x60;baseVariant&#x60; spell it, ordinally sorted (format 1.1). Only on a member with &#x60;stored&#x60; &#x60;false&#x60; that is a constant of the class in every variant: the model&#39;s own type member (&#x60;type&#x60;: &#x60;\&quot;driver\&quot;&#x60;). The query engine answers such a member from the stored discriminator and compares it with &#x60;eq&#x60;, &#x60;neq&#x60;, &#x60;in&#x60; and &#x60;nin&#x60;. Absent on every other member, and on a nested descriptor. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

