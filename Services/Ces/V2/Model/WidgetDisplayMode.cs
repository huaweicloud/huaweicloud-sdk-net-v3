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
    public class WidgetDisplayMode 
    {

        /// <summary>
        /// 监控视图展示模式，0表示自定义坐标，1代表每行一个
        /// </summary>
        [JsonProperty("row_widget_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? RowWidgetNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WidgetDisplayMode {\n");
            sb.Append("  rowWidgetNum: ").Append(RowWidgetNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WidgetDisplayMode);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WidgetDisplayMode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RowWidgetNum == input.RowWidgetNum ||
                    (this.RowWidgetNum != null &&
                    this.RowWidgetNum.Equals(input.RowWidgetNum))
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
                if (this.RowWidgetNum != null)
                    hashCode = hashCode * 59 + this.RowWidgetNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
