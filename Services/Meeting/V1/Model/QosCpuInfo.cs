using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 会议与会者CPU QoS数据，当qosType &#x3D; cpu 时有效。
    /// </summary>
    public class QosCpuInfo 
    {

        /// <summary>
        /// App最大CPU使用率。
        /// </summary>
        [JsonProperty("client_cpu_max", NullValueHandling = NullValueHandling.Ignore)]
        public List<QosDataElement> ClientCpuMax { get; set; }

        /// <summary>
        /// 系统最大CPU使用率。
        /// </summary>
        [JsonProperty("system_cpu_max", NullValueHandling = NullValueHandling.Ignore)]
        public List<QosDataElement> SystemCpuMax { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QosCpuInfo {\n");
            sb.Append("  clientCpuMax: ").Append(ClientCpuMax).Append("\n");
            sb.Append("  systemCpuMax: ").Append(SystemCpuMax).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QosCpuInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QosCpuInfo input)
        {
            if (input == null) return false;
            if (this.ClientCpuMax != input.ClientCpuMax || (this.ClientCpuMax != null && input.ClientCpuMax != null && !this.ClientCpuMax.SequenceEqual(input.ClientCpuMax))) return false;
            if (this.SystemCpuMax != input.SystemCpuMax || (this.SystemCpuMax != null && input.SystemCpuMax != null && !this.SystemCpuMax.SequenceEqual(input.SystemCpuMax))) return false;

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
                if (this.ClientCpuMax != null) hashCode = hashCode * 59 + this.ClientCpuMax.GetHashCode();
                if (this.SystemCpuMax != null) hashCode = hashCode * 59 + this.SystemCpuMax.GetHashCode();
                return hashCode;
            }
        }
    }
}
