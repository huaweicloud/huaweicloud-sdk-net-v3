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
    public class CreateRSetBatchLinesReq 
    {

        /// <summary>
        /// **参数解释：** 域名，后缀需以zone name结束且为FQDN（Fully Qualified Domain Name，全称域名），即以“.”结束的完整主机名。 如“www.example.com.”。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 记录集的描述信息。 **约束限制：** 不涉及。 **取值范围：** 长度不超过255个字符。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 记录集的类型。 **约束限制：** 不涉及。 **取值范围：** - A：将域名解析到指定的IPv4地址。 - AAAA：将域名解析到指定的IPv6地址。 - MX：指定域名对应的邮件服务器。 - CNAME：将域名解析到另一域名，或者多个域名映射到同一域名上。 - TXT：用于对域名进行标识和说明。 - SRV：用于记录某台服务器对外提供了哪些服务。 - NS：指定域名的权威DNS服务器。 - SOA：提供域名的基本信息和权威服务器的详细信息。 - CAA：指定为域名颁发HTTPS证书的授权CA机构，仅支持公网域名解析。  **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释：** 解析线路域名参数。 **约束限制：** 最多支持50个。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("lines", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchCreateRecordSetWithLine> Lines { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRSetBatchLinesReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  lines: ").Append(Lines).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRSetBatchLinesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRSetBatchLinesReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Lines != input.Lines || (this.Lines != null && input.Lines != null && !this.Lines.SequenceEqual(input.Lines))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Lines != null) hashCode = hashCode * 59 + this.Lines.GetHashCode();
                return hashCode;
            }
        }
    }
}
