﻿// Copyright 2017 the original author or authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Steeltoe.Security.Authentication.CloudFoundry
{
    public class CloudFoundryDefaults
    {
        public const string SECURITY_CLIENT_SECTION_PREFIX = "security:oauth2:client";
        public const string SECURITY_RESOURCE_SECTION_PREFIX = "security:oauth2:resource";

        public const string AuthenticationScheme = "CloudFoundry";
        public const string DisplayName = "CloudFoundry";
        public const string AuthorizationUri = "/oauth/authorize";
        public const string AccessTokenUri = "/oauth/token";
        public const string UserInfoUri = "/userinfo";
        public const string CheckTokenUri = "/check_token";
        public const string JwtTokenKey = "/token_keys";
        public const string OAuthServiceUrl = "Default_OAuthServiceUrl";
        public const string ClientId = "Default_ClientId";
        public const string ClientSecret = "Default_ClientSecret";
        public const bool ValidateCertificates = true;
    }
}
