using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 创建对象级对比任务请求。
    /// </summary>
    public class CreateObjectCompareJobReq 
    {

        /// <summary>
        /// 对比任务线程数量，当前仅cloudDataGuard-cassandra和cloudDataGuard-gausscassandra-to-gausscassandra链路支持。
        /// </summary>
        [JsonProperty("compare_task_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompareTaskNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateObjectCompareJobReq {\n");
            sb.Append("  compareTaskNum: ").Append(CompareTaskNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateObjectCompareJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateObjectCompareJobReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompareTaskNum == input.CompareTaskNum ||
                    (this.CompareTaskNum != null &&
                    this.CompareTaskNum.Equals(input.CompareTaskNum))
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
                if (this.CompareTaskNum != null)
                    hashCode = hashCode * 59 + this.CompareTaskNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
