using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CloudAlarmDto 
    {

        /// <summary>
        /// 云服务名称
        /// </summary>
        [JsonProperty("cloudServiceName", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceName { get; set; }

        /// <summary>
        /// 云服务区域标识
        /// </summary>
        [JsonProperty("cloudServiceRegionId", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceRegionId { get; set; }

        /// <summary>
        /// 云服务站点：默认中国站
        /// </summary>
        [JsonProperty("cloudServiceSite", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceSite { get; set; }

        /// <summary>
        /// 是否开启CloudAlarm配置
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public string Enable { get; set; }

        /// <summary>
        /// 告警级别
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        /// 微服务组名称
        /// </summary>
        [JsonProperty("microServiceGroupName", NullValueHandling = NullValueHandling.Ignore)]
        public string MicroServiceGroupName { get; set; }

        /// <summary>
        /// 微服务名称
        /// </summary>
        [JsonProperty("microServiceName", NullValueHandling = NullValueHandling.Ignore)]
        public string MicroServiceName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudAlarmDto {\n");
            sb.Append("  cloudServiceName: ").Append(CloudServiceName).Append("\n");
            sb.Append("  cloudServiceRegionId: ").Append(CloudServiceRegionId).Append("\n");
            sb.Append("  cloudServiceSite: ").Append(CloudServiceSite).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  microServiceGroupName: ").Append(MicroServiceGroupName).Append("\n");
            sb.Append("  microServiceName: ").Append(MicroServiceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloudAlarmDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloudAlarmDto input)
        {
            if (input == null) return false;
            if (this.CloudServiceName != input.CloudServiceName || (this.CloudServiceName != null && !this.CloudServiceName.Equals(input.CloudServiceName))) return false;
            if (this.CloudServiceRegionId != input.CloudServiceRegionId || (this.CloudServiceRegionId != null && !this.CloudServiceRegionId.Equals(input.CloudServiceRegionId))) return false;
            if (this.CloudServiceSite != input.CloudServiceSite || (this.CloudServiceSite != null && !this.CloudServiceSite.Equals(input.CloudServiceSite))) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.MicroServiceGroupName != input.MicroServiceGroupName || (this.MicroServiceGroupName != null && !this.MicroServiceGroupName.Equals(input.MicroServiceGroupName))) return false;
            if (this.MicroServiceName != input.MicroServiceName || (this.MicroServiceName != null && !this.MicroServiceName.Equals(input.MicroServiceName))) return false;

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
                if (this.CloudServiceName != null) hashCode = hashCode * 59 + this.CloudServiceName.GetHashCode();
                if (this.CloudServiceRegionId != null) hashCode = hashCode * 59 + this.CloudServiceRegionId.GetHashCode();
                if (this.CloudServiceSite != null) hashCode = hashCode * 59 + this.CloudServiceSite.GetHashCode();
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.MicroServiceGroupName != null) hashCode = hashCode * 59 + this.MicroServiceGroupName.GetHashCode();
                if (this.MicroServiceName != null) hashCode = hashCode * 59 + this.MicroServiceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
