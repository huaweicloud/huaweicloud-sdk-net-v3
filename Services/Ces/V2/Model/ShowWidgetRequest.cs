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
    /// Request Object
    /// </summary>
    public class ShowWidgetRequest 
    {

        /// <summary>
        /// **参数解释**: 监控视图id。 **约束限制**: 不涉及。 **取值范围**: 字符串必须以wg开头，包含22个字母和数字，长度为24个字符。 **默认取值**: 不涉及。 
        /// </summary>
        [SDKProperty("widget_id", IsPath = true)]
        [JsonProperty("widget_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WidgetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowWidgetRequest {\n");
            sb.Append("  widgetId: ").Append(WidgetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowWidgetRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowWidgetRequest input)
        {
            if (input == null) return false;
            if (this.WidgetId != input.WidgetId || (this.WidgetId != null && !this.WidgetId.Equals(input.WidgetId))) return false;

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
                if (this.WidgetId != null) hashCode = hashCode * 59 + this.WidgetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
