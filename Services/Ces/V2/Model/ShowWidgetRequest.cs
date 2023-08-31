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
        /// 监控视图id
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
            if (input == null)
                return false;

            return 
                (
                    this.WidgetId == input.WidgetId ||
                    (this.WidgetId != null &&
                    this.WidgetId.Equals(input.WidgetId))
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
                if (this.WidgetId != null)
                    hashCode = hashCode * 59 + this.WidgetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
