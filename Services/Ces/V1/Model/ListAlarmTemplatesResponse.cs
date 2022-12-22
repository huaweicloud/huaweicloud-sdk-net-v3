using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAlarmTemplatesResponse : SdkResponse
    {

        /// <summary>
        /// 自定义告警模板详细信息。
        /// </summary>
        [JsonProperty("alarm_templates", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmTemplate> AlarmTemplates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("meta_data", NullValueHandling = NullValueHandling.Ignore)]
        public MetaData MetaData { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAlarmTemplatesResponse {\n");
            sb.Append("  alarmTemplates: ").Append(AlarmTemplates).Append("\n");
            sb.Append("  metaData: ").Append(MetaData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAlarmTemplatesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAlarmTemplatesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlarmTemplates == input.AlarmTemplates ||
                    this.AlarmTemplates != null &&
                    input.AlarmTemplates != null &&
                    this.AlarmTemplates.SequenceEqual(input.AlarmTemplates)
                ) && 
                (
                    this.MetaData == input.MetaData ||
                    (this.MetaData != null &&
                    this.MetaData.Equals(input.MetaData))
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
                if (this.AlarmTemplates != null)
                    hashCode = hashCode * 59 + this.AlarmTemplates.GetHashCode();
                if (this.MetaData != null)
                    hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                return hashCode;
            }
        }
    }
}
