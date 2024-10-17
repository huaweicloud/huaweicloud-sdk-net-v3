using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteDashboardRequest 
    {

        /// <summary>
        /// 仪表盘id
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 是否删除图表
        /// </summary>
        [SDKProperty("is_delete_charts", IsQuery = true)]
        [JsonProperty("is_delete_charts", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDeleteCharts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteDashboardRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  isDeleteCharts: ").Append(IsDeleteCharts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteDashboardRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteDashboardRequest input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.IsDeleteCharts != input.IsDeleteCharts || (this.IsDeleteCharts != null && !this.IsDeleteCharts.Equals(input.IsDeleteCharts))) return false;

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
                if (this.IsDeleteCharts != null) hashCode = hashCode * 59 + this.IsDeleteCharts.GetHashCode();
                return hashCode;
            }
        }
    }
}
