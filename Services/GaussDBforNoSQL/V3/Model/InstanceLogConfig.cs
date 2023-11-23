using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InstanceLogConfig 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("instance", NullValueHandling = NullValueHandling.Ignore)]
        public LogInstanceInfo Instance { get; set; }

        /// <summary>
        /// LTS日志配置明细。从未设置LTS日志流，不返回该字段。
        /// </summary>
        [JsonProperty("lts_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceLogConfigDetail> LtsConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceLogConfig {\n");
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
            return this.Equals(input as InstanceLogConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceLogConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Instance == input.Instance ||
                    (this.Instance != null &&
                    this.Instance.Equals(input.Instance))
                ) && 
                (
                    this.LtsConfigs == input.LtsConfigs ||
                    this.LtsConfigs != null &&
                    input.LtsConfigs != null &&
                    this.LtsConfigs.SequenceEqual(input.LtsConfigs)
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
                if (this.Instance != null)
                    hashCode = hashCode * 59 + this.Instance.GetHashCode();
                if (this.LtsConfigs != null)
                    hashCode = hashCode * 59 + this.LtsConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
