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
    /// Request Object
    /// </summary>
    public class ListAutopilotAddonTemplatesRequest 
    {

        /// <summary>
        /// 指定的插件名称或插件别名，不填写则查询列表。
        /// </summary>
        [SDKProperty("addon_template_name", IsQuery = true)]
        [JsonProperty("addon_template_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonTemplateName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAutopilotAddonTemplatesRequest {\n");
            sb.Append("  addonTemplateName: ").Append(AddonTemplateName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAutopilotAddonTemplatesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAutopilotAddonTemplatesRequest input)
        {
            if (input == null) return false;
            if (this.AddonTemplateName != input.AddonTemplateName || (this.AddonTemplateName != null && !this.AddonTemplateName.Equals(input.AddonTemplateName))) return false;

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
                if (this.AddonTemplateName != null) hashCode = hashCode * 59 + this.AddonTemplateName.GetHashCode();
                return hashCode;
            }
        }
    }
}
