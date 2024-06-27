using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EnvParam 
    {

        /// <summary>
        /// 环境关联组件id；id长度不能超过36位，由大小写字母、数字组成。创建环境必传，修改环境时非必选
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 环境名称
        /// </summary>
        [JsonProperty("env_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvName { get; set; }

        /// <summary>
        /// 环境类型，取值：DEV、TEST、PRE、ONLINE，不区分大小写
        /// </summary>
        [JsonProperty("env_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvType { get; set; }

        /// <summary>
        /// OS类型，取值：LINUX、WINDOWS。创建环境必传，不可修改
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OsType { get; set; }

        /// <summary>
        /// 环境关联region。创建环境必传，不可修改
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 注册类型，取值：API、SERVICE_DISCOVERY、CONSOLE，默认值：API
        /// </summary>
        [JsonProperty("register_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RegisterType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvParam {\n");
            sb.Append("  componentId: ").Append(ComponentId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  envName: ").Append(EnvName).Append("\n");
            sb.Append("  envType: ").Append(EnvType).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  registerType: ").Append(RegisterType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnvParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnvParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ComponentId == input.ComponentId ||
                    (this.ComponentId != null &&
                    this.ComponentId.Equals(input.ComponentId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EnvName == input.EnvName ||
                    (this.EnvName != null &&
                    this.EnvName.Equals(input.EnvName))
                ) && 
                (
                    this.EnvType == input.EnvType ||
                    (this.EnvType != null &&
                    this.EnvType.Equals(input.EnvType))
                ) && 
                (
                    this.OsType == input.OsType ||
                    (this.OsType != null &&
                    this.OsType.Equals(input.OsType))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.RegisterType == input.RegisterType ||
                    (this.RegisterType != null &&
                    this.RegisterType.Equals(input.RegisterType))
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
                if (this.ComponentId != null)
                    hashCode = hashCode * 59 + this.ComponentId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnvName != null)
                    hashCode = hashCode * 59 + this.EnvName.GetHashCode();
                if (this.EnvType != null)
                    hashCode = hashCode * 59 + this.EnvType.GetHashCode();
                if (this.OsType != null)
                    hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.RegisterType != null)
                    hashCode = hashCode * 59 + this.RegisterType.GetHashCode();
                return hashCode;
            }
        }
    }
}
