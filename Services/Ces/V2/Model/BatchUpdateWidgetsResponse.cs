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
    public class BatchUpdateWidgetsResponse : SdkResponse
    {

        /// <summary>
        /// 更新结果列表
        /// </summary>
        [JsonProperty("widgets", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchUpdateWidgetInfo> Widgets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateWidgetsResponse {\n");
            sb.Append("  widgets: ").Append(Widgets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateWidgetsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateWidgetsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Widgets == input.Widgets ||
                    this.Widgets != null &&
                    input.Widgets != null &&
                    this.Widgets.SequenceEqual(input.Widgets)
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
                if (this.Widgets != null)
                    hashCode = hashCode * 59 + this.Widgets.GetHashCode();
                return hashCode;
            }
        }
    }
}
