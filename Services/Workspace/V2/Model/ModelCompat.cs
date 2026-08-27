using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 模型兼容性配置。
    /// </summary>
    public class ModelCompat 
    {

        /// <summary>
        /// 是否支持使用量流式传输。
        /// </summary>
        [JsonProperty("supports_usage_streaming", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportsUsageStreaming { get; set; }

        /// <summary>
        /// 是否支持开发者角色。
        /// </summary>
        [JsonProperty("supports_developer_role", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportsDeveloperRole { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelCompat {\n");
            sb.Append("  supportsUsageStreaming: ").Append(SupportsUsageStreaming).Append("\n");
            sb.Append("  supportsDeveloperRole: ").Append(SupportsDeveloperRole).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModelCompat);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModelCompat input)
        {
            if (input == null) return false;
            if (this.SupportsUsageStreaming != input.SupportsUsageStreaming || (this.SupportsUsageStreaming != null && !this.SupportsUsageStreaming.Equals(input.SupportsUsageStreaming))) return false;
            if (this.SupportsDeveloperRole != input.SupportsDeveloperRole || (this.SupportsDeveloperRole != null && !this.SupportsDeveloperRole.Equals(input.SupportsDeveloperRole))) return false;

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
                if (this.SupportsUsageStreaming != null) hashCode = hashCode * 59 + this.SupportsUsageStreaming.GetHashCode();
                if (this.SupportsDeveloperRole != null) hashCode = hashCode * 59 + this.SupportsDeveloperRole.GetHashCode();
                return hashCode;
            }
        }
    }
}
