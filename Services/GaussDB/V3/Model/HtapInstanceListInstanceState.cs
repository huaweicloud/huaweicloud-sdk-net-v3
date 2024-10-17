using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// HTAP实例状态信息。
    /// </summary>
    public class HtapInstanceListInstanceState 
    {

        /// <summary>
        /// HTAP实例状态。
        /// </summary>
        [JsonProperty("instance_status", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// HTAP实例创建失败错误码。
        /// </summary>
        [JsonProperty("create_fail_error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateFailErrorCode { get; set; }

        /// <summary>
        /// HTAP实例创建失败错误信息。
        /// </summary>
        [JsonProperty("fail_message", NullValueHandling = NullValueHandling.Ignore)]
        public string FailMessage { get; set; }

        /// <summary>
        /// 是否需要重启更新参数。
        /// </summary>
        [JsonProperty("wait_restart_for_params", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WaitRestartForParams { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HtapInstanceListInstanceState {\n");
            sb.Append("  instanceStatus: ").Append(InstanceStatus).Append("\n");
            sb.Append("  createFailErrorCode: ").Append(CreateFailErrorCode).Append("\n");
            sb.Append("  failMessage: ").Append(FailMessage).Append("\n");
            sb.Append("  waitRestartForParams: ").Append(WaitRestartForParams).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HtapInstanceListInstanceState);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HtapInstanceListInstanceState input)
        {
            if (input == null) return false;
            if (this.InstanceStatus != input.InstanceStatus || (this.InstanceStatus != null && !this.InstanceStatus.Equals(input.InstanceStatus))) return false;
            if (this.CreateFailErrorCode != input.CreateFailErrorCode || (this.CreateFailErrorCode != null && !this.CreateFailErrorCode.Equals(input.CreateFailErrorCode))) return false;
            if (this.FailMessage != input.FailMessage || (this.FailMessage != null && !this.FailMessage.Equals(input.FailMessage))) return false;
            if (this.WaitRestartForParams != input.WaitRestartForParams || (this.WaitRestartForParams != null && !this.WaitRestartForParams.Equals(input.WaitRestartForParams))) return false;

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
                if (this.InstanceStatus != null) hashCode = hashCode * 59 + this.InstanceStatus.GetHashCode();
                if (this.CreateFailErrorCode != null) hashCode = hashCode * 59 + this.CreateFailErrorCode.GetHashCode();
                if (this.FailMessage != null) hashCode = hashCode * 59 + this.FailMessage.GetHashCode();
                if (this.WaitRestartForParams != null) hashCode = hashCode * 59 + this.WaitRestartForParams.GetHashCode();
                return hashCode;
            }
        }
    }
}
