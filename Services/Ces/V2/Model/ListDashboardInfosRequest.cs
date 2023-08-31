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
    public class ListDashboardInfosRequest 
    {

        /// <summary>
        /// 企业项目Id
        /// </summary>
        [SDKProperty("enterprise_id", IsQuery = true)]
        [JsonProperty("enterprise_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 指定企业项目下监控面板是否收藏，true:收藏，false:未收藏，填此参数时，enterprise_id必填
        /// </summary>
        [SDKProperty("is_favorite", IsQuery = true)]
        [JsonProperty("is_favorite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// 监控面板名称
        /// </summary>
        [SDKProperty("dashboard_name", IsQuery = true)]
        [JsonProperty("dashboard_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DashboardName { get; set; }

        /// <summary>
        /// 监控面板id
        /// </summary>
        [SDKProperty("dashboard_id", IsQuery = true)]
        [JsonProperty("dashboard_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DashboardId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDashboardInfosRequest {\n");
            sb.Append("  enterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  isFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("  dashboardName: ").Append(DashboardName).Append("\n");
            sb.Append("  dashboardId: ").Append(DashboardId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDashboardInfosRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDashboardInfosRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.IsFavorite == input.IsFavorite ||
                    (this.IsFavorite != null &&
                    this.IsFavorite.Equals(input.IsFavorite))
                ) && 
                (
                    this.DashboardName == input.DashboardName ||
                    (this.DashboardName != null &&
                    this.DashboardName.Equals(input.DashboardName))
                ) && 
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
                if (this.EnterpriseId != null)
                    hashCode = hashCode * 59 + this.EnterpriseId.GetHashCode();
                if (this.IsFavorite != null)
                    hashCode = hashCode * 59 + this.IsFavorite.GetHashCode();
                if (this.DashboardName != null)
                    hashCode = hashCode * 59 + this.DashboardName.GetHashCode();
                if (this.DashboardId != null)
                    hashCode = hashCode * 59 + this.DashboardId.GetHashCode();
                return hashCode;
            }
        }
    }
}
