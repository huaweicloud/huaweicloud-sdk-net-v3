using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// auth信息
    /// </summary>
    public class GetIdTokenAuthParams 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id_token", NullValueHandling = NullValueHandling.Ignore)]
        public GetIdTokenIdTokenBody IdToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public GetIdTokenIdScopeBody Scope { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetIdTokenAuthParams {\n");
            sb.Append("  idToken: ").Append(IdToken).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetIdTokenAuthParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetIdTokenAuthParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdToken == input.IdToken ||
                    (this.IdToken != null &&
                    this.IdToken.Equals(input.IdToken))
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.IdToken != null)
                    hashCode = hashCode * 59 + this.IdToken.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                return hashCode;
            }
        }
    }
}
