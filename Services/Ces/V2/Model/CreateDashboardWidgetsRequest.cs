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
    public class CreateDashboardWidgetsRequest 
    {

        /// <summary>
        /// 监控面板id，以db开头，包含22个字母和数字例：db16564943172807wjOmoLyn&#39;
        /// </summary>
        [SDKProperty("dashboard_id", IsPath = true)]
        [JsonProperty("dashboard_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DashboardId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public List<BaseWidgetInfo> Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDashboardWidgetsRequest {\n");
            sb.Append("  dashboardId: ").Append(DashboardId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDashboardWidgetsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDashboardWidgetsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DashboardId == input.DashboardId ||
                    (this.DashboardId != null &&
                    this.DashboardId.Equals(input.DashboardId))
                ) && 
                (
                    this.Body == input.Body ||
                    this.Body != null &&
                    input.Body != null &&
                    this.Body.SequenceEqual(input.Body)
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
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
