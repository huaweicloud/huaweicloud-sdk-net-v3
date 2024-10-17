using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchDeleteDashboardRequestBody 
    {

        /// <summary>
        /// 监控看板id列表
        /// </summary>
        [JsonProperty("dashboard_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DashboardIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteDashboardRequestBody {\n");
            sb.Append("  dashboardIds: ").Append(DashboardIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteDashboardRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteDashboardRequestBody input)
        {
            if (input == null) return false;
            if (this.DashboardIds != input.DashboardIds || (this.DashboardIds != null && input.DashboardIds != null && !this.DashboardIds.SequenceEqual(input.DashboardIds))) return false;

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
                if (this.DashboardIds != null) hashCode = hashCode * 59 + this.DashboardIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
