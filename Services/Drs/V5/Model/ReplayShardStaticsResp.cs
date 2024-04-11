using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 回放概览信息基于进间点的统计结果
    /// </summary>
    public class ReplayShardStaticsResp 
    {

        /// <summary>
        /// 回放时间点
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// SQL总量
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }

        /// <summary>
        /// SQL执行量
        /// </summary>
        [JsonProperty("finish", NullValueHandling = NullValueHandling.Ignore)]
        public long? Finish { get; set; }

        /// <summary>
        /// SQL异常量
        /// </summary>
        [JsonProperty("abnormal", NullValueHandling = NullValueHandling.Ignore)]
        public long? Abnormal { get; set; }

        /// <summary>
        /// 慢SQL数量
        /// </summary>
        [JsonProperty("slow", NullValueHandling = NullValueHandling.Ignore)]
        public long? Slow { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplayShardStaticsResp {\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  finish: ").Append(Finish).Append("\n");
            sb.Append("  abnormal: ").Append(Abnormal).Append("\n");
            sb.Append("  slow: ").Append(Slow).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplayShardStaticsResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplayShardStaticsResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Finish == input.Finish ||
                    (this.Finish != null &&
                    this.Finish.Equals(input.Finish))
                ) && 
                (
                    this.Abnormal == input.Abnormal ||
                    (this.Abnormal != null &&
                    this.Abnormal.Equals(input.Abnormal))
                ) && 
                (
                    this.Slow == input.Slow ||
                    (this.Slow != null &&
                    this.Slow.Equals(input.Slow))
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Finish != null)
                    hashCode = hashCode * 59 + this.Finish.GetHashCode();
                if (this.Abnormal != null)
                    hashCode = hashCode * 59 + this.Abnormal.GetHashCode();
                if (this.Slow != null)
                    hashCode = hashCode * 59 + this.Slow.GetHashCode();
                return hashCode;
            }
        }
    }
}
