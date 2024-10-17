using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CommandInfo 
    {

        /// <summary>
        /// 原高危命令，当前支持的有：keys、flushdb、flushall、hgetall、hkeys、hvals、smembers
        /// </summary>
        [JsonProperty("origin_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginName { get; set; }

        /// <summary>
        /// 当前生效的命令名称，当为空时表示命令禁用，允许修改为30个字符以内数字、字母和下划线的组合
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommandInfo {\n");
            sb.Append("  originName: ").Append(OriginName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommandInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommandInfo input)
        {
            if (input == null) return false;
            if (this.OriginName != input.OriginName || (this.OriginName != null && !this.OriginName.Equals(input.OriginName))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;

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
                if (this.OriginName != null) hashCode = hashCode * 59 + this.OriginName.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
