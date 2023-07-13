using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 命令耗时统计
    /// </summary>
    public class CommandTimeTaken 
    {

        /// <summary>
        /// 调用次数
        /// </summary>
        [JsonProperty("calls_sum", NullValueHandling = NullValueHandling.Ignore)]
        public int? CallsSum { get; set; }

        /// <summary>
        /// 耗时总数
        /// </summary>
        [JsonProperty("usec_sum", NullValueHandling = NullValueHandling.Ignore)]
        public double? UsecSum { get; set; }

        /// <summary>
        /// 命令名称
        /// </summary>
        [JsonProperty("command_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CommandName { get; set; }

        /// <summary>
        /// 耗时占比
        /// </summary>
        [JsonProperty("per_usec", NullValueHandling = NullValueHandling.Ignore)]
        public string PerUsec { get; set; }

        /// <summary>
        /// 每次调用平均耗时
        /// </summary>
        [JsonProperty("average_usec", NullValueHandling = NullValueHandling.Ignore)]
        public double? AverageUsec { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommandTimeTaken {\n");
            sb.Append("  callsSum: ").Append(CallsSum).Append("\n");
            sb.Append("  usecSum: ").Append(UsecSum).Append("\n");
            sb.Append("  commandName: ").Append(CommandName).Append("\n");
            sb.Append("  perUsec: ").Append(PerUsec).Append("\n");
            sb.Append("  averageUsec: ").Append(AverageUsec).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommandTimeTaken);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommandTimeTaken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CallsSum == input.CallsSum ||
                    (this.CallsSum != null &&
                    this.CallsSum.Equals(input.CallsSum))
                ) && 
                (
                    this.UsecSum == input.UsecSum ||
                    (this.UsecSum != null &&
                    this.UsecSum.Equals(input.UsecSum))
                ) && 
                (
                    this.CommandName == input.CommandName ||
                    (this.CommandName != null &&
                    this.CommandName.Equals(input.CommandName))
                ) && 
                (
                    this.PerUsec == input.PerUsec ||
                    (this.PerUsec != null &&
                    this.PerUsec.Equals(input.PerUsec))
                ) && 
                (
                    this.AverageUsec == input.AverageUsec ||
                    (this.AverageUsec != null &&
                    this.AverageUsec.Equals(input.AverageUsec))
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
                if (this.CallsSum != null)
                    hashCode = hashCode * 59 + this.CallsSum.GetHashCode();
                if (this.UsecSum != null)
                    hashCode = hashCode * 59 + this.UsecSum.GetHashCode();
                if (this.CommandName != null)
                    hashCode = hashCode * 59 + this.CommandName.GetHashCode();
                if (this.PerUsec != null)
                    hashCode = hashCode * 59 + this.PerUsec.GetHashCode();
                if (this.AverageUsec != null)
                    hashCode = hashCode * 59 + this.AverageUsec.GetHashCode();
                return hashCode;
            }
        }
    }
}
