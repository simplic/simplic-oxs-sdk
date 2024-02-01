api.mustache
    inject
    prefixed internal client & interface with `__`
    format ctor @223
    add usings
    update ApiException references
    remove `{{packageName}}.` @742, 756, 98
    replace all `new StreamContent` with `StreamContentExtension.From`
ApiFactory.mustache
    inject
ApiException.mustache
    inject
    prefix internal exception with `__`
ApiResponse`1.mustache
    inject
    prefix internal response with `__`
    add using
ApiResponseEventArgs`1.mustache
    update refs
ClientUtils.mustache
    static fix duplicates
Option.mustache
    change IsSet to public
JsonConverter.mustache 
    inject
AsModel.mustache
    remove `{{packageName}}.`
TokenProvider`1.mustache
    inject
    change token[] to list
RateLimitProvider`1.mustache
    change _tokens.Length to _tokens.Count