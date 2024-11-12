# Simplic.OxS.SDK.Logistics.AttachResourceRequestSettings
Settings for a attach resources request to change some behaviour when attaching two resources.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttachDriverAsCoDriver** | **bool** | Gets or sets whether the driver should be attached as co driver during the attachment process. | [optional] [default to false]
**MoveCurrentDriverToCoDriver** | **bool** | Gets or sets whether the current driver should be moved to the co driver seat during attachment of a new driver. | [optional] [default to false]
**MoveCoDriverToMainDriver** | **bool** | Gets or sets whether the co driver should be moved to the main driver seat during attachment of a new co driver.     Only relevant when Simplic.OxS.Logistics.Server.Model.AttachResourceRequestSettings.AttachDriverAsCoDriver is set to true.   | [optional] [default to false]
**AddTrailerAsAdditionalTrailer** | **bool** | Gets or sets whether the attached trailer should be added as additional trailer.   If false or null the new trailer will replace all current trailer. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

