using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 趋势图数据模型。
    /// </summary>
    public class FrontLine 
    {

        /// <summary>
        /// 数据点集合。
        /// </summary>
        [JsonProperty("point_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<FrontPoint> PointList { get; set; }

        /// <summary>
        /// 标题。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 单位。
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// 百分比。
        /// </summary>
        [JsonProperty("precision", NullValueHandling = NullValueHandling.Ignore)]
        public int? Precision { get; set; }

        /// <summary>
        /// 日期类型。
        /// </summary>
        [JsonProperty("data_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DataType { get; set; }

        /// <summary>
        /// 是否可见。
        /// </summary>
        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FrontLine {\n");
            sb.Append("  pointList: ").Append(PointList).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  precision: ").Append(Precision).Append("\n");
            sb.Append("  dataType: ").Append(DataType).Append("\n");
            sb.Append("  visible: ").Append(Visible).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FrontLine);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FrontLine input)
        {
            if (input == null) return false;
            if (this.PointList != input.PointList || (this.PointList != null && input.PointList != null && !this.PointList.SequenceEqual(input.PointList))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;
            if (this.Precision != input.Precision || (this.Precision != null && !this.Precision.Equals(input.Precision))) return false;
            if (this.DataType != input.DataType || (this.DataType != null && !this.DataType.Equals(input.DataType))) return false;
            if (this.Visible != input.Visible || (this.Visible != null && !this.Visible.Equals(input.Visible))) return false;

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
                if (this.PointList != null) hashCode = hashCode * 59 + this.PointList.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Precision != null) hashCode = hashCode * 59 + this.Precision.GetHashCode();
                if (this.DataType != null) hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.Visible != null) hashCode = hashCode * 59 + this.Visible.GetHashCode();
                return hashCode;
            }
        }
    }
}
