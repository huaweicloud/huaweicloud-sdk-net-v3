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
    public class Conversion 
    {

        /// <summary>
        /// 度量单位ID。 例如：10表示GB。
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 转换后的度量单位ID。 例如：11表示MB。
        /// </summary>
        [JsonProperty("ref_measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RefMeasureId { get; set; }

        /// <summary>
        /// 度量单位和转换后的度量单位之间的转换比率。 例如： 度量单位为GB，转换度量单位为MB时，转换比率为1024，两者之间的转换公式为：1GB&#x3D;1024MB。
        /// </summary>
        [JsonProperty("conversion_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public long? ConversionRatio { get; set; }

        /// <summary>
        /// 度量类型。1：货币 2：时长 3：流量 4：数量 7：容量 9：行数 10：周期 11：频率 12：个数 16：带宽速率 19：带宽速率（1000进制） 20：性能测试用量 27：核数*时长 28：内存*时长 29：IOPS*时长 30：吞吐量*时长 31：个/时长 40：流量（1000进制） 41：1K Tokens 108：数量*时长。
        /// </summary>
        [JsonProperty("measure_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Conversion {\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  refMeasureId: ").Append(RefMeasureId).Append("\n");
            sb.Append("  conversionRatio: ").Append(ConversionRatio).Append("\n");
            sb.Append("  measureType: ").Append(MeasureType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Conversion);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Conversion input)
        {
            if (input == null) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.RefMeasureId != input.RefMeasureId || (this.RefMeasureId != null && !this.RefMeasureId.Equals(input.RefMeasureId))) return false;
            if (this.ConversionRatio != input.ConversionRatio || (this.ConversionRatio != null && !this.ConversionRatio.Equals(input.ConversionRatio))) return false;
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
                if (this.RefMeasureId != null) hashCode = hashCode * 59 + this.RefMeasureId.GetHashCode();
                if (this.ConversionRatio != null) hashCode = hashCode * 59 + this.ConversionRatio.GetHashCode();
                if (this.MeasureType != null) hashCode = hashCode * 59 + this.MeasureType.GetHashCode();
                return hashCode;
            }
        }
    }
}
