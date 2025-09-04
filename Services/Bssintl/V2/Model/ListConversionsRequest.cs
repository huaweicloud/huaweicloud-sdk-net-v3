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
    /// Request Object
    /// </summary>
    public class ListConversionsRequest 
    {

        /// <summary>
        /// 语言，字段预留。默认zh_CN，枚举：zh_CN：中文 en_US：英文
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 度量类型。1：货币 2：时长 3：流量 4：数量 7：容量 9：行数 10：周期 11：频率 12：个数 16：带宽速率 19：带宽速率（1000进制） 20：性能测试用量 27：核数*时长 28：内存*时长 29：IOPS*时长 30：吞吐量*时长 31：个/时长 40：流量（1000进制） 41：1K Tokens 108：数量*时长。此参数不携带或携带值为空或携带值为null时，不作为筛选条件；不支持携带值为空串。
        /// </summary>
        [SDKProperty("measure_type", IsQuery = true)]
        [JsonProperty("measure_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListConversionsRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  measureType: ").Append(MeasureType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListConversionsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListConversionsRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
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
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.MeasureType != null) hashCode = hashCode * 59 + this.MeasureType.GetHashCode();
                return hashCode;
            }
        }
    }
}
