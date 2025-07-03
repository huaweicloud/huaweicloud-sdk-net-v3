using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowMonitorItemViewConfigRequest 
    {

        /// <summary>
        /// 环境id。
        /// </summary>
        [SDKProperty("env_id", IsQuery = true)]
        [JsonProperty("env_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnvId { get; set; }

        /// <summary>
        /// 采集器id。
        /// </summary>
        [SDKProperty("collector_id", IsQuery = true)]
        [JsonProperty("collector_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? CollectorId { get; set; }

        /// <summary>
        /// 应用id。
        /// </summary>
        [SDKProperty("x-business-id", IsHeader = true)]
        [JsonProperty("x-business-id", NullValueHandling = NullValueHandling.Ignore)]
        public long? XBusinessId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMonitorItemViewConfigRequest {\n");
            sb.Append("  envId: ").Append(EnvId).Append("\n");
            sb.Append("  collectorId: ").Append(CollectorId).Append("\n");
            sb.Append("  xBusinessId: ").Append(XBusinessId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMonitorItemViewConfigRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMonitorItemViewConfigRequest input)
        {
            if (input == null) return false;
            if (this.EnvId != input.EnvId || (this.EnvId != null && !this.EnvId.Equals(input.EnvId))) return false;
            if (this.CollectorId != input.CollectorId || (this.CollectorId != null && !this.CollectorId.Equals(input.CollectorId))) return false;
            if (this.XBusinessId != input.XBusinessId || (this.XBusinessId != null && !this.XBusinessId.Equals(input.XBusinessId))) return false;

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
                if (this.EnvId != null) hashCode = hashCode * 59 + this.EnvId.GetHashCode();
                if (this.CollectorId != null) hashCode = hashCode * 59 + this.CollectorId.GetHashCode();
                if (this.XBusinessId != null) hashCode = hashCode * 59 + this.XBusinessId.GetHashCode();
                return hashCode;
            }
        }
    }
}
