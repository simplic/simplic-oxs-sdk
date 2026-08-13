# Simplic.OxS.SDK.Ai.LLMModelInfoModel
Model representing a selectable LLM model, enriched with vendor/display metadata so UIs don't have to infer branding by pattern-matching the raw model id.  Deliberately does NOT carry description text: that's localized presentation copy, which belongs in the frontend's i18n catalog (translated per-locale, keyed by Simplic.OxS.AI.Server.Model.LLMModelInfoModel.Family), not as a single-language string shipped from the backend. Simplic.OxS.AI.Server.Model.LLMModelInfoModel.DisplayName and Simplic.OxS.AI.Server.Model.LLMModelInfoModel.Family are different: they're the same value in every locale (a brand/version string and a stable classifier, respectively), so the backend owns them directly instead of every client keeping its own synced copy.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Gets or sets the raw model id (e.g. \&quot;claude-opus-4-7\&quot;). This is the value clients must send back in requests (e.g. as &#x60;Conversation.Model&#x60; or the &#x60;model&#x60; query parameter of &#x60;get-efforts&#x60;). | 
**Vendor** | **string** | Gets or sets the vendor/company identifier that owns this model (e.g. \&quot;anthropic\&quot;, \&quot;openai\&quot;), as reported by the owning Simplic.OxS.AI.ILLMProvider.Vendor. Clients can use this to pick a matching brand icon without pattern-matching Simplic.OxS.AI.Server.Model.LLMModelInfoModel.Name. | [optional] 
**DisplayName** | **string** | Gets or sets the human-friendly display name for this model (e.g. \&quot;Claude Opus 4.7\&quot;), as reported by M:Simplic.OxS.AI.ILLMProvider.GetDisplayName(System.String). | 
**Family** | **string** | Gets or sets the product family/tier this model belongs to (e.g. \&quot;opus\&quot;, \&quot;sonnet\&quot;, \&quot;haiku\&quot;, \&quot;gpt\&quot;), as reported by M:Simplic.OxS.AI.ILLMProvider.GetFamily(System.String). Clients key their localized description text by this, not by Simplic.OxS.AI.Server.Model.LLMModelInfoModel.Name, so a pinned snapshot and its \&quot;-latest\&quot; rolling alias share one translation. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

