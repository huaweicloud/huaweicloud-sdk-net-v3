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
        /// **参数解释：** 配置类型 **约束限制：** 不涉及 **取值范围：** - 0：热点统计 - 1：ces上报 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("config_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConfigType { get; set; }

        /// <summary>
        /// **参数解释：** 资源类型 **约束限制：** 不涉及 **取值范围：** - domain：域名，对应resource_name需配置为域名 - account：账号，对应resource_name需配置为账号 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// **参数解释：** 资源名称 &gt; 账号或域名  **约束限制：** 不涉及 **取值范围：** 多个资源名称以英文逗号分隔 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// **参数解释：** 配置信息 **约束限制：** 不涉及 **取值范围：** - ua：HTTP请求头User-Agent的值 - refer：HTTP请求头referer的值 - url：客户访问的http地址 - originurl：回源url **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("config_info", NullValueHandling = NullValueHandling.Ignore)]
        public Object ConfigInfo { get; set; }



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
                return hashCode;
            }
        }
    }
}
