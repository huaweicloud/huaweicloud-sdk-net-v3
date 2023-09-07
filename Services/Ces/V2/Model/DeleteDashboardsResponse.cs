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
    /// Response Object
    /// </summary>
    public class DeleteDashboardsResponse : SdkResponse
    {

        /// <summary>
        /// 批量删除监控看板返回结果
        /// </summary>
        [JsonProperty("dashboards", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchDeleteDashboardRespInfo> Dashboards { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteDashboardsResponse {\n");
            sb.Append("  dashboards: ").Append(Dashboards).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteDashboardsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteDashboardsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dashboards == input.Dashboards ||
                    this.Dashboards != null &&
                    input.Dashboards != null &&
                    this.Dashboards.SequenceEqual(input.Dashboards)
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
                if (this.Dashboards != null)
                    hashCode = hashCode * 59 + this.Dashboards.GetHashCode();
                return hashCode;
            }
        }
    }
}
