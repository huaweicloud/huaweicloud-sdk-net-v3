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
    /// 
    /// </summary>
    public class BatchDeleteAlarmTemplatesRequestBody 
    {

        /// <summary>
        /// 需要批量删除的告警模板的ID列表。未关联告警规则的模板可以批量删除多个；已关联告警规则的告警模板模板单次只允许删除一个，若同时删除多个已关联告警规则的告警模板，将返回异常
        /// </summary>
        [JsonProperty("template_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TemplateIds { get; set; }

        /// <summary>
        /// 如果告警模板关联了告警规则，是否级联删除告警规则，true代表级联删除，false代表只删除告警模板
        /// </summary>
        [JsonProperty("delete_associate_alarm", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteAssociateAlarm { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteAlarmTemplatesRequestBody {\n");
            sb.Append("  templateIds: ").Append(TemplateIds).Append("\n");
            sb.Append("  deleteAssociateAlarm: ").Append(DeleteAssociateAlarm).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteAlarmTemplatesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteAlarmTemplatesRequestBody input)
        {
            if (input == null) return false;
            if (this.TemplateIds != input.TemplateIds || (this.TemplateIds != null && input.TemplateIds != null && !this.TemplateIds.SequenceEqual(input.TemplateIds))) return false;
            if (this.DeleteAssociateAlarm != input.DeleteAssociateAlarm || (this.DeleteAssociateAlarm != null && !this.DeleteAssociateAlarm.Equals(input.DeleteAssociateAlarm))) return false;

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
                if (this.TemplateIds != null) hashCode = hashCode * 59 + this.TemplateIds.GetHashCode();
                if (this.DeleteAssociateAlarm != null) hashCode = hashCode * 59 + this.DeleteAssociateAlarm.GetHashCode();
                return hashCode;
            }
        }
    }
}
