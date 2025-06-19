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
    public class ListAllConfigItemByTypeRequestBody 
    {

        /// <summary>
        /// 系统配置，服务自己配置{system、service}
        /// </summary>
        [JsonProperty("configType", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigType { get; set; }

        /// <summary>
        /// 配置类型集合
        /// </summary>
        [JsonProperty("types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Types { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAllConfigItemByTypeRequestBody {\n");
            sb.Append("  configType: ").Append(ConfigType).Append("\n");
            sb.Append("  types: ").Append(Types).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAllConfigItemByTypeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAllConfigItemByTypeRequestBody input)
        {
            if (input == null) return false;
            if (this.ConfigType != input.ConfigType || (this.ConfigType != null && !this.ConfigType.Equals(input.ConfigType))) return false;
            if (this.Types != input.Types || (this.Types != null && input.Types != null && !this.Types.SequenceEqual(input.Types))) return false;

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
                if (this.Types != null) hashCode = hashCode * 59 + this.Types.GetHashCode();
                return hashCode;
            }
        }
    }
}
