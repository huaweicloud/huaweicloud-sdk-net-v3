using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AddReadonlyNodeRequestBody 
    {

        /// <summary>
        /// 资源规格编码。获取方法请参见[查询数据库规格](x-wc://file&#x3D;zh-cn_topic_0000001321087266.xml)中参数“spec_code”的值。  示例：dds.mongodb.c6.xlarge.2.shard
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 待新增只读节点个数。 取值范围：1-5。
        /// </summary>
        [JsonProperty("num", NullValueHandling = NullValueHandling.Ignore)]
        public string Num { get; set; }

        /// <summary>
        /// 同步延迟时间。取值范围：0~1200毫秒。默认取值为0。
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public int? Delay { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddReadonlyNodeRequestBody {\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  num: ").Append(Num).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddReadonlyNodeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddReadonlyNodeRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
                ) && 
                (
                    this.Num == input.Num ||
                    (this.Num != null &&
                    this.Num.Equals(input.Num))
                ) && 
                (
                    this.Delay == input.Delay ||
                    (this.Delay != null &&
                    this.Delay.Equals(input.Delay))
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
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.Num != null)
                    hashCode = hashCode * 59 + this.Num.GetHashCode();
                if (this.Delay != null)
                    hashCode = hashCode * 59 + this.Delay.GetHashCode();
                return hashCode;
            }
        }
    }
}
