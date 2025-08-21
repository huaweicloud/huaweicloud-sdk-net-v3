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
    /// Request Object
    /// </summary>
    public class DeleteDomainTemplateRequest 
    {

        /// <summary>
        /// **参数解释：** 域名模板ID，可以通过查询域名模板列表接口获取 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("tml_id", IsPath = true)]
        [JsonProperty("tml_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TmlId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteDomainTemplateRequest {\n");
            sb.Append("  tmlId: ").Append(TmlId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteDomainTemplateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteDomainTemplateRequest input)
        {
            if (input == null) return false;
            if (this.TmlId != input.TmlId || (this.TmlId != null && !this.TmlId.Equals(input.TmlId))) return false;

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
                if (this.TmlId != null) hashCode = hashCode * 59 + this.TmlId.GetHashCode();
                return hashCode;
            }
        }
    }
}
