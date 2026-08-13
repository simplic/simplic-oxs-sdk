# Simplic.OxS.SDK.Ai.LLMTierModel
Model representing a single selectable capability/cost tier (see Simplic.OxS.AI.LLMTier), resolved to the concrete model + reasoning effort combination it currently maps to.  Deliberately does NOT carry a label or description: those are localized presentation copy (\"Fast\", \"Good for quick answers, lower cost\", etc.), which belongs in the frontend's i18n catalog keyed by Simplic.OxS.AI.Server.Model.LLMTierModel.Tier, not as single-language strings shipped from the backend. Simplic.OxS.AI.Server.Model.LLMTierModel.Tier itself is a stable classifier, not translated content, so the backend owns it directly.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tier** | **string** | Gets or sets the tier key (see Simplic.OxS.AI.LLMTier), e.g. \&quot;fast\&quot;, \&quot;balanced\&quot;, \&quot;powerful\&quot;. Clients key their localized label/description text by this value. | 
**Model** | **string** | Gets or sets the raw model id this tier currently resolves to (e.g. \&quot;claude-sonnet-4-6\&quot;). Clients must send this back as &#x60;Conversation.Model&#x60; when the user has this tier selected — it may change over time as the backend re-tunes which model backs each tier, without requiring a frontend deploy. | 
**Effort** | **string** | Gets or sets the reasoning effort (see Simplic.OxS.AI.ReasoningEffort) this tier currently resolves to, or &#x60;null&#x60; if the underlying model has no tunable reasoning effort. Clients must send this back as &#x60;Conversation.Effort&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

