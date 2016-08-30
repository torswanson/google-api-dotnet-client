// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.16.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Google App State API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://developers.google.com/games/services/web/api/states'>Google App State API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20160824 (601)
 *      <tr><th>API Docs
 *          <td><a href='https://developers.google.com/games/services/web/api/states'>
 *              https://developers.google.com/games/services/web/api/states</a>
 *      <tr><th>Discovery Name<td>appstate
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Google App State API can be found at
 * <a href='https://developers.google.com/games/services/web/api/states'>https://developers.google.com/games/services/web/api/states</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.AppState.v1
{
    /// <summary>The AppState Service.</summary>
    public class AppStateService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AppStateService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AppStateService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            states = new StatesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "appstate"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://www.googleapis.com/appstate/v1/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return "appstate/v1/"; }
        }

        /// <summary>Available OAuth 2.0 scopes for use with the Google App State API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data for this application</summary>
            public static string Appstate = "https://www.googleapis.com/auth/appstate";

        }



        private readonly StatesResource states;

        /// <summary>Gets the States resource.</summary>
        public virtual StatesResource States
        {
            get { return states; }
        }
    }

    ///<summary>A base abstract class for AppState requests.</summary>
    public abstract class AppStateBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new AppStateBaseServiceRequest instance.</summary>
        protected AppStateBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>IP address of the site where the request originates. Use this if you want to enforce per-user
        /// limits.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes AppState parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "userIp", new Google.Apis.Discovery.Parameter
                {
                    Name = "userIp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "states" collection of methods.</summary>
    public class StatesResource
    {
        private const string Resource = "states";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public StatesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Clears (sets to empty) the data for the passed key if and only if the passed version matches the
        /// currently stored version. This method results in a conflict error on version mismatch.</summary>
        /// <param name="stateKey">The key for the data to be retrieved.</param>
        public virtual ClearRequest Clear(int stateKey)
        {
            return new ClearRequest(service, stateKey);
        }

        /// <summary>Clears (sets to empty) the data for the passed key if and only if the passed version matches the
        /// currently stored version. This method results in a conflict error on version mismatch.</summary>
        public class ClearRequest : AppStateBaseServiceRequest<Google.Apis.AppState.v1.Data.WriteResult>
        {
            /// <summary>Constructs a new Clear request.</summary>
            public ClearRequest(Google.Apis.Services.IClientService service, int stateKey)
                : base(service)
            {
                StateKey = stateKey;
                InitParameters();
            }


            /// <summary>The key for the data to be retrieved.</summary>
            /// [minimum: 0]
            /// [maximum: 3]
            [Google.Apis.Util.RequestParameterAttribute("stateKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int StateKey { get; private set; }

            /// <summary>The version of the data to be cleared. Version strings are returned by the server.</summary>
            [Google.Apis.Util.RequestParameterAttribute("currentDataVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CurrentDataVersion { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "clear"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "POST"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "states/{stateKey}/clear"; }
            }

            /// <summary>Initializes Clear parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "stateKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "stateKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "currentDataVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "currentDataVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Deletes a key and the data associated with it. The key is removed and no longer counts against the
        /// key quota. Note that since this method is not safe in the face of concurrent modifications, it should only
        /// be used for development and testing purposes. Invoking this method in shipping code can result in data loss
        /// and data corruption.</summary>
        /// <param name="stateKey">The key for the data to be retrieved.</param>
        public virtual DeleteRequest Delete(int stateKey)
        {
            return new DeleteRequest(service, stateKey);
        }

        /// <summary>Deletes a key and the data associated with it. The key is removed and no longer counts against the
        /// key quota. Note that since this method is not safe in the face of concurrent modifications, it should only
        /// be used for development and testing purposes. Invoking this method in shipping code can result in data loss
        /// and data corruption.</summary>
        public class DeleteRequest : AppStateBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, int stateKey)
                : base(service)
            {
                StateKey = stateKey;
                InitParameters();
            }


            /// <summary>The key for the data to be retrieved.</summary>
            /// [minimum: 0]
            /// [maximum: 3]
            [Google.Apis.Util.RequestParameterAttribute("stateKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int StateKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "delete"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "DELETE"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "states/{stateKey}"; }
            }

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "stateKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "stateKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves the data corresponding to the passed key. If the key does not exist on the server, an
        /// HTTP 404 will be returned.</summary>
        /// <param name="stateKey">The key for the data to be retrieved.</param>
        public virtual GetRequest Get(int stateKey)
        {
            return new GetRequest(service, stateKey);
        }

        /// <summary>Retrieves the data corresponding to the passed key. If the key does not exist on the server, an
        /// HTTP 404 will be returned.</summary>
        public class GetRequest : AppStateBaseServiceRequest<Google.Apis.AppState.v1.Data.GetResponse>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, int stateKey)
                : base(service)
            {
                StateKey = stateKey;
                InitParameters();
            }


            /// <summary>The key for the data to be retrieved.</summary>
            /// [minimum: 0]
            /// [maximum: 3]
            [Google.Apis.Util.RequestParameterAttribute("stateKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int StateKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "get"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "states/{stateKey}"; }
            }

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "stateKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "stateKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists all the states keys, and optionally the state data.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists all the states keys, and optionally the state data.</summary>
        public class ListRequest : AppStateBaseServiceRequest<Google.Apis.AppState.v1.Data.ListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }


            /// <summary>Whether to include the full data in addition to the version number</summary>
            /// [default: false]
            [Google.Apis.Util.RequestParameterAttribute("includeData", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeData { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "list"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "GET"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "states"; }
            }

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "includeData", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeData",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "false",
                        Pattern = null,
                    });
            }

        }

        /// <summary>Update the data associated with the input key if and only if the passed version matches the
        /// currently stored version. This method is safe in the face of concurrent writes. Maximum per-key size is
        /// 128KB.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="stateKey">The key for the data to be retrieved.</param>
        public virtual UpdateRequest Update(Google.Apis.AppState.v1.Data.UpdateRequest body, int stateKey)
        {
            return new UpdateRequest(service, body, stateKey);
        }

        /// <summary>Update the data associated with the input key if and only if the passed version matches the
        /// currently stored version. This method is safe in the face of concurrent writes. Maximum per-key size is
        /// 128KB.</summary>
        public class UpdateRequest : AppStateBaseServiceRequest<Google.Apis.AppState.v1.Data.WriteResult>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AppState.v1.Data.UpdateRequest body, int stateKey)
                : base(service)
            {
                StateKey = stateKey;
                Body = body;
                InitParameters();
            }


            /// <summary>The key for the data to be retrieved.</summary>
            /// [minimum: 0]
            /// [maximum: 3]
            [Google.Apis.Util.RequestParameterAttribute("stateKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int StateKey { get; private set; }

            /// <summary>The version of the app state your application is attempting to update. If this does not match
            /// the current version, this method will return a conflict error. If there is no data stored on the server
            /// for this key, the update will succeed irrespective of the value of this parameter.</summary>
            [Google.Apis.Util.RequestParameterAttribute("currentStateVersion", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CurrentStateVersion { get; set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AppState.v1.Data.UpdateRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "update"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "PUT"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "states/{stateKey}"; }
            }

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "stateKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "stateKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "currentStateVersion", new Google.Apis.Discovery.Parameter
                    {
                        Name = "currentStateVersion",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.AppState.v1.Data
{    

    /// <summary>This is a JSON template for an app state resource.</summary>
    public class GetResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current app state version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentStateVersion")]
        public virtual string CurrentStateVersion { get; set; } 

        /// <summary>The requested data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; } 

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// appstate#getResponse.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The key for the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateKey")]
        public virtual System.Nullable<int> StateKey { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This is a JSON template to convert a list-response for app state.</summary>
    public class ListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The app state data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GetResponse> Items { get; set; } 

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// appstate#listResponse.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The maximum number of keys allowed for this user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumKeyCount")]
        public virtual System.Nullable<int> MaximumKeyCount { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This is a JSON template for a requests which update app state</summary>
    public class UpdateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The new app state data that your application is trying to update with.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; } 

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// appstate#updateRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This is a JSON template for an app state write result.</summary>
    public class WriteResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The version of the data for this key on the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentStateVersion")]
        public virtual string CurrentStateVersion { get; set; } 

        /// <summary>Uniquely identifies the type of this resource. Value is always the fixed string
        /// appstate#writeResult.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The written key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateKey")]
        public virtual System.Nullable<int> StateKey { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
