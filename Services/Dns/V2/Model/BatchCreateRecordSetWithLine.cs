using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchCreateRecordSetWithLine 
    {

        /// <summary>
        /// 解析线路ID。
        /// </summary>
        [JsonProperty("line", NullValueHandling = NullValueHandling.Ignore)]
        public string Line { get; set; }

        /// <summary>
        /// Record Set的有效缓存时间，以秒为单位。 取值范围：300-2147483647。 默认值为300s。
        /// </summary>
        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? Ttl { get; set; }

        /// <summary>
        /// 解析记录的权重，默认为1。 当weight&#x3D;null时，表示该解析记录不设置权重。 当weight&#x3D;0，表示备用域名解析记录。 当weight&gt;0，表示主用域名解析记录。 取值范围：0~100 在相同域名、类型、线路下的解析记录，规则如下： 全部设置权重，或全部不设置权重。 当不设置权重时，只能创建一个解析记录。 当设置权重时，最多能创建20个解析记录。
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }

        /// <summary>
        /// 解析记录的值。不同类型解析记录对应的值的规则不同。
        /// </summary>
        [JsonProperty("records", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Records { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateRecordSetWithLine {\n");
            sb.Append("  line: ").Append(Line).Append("\n");
            sb.Append("  ttl: ").Append(Ttl).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("  records: ").Append(Records).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateRecordSetWithLine);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateRecordSetWithLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Line == input.Line ||
                    (this.Line != null &&
                    this.Line.Equals(input.Line))
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    (this.Ttl != null &&
                    this.Ttl.Equals(input.Ttl))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
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
                if (this.Line != null)
                    hashCode = hashCode * 59 + this.Line.GetHashCode();
                if (this.Ttl != null)
                    hashCode = hashCode * 59 + this.Ttl.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.Records != null)
                    hashCode = hashCode * 59 + this.Records.GetHashCode();
                return hashCode;
            }
        }
    }
}
