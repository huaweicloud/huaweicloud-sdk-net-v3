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
    public class ListDashboardWidgetsResponse : SdkResponse
    {

        /// <summary>
        /// 监控视图列表
        /// </summary>
        [JsonProperty("widgets", NullValueHandling = NullValueHandling.Ignore)]
        public List<WidgetInfoWithId> Widgets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDashboardWidgetsResponse {\n");
            sb.Append("  widgets: ").Append(Widgets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDashboardWidgetsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDashboardWidgetsResponse input)
        {
            if (input == null) return false;
            if (this.Widgets != input.Widgets || (this.Widgets != null && input.Widgets != null && !this.Widgets.SequenceEqual(input.Widgets))) return false;

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
                if (this.Widgets != null) hashCode = hashCode * 59 + this.Widgets.GetHashCode();
                return hashCode;
            }
        }
    }
}
