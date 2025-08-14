using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListApplicationTemplatesResponse : SdkResponse
    {

        /// <summary>
        /// 应用程序模板列表
        /// </summary>
        [JsonProperty("application_templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApplicationTemplateDto> ApplicationTemplates { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListApplicationTemplatesResponse {\n");
            sb.Append("  applicationTemplates: ").Append(ApplicationTemplates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListApplicationTemplatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListApplicationTemplatesResponse input)
        {
            if (input == null) return false;
            if (this.ApplicationTemplates != input.ApplicationTemplates || (this.ApplicationTemplates != null && input.ApplicationTemplates != null && !this.ApplicationTemplates.SequenceEqual(input.ApplicationTemplates))) return false;

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
                if (this.ApplicationTemplates != null) hashCode = hashCode * 59 + this.ApplicationTemplates.GetHashCode();
                return hashCode;
            }
        }
    }
}
