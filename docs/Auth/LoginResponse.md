# Simplic.OxS.SDK.Auth.LoginResponse
Response from the simplic /auth/login endpoint

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Token** | **string** | Gets or sets the produced token (e.g. jwt token or two-factor token) | [optional] 
**ErrorState** | **string** | Gets or sets the actual error state. Will be set to &#x60;mail_not_verified&#x60; if the login  was successful, but the mail address is not verified. | [optional] 
**TokenType** | **string** | Gets or sets the produced token.  &lt;list type&#x3D;\&quot;bullet\&quot;&gt;  &#x60;jwt&#x60;: Login completed, no two-factor required  &#x60;two-factor&#x60;: A second two-factor auth is required  Empty when mail address is not verified.  &lt;/list&gt; | [optional] 
**UserId** | **Guid** | Gets or sets the user-id. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

