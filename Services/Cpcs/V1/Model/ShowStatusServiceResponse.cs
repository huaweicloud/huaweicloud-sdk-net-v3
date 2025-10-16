using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowStatusServiceResponse : SdkResponse
    {

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 服务列表
        /// </summary>
        [JsonProperty("server_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowStatusServiceResponseBodyServerList> ServerList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStatusServiceResponse {\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  serverList: ").Append(ServerList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStatusServiceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStatusServiceResponse input)
        {
            if (input == null) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.ServerList != input.ServerList || (this.ServerList != null && input.ServerList != null && !this.ServerList.SequenceEqual(input.ServerList))) return false;

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
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.ServerList != null) hashCode = hashCode * 59 + this.ServerList.GetHashCode();
                return hashCode;
            }
        }
    }
}
