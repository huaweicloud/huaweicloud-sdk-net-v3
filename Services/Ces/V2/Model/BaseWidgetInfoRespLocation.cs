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
    /// **参数解释** 监控视图图表坐标              **取值范围** 不涉及 
    /// </summary>
    public class BaseWidgetInfoRespLocation 
    {

        /// <summary>
        /// **参数解释** 监控视图的上坐标              **取值范围** 最小值为0，最大值为2147483647 
        /// </summary>
        [JsonProperty("top", NullValueHandling = NullValueHandling.Ignore)]
        public int? Top { get; set; }

        /// <summary>
        /// **参数解释** 监控视图的左坐标              **取值范围** 最小值为0，最大值为9 
        /// </summary>
        [JsonProperty("left", NullValueHandling = NullValueHandling.Ignore)]
        public int? Left { get; set; }

        /// <summary>
        /// **参数解释** 监控视图图表宽度               **取值范围** 最小值为3，最大值为12 
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// **参数解释** 监控视图图表高度             **取值范围** 最小值为3，最大值为2147483647 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseWidgetInfoRespLocation {\n");
            sb.Append("  top: ").Append(Top).Append("\n");
            sb.Append("  left: ").Append(Left).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BaseWidgetInfoRespLocation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BaseWidgetInfoRespLocation input)
        {
            if (input == null) return false;
            if (this.Top != input.Top || (this.Top != null && !this.Top.Equals(input.Top))) return false;
            if (this.Left != input.Left || (this.Left != null && !this.Left.Equals(input.Left))) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;

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
                if (this.Top != null) hashCode = hashCode * 59 + this.Top.GetHashCode();
                if (this.Left != null) hashCode = hashCode * 59 + this.Left.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                return hashCode;
            }
        }
    }
}
