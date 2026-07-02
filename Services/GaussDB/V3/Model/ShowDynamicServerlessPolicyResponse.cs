using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowDynamicServerlessPolicyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  当前动态Serverless算力。  **取值范围**：  available_vcpus中的可选算力，大于等于min_vcpus，并且小于等于max_vcpus。未开启动态Serverless时为null。
        /// </summary>
        [JsonProperty("current_vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentVcpus { get; set; }

        /// <summary>
        /// **参数解释**：  最小动态Serverless算力。  **取值范围**：  available_vcpus中的可选算力，并且小于等于max_vcpus。未开启动态Serverless时为null。
        /// </summary>
        [JsonProperty("min_vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public string MinVcpus { get; set; }

        /// <summary>
        /// **参数解释**：  最大动态Serverless算力。  **取值范围**：  available_vcpus中的可选算力，并且大于等于min_vcpus。未开启动态Serverless时为null。
        /// </summary>
        [JsonProperty("max_vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxVcpus { get; set; }

        /// <summary>
        /// **参数解释**：  可选动态Serverless算力列表，不支持动态Serverless的实例该列表为空。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("available_vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableVcpus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDynamicServerlessPolicyResponse {\n");
            sb.Append("  currentVcpus: ").Append(CurrentVcpus).Append("\n");
            sb.Append("  minVcpus: ").Append(MinVcpus).Append("\n");
            sb.Append("  maxVcpus: ").Append(MaxVcpus).Append("\n");
            sb.Append("  availableVcpus: ").Append(AvailableVcpus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDynamicServerlessPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDynamicServerlessPolicyResponse input)
        {
            if (input == null) return false;
            if (this.CurrentVcpus != input.CurrentVcpus || (this.CurrentVcpus != null && !this.CurrentVcpus.Equals(input.CurrentVcpus))) return false;
            if (this.MinVcpus != input.MinVcpus || (this.MinVcpus != null && !this.MinVcpus.Equals(input.MinVcpus))) return false;
            if (this.MaxVcpus != input.MaxVcpus || (this.MaxVcpus != null && !this.MaxVcpus.Equals(input.MaxVcpus))) return false;
            if (this.AvailableVcpus != input.AvailableVcpus || (this.AvailableVcpus != null && input.AvailableVcpus != null && !this.AvailableVcpus.SequenceEqual(input.AvailableVcpus))) return false;

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
                if (this.CurrentVcpus != null) hashCode = hashCode * 59 + this.CurrentVcpus.GetHashCode();
                if (this.MinVcpus != null) hashCode = hashCode * 59 + this.MinVcpus.GetHashCode();
                if (this.MaxVcpus != null) hashCode = hashCode * 59 + this.MaxVcpus.GetHashCode();
                if (this.AvailableVcpus != null) hashCode = hashCode * 59 + this.AvailableVcpus.GetHashCode();
                return hashCode;
            }
        }
    }
}
