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
    public class WidgetIdItem 
    {

        /// <summary>
        /// **参数解释** 视图id **取值范围** 字符串必须以wg开头，后跟22个字母和数字，总长度为24个字符 
        /// </summary>
        [JsonProperty("widget_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WidgetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WidgetIdItem {\n");
            sb.Append("  widgetId: ").Append(WidgetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WidgetIdItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WidgetIdItem input)
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
