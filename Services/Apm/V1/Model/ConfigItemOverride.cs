using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 实际生效值
    /// </summary>
    public class ConfigItemOverride 
    {

        /// <summary>
        /// 环境标签ID
        /// </summary>
        [JsonProperty("env_tag_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnvTagId { get; set; }

        /// <summary>
        /// 环境标签名
        /// </summary>
        [JsonProperty("env_tag_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvTagName { get; set; }

        /// <summary>
        /// 键
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigItemOverride {\n");
            sb.Append("  envTagId: ").Append(EnvTagId).Append("\n");
            sb.Append("  envTagName: ").Append(EnvTagName).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigItemOverride);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigItemOverride input)
        {
            if (input == null) return false;
            if (this.EnvTagId != input.EnvTagId || (this.EnvTagId != null && !this.EnvTagId.Equals(input.EnvTagId))) return false;
            if (this.EnvTagName != input.EnvTagName || (this.EnvTagName != null && !this.EnvTagName.Equals(input.EnvTagName))) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

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
                if (this.EnvTagId != null) hashCode = hashCode * 59 + this.EnvTagId.GetHashCode();
                if (this.EnvTagName != null) hashCode = hashCode * 59 + this.EnvTagName.GetHashCode();
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
