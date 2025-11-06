using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RepositoryHookRequest 
    {

        /// <summary>
        /// 触发url
        /// </summary>
        [JsonProperty("hook_url", NullValueHandling = NullValueHandling.Ignore)]
        public string HookUrl { get; set; }

        /// <summary>
        /// 事件来源
        /// </summary>
        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public string Service { get; set; }

        /// <summary>
        /// 安全令牌
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }

        /// <summary>
        /// 触发事件
        /// </summary>
        [JsonProperty("hook_events", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HookEvents { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryHookRequest {\n");
            sb.Append("  hookUrl: ").Append(HookUrl).Append("\n");
            sb.Append("  service: ").Append(Service).Append("\n");
            sb.Append("  token: ").Append(Token).Append("\n");
            sb.Append("  hookEvents: ").Append(HookEvents).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryHookRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryHookRequest input)
        {
            if (input == null) return false;
            if (this.HookUrl != input.HookUrl || (this.HookUrl != null && !this.HookUrl.Equals(input.HookUrl))) return false;
            if (this.Service != input.Service || (this.Service != null && !this.Service.Equals(input.Service))) return false;
            if (this.Token != input.Token || (this.Token != null && !this.Token.Equals(input.Token))) return false;
            if (this.HookEvents != input.HookEvents || (this.HookEvents != null && input.HookEvents != null && !this.HookEvents.SequenceEqual(input.HookEvents))) return false;

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
                if (this.HookUrl != null) hashCode = hashCode * 59 + this.HookUrl.GetHashCode();
                if (this.Service != null) hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.Token != null) hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.HookEvents != null) hashCode = hashCode * 59 + this.HookEvents.GetHashCode();
                return hashCode;
            }
        }
    }
}
