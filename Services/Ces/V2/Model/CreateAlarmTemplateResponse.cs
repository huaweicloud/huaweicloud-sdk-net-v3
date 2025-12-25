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
    public class CreateAlarmTemplateResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 告警模板的ID。 **取值范围**： 以at开头，后跟字母、数字，长度为[2,64]个字符。 
        /// </summary>
        [JsonProperty("template_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("overwrite_result", NullValueHandling = NullValueHandling.Ignore)]
        public OverwriteResultResp OverwriteResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAlarmTemplateResponse {\n");
            sb.Append("  templateId: ").Append(TemplateId).Append("\n");
            sb.Append("  overwriteResult: ").Append(OverwriteResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAlarmTemplateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAlarmTemplateResponse input)
        {
            if (input == null) return false;
            if (this.TemplateId != input.TemplateId || (this.TemplateId != null && !this.TemplateId.Equals(input.TemplateId))) return false;
            if (this.OverwriteResult != input.OverwriteResult || (this.OverwriteResult != null && !this.OverwriteResult.Equals(input.OverwriteResult))) return false;

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
                if (this.TemplateId != null) hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.OverwriteResult != null) hashCode = hashCode * 59 + this.OverwriteResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
