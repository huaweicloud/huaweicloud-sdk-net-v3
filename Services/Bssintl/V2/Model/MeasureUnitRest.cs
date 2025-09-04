using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MeasureUnitRest 
    {

        /// <summary>
        /// 度量单位ID。 例如：10表示GB。
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 度量单位的名称，根据查询的语言类型返回结果。 例如：GB。
        /// </summary>
        [JsonProperty("measure_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MeasureName { get; set; }

        /// <summary>
        /// 度量单位名称的英文缩写。 例如：度量单位名称“GB”的英文缩写为“GB”。
        /// </summary>
        [JsonProperty("abbreviation", NullValueHandling = NullValueHandling.Ignore)]
        public string Abbreviation { get; set; }

        /// <summary>
        /// 度量类型。 1：货币2：时长3：流量4：数量7：容量9：行数10：周期11：频率12：个数16：带宽速率17：容量时长18：查询速率19：带宽速率（1000进制）20：性能测试用量21：面积22：视频23：吞吐量25：测试类型
        /// </summary>
        [JsonProperty("measure_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MeasureUnitRest {\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  measureName: ").Append(MeasureName).Append("\n");
            sb.Append("  abbreviation: ").Append(Abbreviation).Append("\n");
            sb.Append("  measureType: ").Append(MeasureType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MeasureUnitRest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MeasureUnitRest input)
        {
            if (input == null) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.MeasureName != input.MeasureName || (this.MeasureName != null && !this.MeasureName.Equals(input.MeasureName))) return false;
            if (this.Abbreviation != input.Abbreviation || (this.Abbreviation != null && !this.Abbreviation.Equals(input.Abbreviation))) return false;
            if (this.MeasureType != input.MeasureType || (this.MeasureType != null && !this.MeasureType.Equals(input.MeasureType))) return false;

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
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.MeasureName != null) hashCode = hashCode * 59 + this.MeasureName.GetHashCode();
                if (this.Abbreviation != null) hashCode = hashCode * 59 + this.Abbreviation.GetHashCode();
                if (this.MeasureType != null) hashCode = hashCode * 59 + this.MeasureType.GetHashCode();
                return hashCode;
            }
        }
    }
}
