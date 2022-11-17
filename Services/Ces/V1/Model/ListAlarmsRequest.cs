using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAlarmsRequest 
    {

        /// <summary>
        /// 取值范围(0,100]，默认值为100  用于限制结果数据条数。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 用于标识结果排序方法。  取值说明，默认值为desc。  asc：升序 desc：降序
        /// </summary>
        [SDKProperty("order", IsQuery = true)]
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public string Order { get; set; }

        /// <summary>
        /// 分页起始值，内容为alarm_id。
        /// </summary>
        [SDKProperty("start", IsQuery = true)]
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public string Start { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAlarmsRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  start: ").Append(Start).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAlarmsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAlarmsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                return hashCode;
            }
        }
    }
}
