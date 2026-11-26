using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListGlobalFeatureGatesResponse : SdkResponse
    {

        /// <summary>
        /// 是否支持使用用户的obs桶
        /// </summary>
        [JsonProperty("enableUserDefObs", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableUserDefObs { get; set; }

        /// <summary>
        /// 是否支持支持企业项目
        /// </summary>
        [JsonProperty("enableEnterprise", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableEnterprise { get; set; }

        /// <summary>
        /// 是否支持SWR企业版功能
        /// </summary>
        [JsonProperty("cerAvailable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CerAvailable { get; set; }

        /// <summary>
        /// 是否展示创建内网访问的开关按钮
        /// </summary>
        [JsonProperty("enableIntranetAccessSwitch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableIntranetAccessSwitch { get; set; }

        /// <summary>
        /// 是否支持Console侧的一键委托
        /// </summary>
        [JsonProperty("enableConsoleAgency", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableConsoleAgency { get; set; }

        /// <summary>
        /// 是否支持IAM新平面的信任委托
        /// </summary>
        [JsonProperty("enableV5CustomAgency", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableV5CustomAgency { get; set; }

        /// <summary>
        /// 委托名称
        /// </summary>
        [JsonProperty("agencyName", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListGlobalFeatureGatesResponse {\n");
            sb.Append("  enableUserDefObs: ").Append(EnableUserDefObs).Append("\n");
            sb.Append("  enableEnterprise: ").Append(EnableEnterprise).Append("\n");
            sb.Append("  cerAvailable: ").Append(CerAvailable).Append("\n");
            sb.Append("  enableIntranetAccessSwitch: ").Append(EnableIntranetAccessSwitch).Append("\n");
            sb.Append("  enableConsoleAgency: ").Append(EnableConsoleAgency).Append("\n");
            sb.Append("  enableV5CustomAgency: ").Append(EnableV5CustomAgency).Append("\n");
            sb.Append("  agencyName: ").Append(AgencyName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListGlobalFeatureGatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGlobalFeatureGatesResponse input)
        {
            if (input == null) return false;
            if (this.EnableUserDefObs != input.EnableUserDefObs || (this.EnableUserDefObs != null && !this.EnableUserDefObs.Equals(input.EnableUserDefObs))) return false;
            if (this.EnableEnterprise != input.EnableEnterprise || (this.EnableEnterprise != null && !this.EnableEnterprise.Equals(input.EnableEnterprise))) return false;
            if (this.CerAvailable != input.CerAvailable || (this.CerAvailable != null && !this.CerAvailable.Equals(input.CerAvailable))) return false;
            if (this.EnableIntranetAccessSwitch != input.EnableIntranetAccessSwitch || (this.EnableIntranetAccessSwitch != null && !this.EnableIntranetAccessSwitch.Equals(input.EnableIntranetAccessSwitch))) return false;
            if (this.EnableConsoleAgency != input.EnableConsoleAgency || (this.EnableConsoleAgency != null && !this.EnableConsoleAgency.Equals(input.EnableConsoleAgency))) return false;
            if (this.EnableV5CustomAgency != input.EnableV5CustomAgency || (this.EnableV5CustomAgency != null && !this.EnableV5CustomAgency.Equals(input.EnableV5CustomAgency))) return false;
            if (this.AgencyName != input.AgencyName || (this.AgencyName != null && !this.AgencyName.Equals(input.AgencyName))) return false;

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
                if (this.EnableUserDefObs != null) hashCode = hashCode * 59 + this.EnableUserDefObs.GetHashCode();
                if (this.EnableEnterprise != null) hashCode = hashCode * 59 + this.EnableEnterprise.GetHashCode();
                if (this.CerAvailable != null) hashCode = hashCode * 59 + this.CerAvailable.GetHashCode();
                if (this.EnableIntranetAccessSwitch != null) hashCode = hashCode * 59 + this.EnableIntranetAccessSwitch.GetHashCode();
                if (this.EnableConsoleAgency != null) hashCode = hashCode * 59 + this.EnableConsoleAgency.GetHashCode();
                if (this.EnableV5CustomAgency != null) hashCode = hashCode * 59 + this.EnableV5CustomAgency.GetHashCode();
                if (this.AgencyName != null) hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                return hashCode;
            }
        }
    }
}
