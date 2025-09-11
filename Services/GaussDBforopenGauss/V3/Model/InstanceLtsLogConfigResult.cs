using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InstanceLtsLogConfigResult 
    {

        /// <summary>
        /// **参数解释**: 实例基本信息。
        /// </summary>
        [JsonProperty("instance", NullValueHandling = NullValueHandling.Ignore)]
        public Object Instance { get; set; }

        /// <summary>
        /// **参数解释**: LTS相关信息。
        /// </summary>
        [JsonProperty("lts_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<LtsLogConfigResult> LtsConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceLtsLogConfigResult {\n");
            sb.Append("  instance: ").Append(Instance).Append("\n");
            sb.Append("  ltsConfigs: ").Append(LtsConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceLtsLogConfigResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceLtsLogConfigResult input)
        {
            if (input == null) return false;
            if (this.Instance != input.Instance || (this.Instance != null && !this.Instance.Equals(input.Instance))) return false;
            if (this.LtsConfigs != input.LtsConfigs || (this.LtsConfigs != null && input.LtsConfigs != null && !this.LtsConfigs.SequenceEqual(input.LtsConfigs))) return false;

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
                if (this.Instance != null) hashCode = hashCode * 59 + this.Instance.GetHashCode();
                if (this.LtsConfigs != null) hashCode = hashCode * 59 + this.LtsConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
