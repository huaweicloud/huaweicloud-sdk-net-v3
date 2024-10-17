using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ModifyOttChannelInfoEncoderSettingsRequest 
    {

        /// <summary>
        /// 服务鉴权Token，服务开启鉴权，必须携带Access-Control-Allow-Internal访问服务。
        /// </summary>
        [SDKProperty("Access-Control-Allow-Internal", IsHeader = true)]
        [JsonProperty("Access-Control-Allow-Internal", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessControlAllowInternal { get; set; }

        /// <summary>
        /// 服务鉴权Token，服务开启鉴权，必须携带Access-Control-Allow-External访问服务。
        /// </summary>
        [SDKProperty("Access-Control-Allow-External", IsHeader = true)]
        [JsonProperty("Access-Control-Allow-External", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessControlAllowExternal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public ModifyOttChannelEncoderSettings Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyOttChannelInfoEncoderSettingsRequest {\n");
            sb.Append("  accessControlAllowInternal: ").Append(AccessControlAllowInternal).Append("\n");
            sb.Append("  accessControlAllowExternal: ").Append(AccessControlAllowExternal).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyOttChannelInfoEncoderSettingsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyOttChannelInfoEncoderSettingsRequest input)
        {
            if (input == null) return false;
            if (this.AccessControlAllowInternal != input.AccessControlAllowInternal || (this.AccessControlAllowInternal != null && !this.AccessControlAllowInternal.Equals(input.AccessControlAllowInternal))) return false;
            if (this.AccessControlAllowExternal != input.AccessControlAllowExternal || (this.AccessControlAllowExternal != null && !this.AccessControlAllowExternal.Equals(input.AccessControlAllowExternal))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.AccessControlAllowInternal != null) hashCode = hashCode * 59 + this.AccessControlAllowInternal.GetHashCode();
                if (this.AccessControlAllowExternal != null) hashCode = hashCode * 59 + this.AccessControlAllowExternal.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
