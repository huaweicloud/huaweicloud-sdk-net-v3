using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchDeleteAlarmTemplatesResponse : SdkResponse
    {

        /// <summary>
        /// 成功删除的告警模板ID列表
        /// </summary>
        [JsonProperty("template_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TemplateIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteAlarmTemplatesResponse {\n");
            sb.Append("  templateIds: ").Append(TemplateIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteAlarmTemplatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteAlarmTemplatesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateIds == input.TemplateIds ||
                    this.TemplateIds != null &&
                    input.TemplateIds != null &&
                    this.TemplateIds.SequenceEqual(input.TemplateIds)
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
                if (this.TemplateIds != null)
                    hashCode = hashCode * 59 + this.TemplateIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
