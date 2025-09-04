using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 设置统计配置请求体
    /// </summary>
    public class SetStatsConfigBody 
    {

        /// <summary>
        /// 配置类别.0：热点统计类
        /// </summary>
        [JsonProperty("config_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConfigType { get; set; }

        /// <summary>
        /// 资源类型。domain:resource_name为域名，account:resource_name为账号
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 资源名称为账号或域名。多个域名以英文逗号分隔
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 配置信息.top指标仅支持ua、refer、url、origin url
        /// </summary>
        [JsonProperty("config_info", NullValueHandling = NullValueHandling.Ignore)]
        public Object ConfigInfo { get; set; }

        /// <summary>
        /// 统计配置失效时间，秒时间戳。不能超过当前时间点往后一年
        /// </summary>
        [JsonProperty("expired_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpiredTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetStatsConfigBody {\n");
            sb.Append("  configType: ").Append(ConfigType).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  configInfo: ").Append(ConfigInfo).Append("\n");
            sb.Append("  expiredTime: ").Append(ExpiredTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetStatsConfigBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetStatsConfigBody input)
        {
            if (input == null) return false;
            if (this.ConfigType != input.ConfigType || (this.ConfigType != null && !this.ConfigType.Equals(input.ConfigType))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.ConfigInfo != input.ConfigInfo || (this.ConfigInfo != null && !this.ConfigInfo.Equals(input.ConfigInfo))) return false;
            if (this.ExpiredTime != input.ExpiredTime || (this.ExpiredTime != null && !this.ExpiredTime.Equals(input.ExpiredTime))) return false;

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
                if (this.ConfigType != null) hashCode = hashCode * 59 + this.ConfigType.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ConfigInfo != null) hashCode = hashCode * 59 + this.ConfigInfo.GetHashCode();
                if (this.ExpiredTime != null) hashCode = hashCode * 59 + this.ExpiredTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
