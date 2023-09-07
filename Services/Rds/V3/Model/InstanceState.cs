using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 实例状态
    /// </summary>
    public class InstanceState 
    {

        /// <summary>
        /// 实例状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 参数变更，是否需要重启
        /// </summary>
        [JsonProperty("wait_restart_for_params", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WaitRestartForParams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceState {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  waitRestartForParams: ").Append(WaitRestartForParams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceState);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceState input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.WaitRestartForParams == input.WaitRestartForParams ||
                    (this.WaitRestartForParams != null &&
                    this.WaitRestartForParams.Equals(input.WaitRestartForParams))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.WaitRestartForParams != null)
                    hashCode = hashCode * 59 + this.WaitRestartForParams.GetHashCode();
                return hashCode;
            }
        }
    }
}
