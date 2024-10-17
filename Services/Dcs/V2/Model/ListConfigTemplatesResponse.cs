using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListConfigTemplatesResponse : SdkResponse
    {

        /// <summary>
        /// 模板个数。
        /// </summary>
        [JsonProperty("template_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TemplateNum { get; set; }

        /// <summary>
        /// 模板的详情数组。
        /// </summary>
        [JsonProperty("templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConfigTemplatesListInfo> Templates { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListConfigTemplatesResponse {\n");
            sb.Append("  templateNum: ").Append(TemplateNum).Append("\n");
            sb.Append("  templates: ").Append(Templates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListConfigTemplatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListConfigTemplatesResponse input)
        {
            if (input == null) return false;
            if (this.TemplateNum != input.TemplateNum || (this.TemplateNum != null && !this.TemplateNum.Equals(input.TemplateNum))) return false;
            if (this.Templates != input.Templates || (this.Templates != null && input.Templates != null && !this.Templates.SequenceEqual(input.Templates))) return false;

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
                if (this.TemplateNum != null) hashCode = hashCode * 59 + this.TemplateNum.GetHashCode();
                if (this.Templates != null) hashCode = hashCode * 59 + this.Templates.GetHashCode();
                return hashCode;
            }
        }
    }
}
