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
    /// 定时配置
    /// </summary>
    public class CronConfig 
    {

        /// <summary>
        /// 定时配置名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 定时表达式
        /// </summary>
        [JsonProperty("cron", NullValueHandling = NullValueHandling.Ignore)]
        public string Cron { get; set; }

        /// <summary>
        /// 拉起预留实例个数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 开始时间戳
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 失效时间戳
        /// </summary>
        [JsonProperty("expired_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpiredTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CronConfig {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  cron: ").Append(Cron).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  expiredTime: ").Append(ExpiredTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CronConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CronConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Cron == input.Cron ||
                    (this.Cron != null &&
                    this.Cron.Equals(input.Cron))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.ExpiredTime == input.ExpiredTime ||
                    (this.ExpiredTime != null &&
                    this.ExpiredTime.Equals(input.ExpiredTime))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Cron != null)
                    hashCode = hashCode * 59 + this.Cron.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.ExpiredTime != null)
                    hashCode = hashCode * 59 + this.ExpiredTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
