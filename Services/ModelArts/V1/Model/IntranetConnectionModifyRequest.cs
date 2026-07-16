using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// **参数解释：** 修改自定义URL请求体。 **约束限制：** 不涉及。  **取值范围：** 不涉及。  **默认取值：** 不涉及。
    /// </summary>
    public class IntranetConnectionModifyRequest 
    {

        /// <summary>
        /// **参数解释：** 自定义URL，格式为：{协议}://{域名}{路径} **约束限制：** url个数不超过10个，单个url长度不超过1024。 **取值范围：** - 协议范围：http，https，wss，ws。 - 域名范围：支持域名或IP:端口。域名长度不超过63，包含字母、数字、中划线（-)且不能以中划线（-)开头或结尾，顶级域名不能包含数字；端口范围为1-65535。 - 路径范围：斜杠（/）开头，仅包含字母、数字、点号（.）、中划线（-)、下划线（_）、斜杠（/）的路径。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("custom_urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CustomUrls { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntranetConnectionModifyRequest {\n");
            sb.Append("  customUrls: ").Append(CustomUrls).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IntranetConnectionModifyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IntranetConnectionModifyRequest input)
        {
            if (input == null) return false;
            if (this.CustomUrls != input.CustomUrls || (this.CustomUrls != null && input.CustomUrls != null && !this.CustomUrls.SequenceEqual(input.CustomUrls))) return false;

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
                if (this.CustomUrls != null) hashCode = hashCode * 59 + this.CustomUrls.GetHashCode();
                return hashCode;
            }
        }
    }
}
