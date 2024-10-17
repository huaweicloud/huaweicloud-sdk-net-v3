using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 容灾任务监控数据响应体
    /// </summary>
    public class QueryDataGuardMonitorAndChartResp 
    {

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data_guard_minitor", NullValueHandling = NullValueHandling.Ignore)]
        public QueryDataGuardMonitorResponse DataGuardMinitor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryDataGuardMonitorAndChartResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  dataGuardMinitor: ").Append(DataGuardMinitor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryDataGuardMonitorAndChartResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryDataGuardMonitorAndChartResp input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DataGuardMinitor != input.DataGuardMinitor || (this.DataGuardMinitor != null && !this.DataGuardMinitor.Equals(input.DataGuardMinitor))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DataGuardMinitor != null) hashCode = hashCode * 59 + this.DataGuardMinitor.GetHashCode();
                return hashCode;
            }
        }
    }
}
