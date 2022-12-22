using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpgradeAddonConfig 
    {

        /// <summary>
        /// 插件名称
        /// </summary>
        [JsonProperty("addonTemplateName", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonTemplateName { get; set; }

        /// <summary>
        /// 执行动作，当前升级场景支持操作为\&quot;patch\&quot;
        /// </summary>
        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public string Operation { get; set; }

        /// <summary>
        /// 目标插件版本号
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 插件参数列表，Key:Value格式
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public Object Values { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpgradeAddonConfig {\n");
            sb.Append("  addonTemplateName: ").Append(AddonTemplateName).Append("\n");
            sb.Append("  operation: ").Append(Operation).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpgradeAddonConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpgradeAddonConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddonTemplateName == input.AddonTemplateName ||
                    (this.AddonTemplateName != null &&
                    this.AddonTemplateName.Equals(input.AddonTemplateName))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Values == input.Values ||
                    (this.Values != null &&
                    this.Values.Equals(input.Values))
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
                if (this.AddonTemplateName != null)
                    hashCode = hashCode * 59 + this.AddonTemplateName.GetHashCode();
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                return hashCode;
            }
        }
    }
}
