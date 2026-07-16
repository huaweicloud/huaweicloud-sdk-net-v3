using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowOsConfigResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：网络配置项。
        /// </summary>
        [JsonProperty("networkCidrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NetworkCidrs { get; set; }

        /// <summary>
        /// **参数解释**：用户可创建网络个数配额。 **取值范围**：不涉及
        /// </summary>
        [JsonProperty("networkQuota", NullValueHandling = NullValueHandling.Ignore)]
        public int? NetworkQuota { get; set; }

        /// <summary>
        /// **参数解释**：用户可创建资源池个数配额。 **取值范围**：不涉及
        /// </summary>
        [JsonProperty("poolQuota", NullValueHandling = NullValueHandling.Ignore)]
        public int? PoolQuota { get; set; }

        /// <summary>
        /// **参数解释**：当前环境/局点是否支持创建高可用资源池。 **取值范围**： - true：支持 - false：不支持
        /// </summary>
        [JsonProperty("poolHighAvailable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PoolHighAvailable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowOsConfigResponse {\n");
            sb.Append("  networkCidrs: ").Append(NetworkCidrs).Append("\n");
            sb.Append("  networkQuota: ").Append(NetworkQuota).Append("\n");
            sb.Append("  poolQuota: ").Append(PoolQuota).Append("\n");
            sb.Append("  poolHighAvailable: ").Append(PoolHighAvailable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowOsConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowOsConfigResponse input)
        {
            if (input == null) return false;
            if (this.NetworkCidrs != input.NetworkCidrs || (this.NetworkCidrs != null && input.NetworkCidrs != null && !this.NetworkCidrs.SequenceEqual(input.NetworkCidrs))) return false;
            if (this.NetworkQuota != input.NetworkQuota || (this.NetworkQuota != null && !this.NetworkQuota.Equals(input.NetworkQuota))) return false;
            if (this.PoolQuota != input.PoolQuota || (this.PoolQuota != null && !this.PoolQuota.Equals(input.PoolQuota))) return false;
            if (this.PoolHighAvailable != input.PoolHighAvailable || (this.PoolHighAvailable != null && !this.PoolHighAvailable.Equals(input.PoolHighAvailable))) return false;

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
                if (this.NetworkCidrs != null) hashCode = hashCode * 59 + this.NetworkCidrs.GetHashCode();
                if (this.NetworkQuota != null) hashCode = hashCode * 59 + this.NetworkQuota.GetHashCode();
                if (this.PoolQuota != null) hashCode = hashCode * 59 + this.PoolQuota.GetHashCode();
                if (this.PoolHighAvailable != null) hashCode = hashCode * 59 + this.PoolHighAvailable.GetHashCode();
                return hashCode;
            }
        }
    }
}
