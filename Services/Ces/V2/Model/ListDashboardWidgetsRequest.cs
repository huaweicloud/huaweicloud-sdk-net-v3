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
    /// Request Object
    /// </summary>
    public class ListDashboardWidgetsRequest 
    {

        /// <summary>
        /// 监控面板id，以db开头，包含22个字母和数字例：db16564943172807wjOmoLyn&#39;
        /// </summary>
        [SDKProperty("dashboard_id", IsPath = true)]
        [JsonProperty("dashboard_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DashboardId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDashboardWidgetsRequest {\n");
            sb.Append("  dashboardId: ").Append(DashboardId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDashboardWidgetsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDashboardWidgetsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DashboardId == input.DashboardId ||
                    (this.DashboardId != null &&
                    this.DashboardId.Equals(input.DashboardId))
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
                if (this.DashboardId != null)
                    hashCode = hashCode * 59 + this.DashboardId.GetHashCode();
                return hashCode;
            }
        }
    }
}
