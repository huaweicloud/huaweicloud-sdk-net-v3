using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateCustomLineRequestBody 
    {

        /// <summary>
        /// 解析线路名称。  长度限制为1-80个字符，只允许包含中文、字母、数字、&#39;-&#39;、&#39;_&#39;、&#39;.&#39;字符。  租户内，解析线路名称是唯一的。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// IP地址段。  以“-”分隔，小IP地址在前，大IP地址在后。IP段之间不能有交叉。当只有一个IP时，填写IP1-IP1。 目前只支持IPV4。  最多支持50个。
        /// </summary>
        [JsonProperty("ip_segments", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpSegments { get; set; }

        /// <summary>
        /// 自定义线路的描述信息。长度不超过255个字符。  默认值为空。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCustomLineRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  ipSegments: ").Append(IpSegments).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateCustomLineRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateCustomLineRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.IpSegments != input.IpSegments || (this.IpSegments != null && input.IpSegments != null && !this.IpSegments.SequenceEqual(input.IpSegments))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IpSegments != null) hashCode = hashCode * 59 + this.IpSegments.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
