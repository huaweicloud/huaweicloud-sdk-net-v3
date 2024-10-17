using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PromConfigModel 
    {

        /// <summary>
        /// Prometheus实例remote-write地址。
        /// </summary>
        [JsonProperty("remote_write_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteWriteUrl { get; set; }

        /// <summary>
        /// Prometheus实例remote-read地址。
        /// </summary>
        [JsonProperty("remote_read_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteReadUrl { get; set; }

        /// <summary>
        /// Prometheus实例调用url。
        /// </summary>
        [JsonProperty("prom_http_api_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string PromHttpApiEndpoint { get; set; }

        /// <summary>
        /// Prometheus实例关联dashboard的dashboard id（目前未使用）。
        /// </summary>
        [JsonProperty("dashboard_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DashboardId { get; set; }

        /// <summary>
        /// Prometheus实例所属的region。
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PromConfigModel {\n");
            sb.Append("  remoteWriteUrl: ").Append(RemoteWriteUrl).Append("\n");
            sb.Append("  remoteReadUrl: ").Append(RemoteReadUrl).Append("\n");
            sb.Append("  promHttpApiEndpoint: ").Append(PromHttpApiEndpoint).Append("\n");
            sb.Append("  dashboardId: ").Append(DashboardId).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PromConfigModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PromConfigModel input)
        {
            if (input == null) return false;
            if (this.RemoteWriteUrl != input.RemoteWriteUrl || (this.RemoteWriteUrl != null && !this.RemoteWriteUrl.Equals(input.RemoteWriteUrl))) return false;
            if (this.RemoteReadUrl != input.RemoteReadUrl || (this.RemoteReadUrl != null && !this.RemoteReadUrl.Equals(input.RemoteReadUrl))) return false;
            if (this.PromHttpApiEndpoint != input.PromHttpApiEndpoint || (this.PromHttpApiEndpoint != null && !this.PromHttpApiEndpoint.Equals(input.PromHttpApiEndpoint))) return false;
            if (this.DashboardId != input.DashboardId || (this.DashboardId != null && !this.DashboardId.Equals(input.DashboardId))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;

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
                if (this.RemoteWriteUrl != null) hashCode = hashCode * 59 + this.RemoteWriteUrl.GetHashCode();
                if (this.RemoteReadUrl != null) hashCode = hashCode * 59 + this.RemoteReadUrl.GetHashCode();
                if (this.PromHttpApiEndpoint != null) hashCode = hashCode * 59 + this.PromHttpApiEndpoint.GetHashCode();
                if (this.DashboardId != null) hashCode = hashCode * 59 + this.DashboardId.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
