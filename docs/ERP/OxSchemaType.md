# Simplic.OxS.SDK.ERP.OxSchemaType
One entry of the type pool. An entity is a structural type that additionally carries entity metadata.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kind** | **string** | &#x60;enum&#x60; on an enum entry; absent on an object entry. | [optional] 
**DisplayName** | **string** | The human label of an entity. Absent on a structural type. | [optional] 
**Description** | **string** | A description, when the model declares one. | [optional] 
**Flags** | **bool?** | Whether an enum entry is a flags enum. Absent on a non-enum entry. | [optional] 
**Values** | [**List&lt;OxSchemaEnumValue&gt;**](OxSchemaEnumValue.md) | The value list of an enum entry, in declaration order. Absent on a non-enum entry. | [optional] 
**Entity** | **bool** | True on an entity entry; absent on a structural type. | [optional] 
**Aliases** | **List&lt;string&gt;** | The ids this entity is also known by: the ids it retired, then the legacy &#x60;$ClassName&#x60; model ids its controller publishes. Entity-only. | [optional] 
**Key** | **List&lt;string&gt;** | The property paths that identify an instance. Present on entities and on keyed item types. | [optional] 
**Display** | **string** | The property that names an instance. Entity-only, absent when no candidate exists. | [optional] 
**Extendable** | **bool?** | Whether the entity accepts an organisation&#39;s declared addon fields. Entity-only. | [optional] 
**Queryable** | **bool** | True on an entity entry: every entity in the pool is accepted as a query&#39;s entity type. | [optional] 
**NotFilterable** | **List&lt;string&gt;** | Paths the entity refuses to filter on. Entity-only, always present, possibly empty. | [optional] 
**NotSortable** | **List&lt;string&gt;** | Paths the entity refuses to sort on. Entity-only, always present, possibly empty. | [optional] 
**Operations** | [**Dictionary&lt;string, OxSchemaOperation&gt;**](OxSchemaOperation.md) | The REST operations of an entity by slot (&#x60;get&#x60;, &#x60;create&#x60;, &#x60;update&#x60;, &#x60;replace&#x60;, &#x60;delete&#x60;), sorted ordinally. Absent when no linked controller routes any slot. | [optional] 
**Items** | [**List&lt;OxSchemaEntityItem&gt;**](OxSchemaEntityItem.md) | Every path under an entity whose terminal is an array of a keyed item type. Entity-only, always present, possibly empty. | [optional] 
**Properties** | [**List&lt;OxSchemaProperty&gt;**](OxSchemaProperty.md) | The property list. Absent on an enum entry; an object entry always carries it, empty included. | [optional] 
**Discriminator** | [**OxSchemaDiscriminator**](OxSchemaDiscriminator.md) |  | [optional] 
**Variants** | [**List&lt;OxSchemaVariant&gt;**](OxSchemaVariant.md) | The concrete types a value of this type can hold besides itself, ordinally by name (format 1.1). The members only some of them carry are on &#x60;properties&#x60; with &#x60;onlyFor&#x60;. Absent on a type that has no variants. | [optional] 
**BaseVariant** | **string** | The name an &#x60;is&#x60; filter accepts for a value stored as this polymorphic type itself (format 1.1): the type&#39;s own name when it is a concrete class. Absent on an abstract class or an interface, whose values are always one of &#x60;variants&#x60;, and on a type that has no variants. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

