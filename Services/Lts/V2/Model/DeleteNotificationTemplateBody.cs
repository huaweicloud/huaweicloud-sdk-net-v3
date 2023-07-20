using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 删除通知模板参数体
    /// </summary>
    public class DeleteNotificationTemplateBody 
    {

        /// <summary>
        /// 待删除模板名称数组
        /// </summary>
        [JsonProperty("template_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TemplateNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteNotificationTemplateBody {\n");
            sb.Append("  templateNames: ").Append(TemplateNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteNotificationTemplateBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteNotificationTemplateBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateNames == input.TemplateNames ||
                    this.TemplateNames != null &&
                    input.TemplateNames != null &&
                    this.TemplateNames.SequenceEqual(input.TemplateNames)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TemplateNames != null)
                    hashCode = hashCode * 59 + this.TemplateNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
