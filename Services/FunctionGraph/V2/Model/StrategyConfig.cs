using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// 函数策略配置。
    /// </summary>
    public class StrategyConfig 
    {

        /// <summary>
        /// 单函数最大实例数，v1取值0和-1，v2取值-1到1000 -1代表该函数实例数无限制 0代表该函数被禁用
        /// </summary>
        [JsonProperty("concurrency", NullValueHandling = NullValueHandling.Ignore)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// 单实例最大并发数，v2版本才支持，取值-1到200000
        /// </summary>
        [JsonProperty("concurrent_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConcurrentNum { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StrategyConfig {\n");
            sb.Append("  concurrency: ").Append(Concurrency).Append("\n");
            sb.Append("  concurrentNum: ").Append(ConcurrentNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StrategyConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StrategyConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Concurrency == input.Concurrency ||
                    (this.Concurrency != null &&
                    this.Concurrency.Equals(input.Concurrency))
                ) && 
                (
                    this.ConcurrentNum == input.ConcurrentNum ||
                    (this.ConcurrentNum != null &&
                    this.ConcurrentNum.Equals(input.ConcurrentNum))
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
                if (this.Concurrency != null)
                    hashCode = hashCode * 59 + this.Concurrency.GetHashCode();
                if (this.ConcurrentNum != null)
                    hashCode = hashCode * 59 + this.ConcurrentNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
