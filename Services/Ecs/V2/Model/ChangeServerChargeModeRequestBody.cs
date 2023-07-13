using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ChangeServerChargeModeRequestBody 
    {

        /// <summary>
        /// 云服务器ID列表
        /// </summary>
        [JsonProperty("server_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ServerIds { get; set; }

        /// <summary>
        /// 更换后的计费模式：prePaid包周期计费模式
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("prepaid_options", NullValueHandling = NullValueHandling.Ignore)]
        public ChangeServerChargeModePrepaidOption PrepaidOptions { get; set; }

        /// <summary>
        /// 是否预先校验此次请求。 true: 发送检查请求，不触发真正的计费转换操作 false: 发送正常请求，触发计费转换操作。 默认值为false
        /// </summary>
        [JsonProperty("dry_run", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DryRun { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeServerChargeModeRequestBody {\n");
            sb.Append("  serverIds: ").Append(ServerIds).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  prepaidOptions: ").Append(PrepaidOptions).Append("\n");
            sb.Append("  dryRun: ").Append(DryRun).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeServerChargeModeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeServerChargeModeRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServerIds == input.ServerIds ||
                    this.ServerIds != null &&
                    input.ServerIds != null &&
                    this.ServerIds.SequenceEqual(input.ServerIds)
                ) && 
                (
                    this.ChargeMode == input.ChargeMode ||
                    (this.ChargeMode != null &&
                    this.ChargeMode.Equals(input.ChargeMode))
                ) && 
                (
                    this.PrepaidOptions == input.PrepaidOptions ||
                    (this.PrepaidOptions != null &&
                    this.PrepaidOptions.Equals(input.PrepaidOptions))
                ) && 
                (
                    this.DryRun == input.DryRun ||
                    (this.DryRun != null &&
                    this.DryRun.Equals(input.DryRun))
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
                if (this.ServerIds != null)
                    hashCode = hashCode * 59 + this.ServerIds.GetHashCode();
                if (this.ChargeMode != null)
                    hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.PrepaidOptions != null)
                    hashCode = hashCode * 59 + this.PrepaidOptions.GetHashCode();
                if (this.DryRun != null)
                    hashCode = hashCode * 59 + this.DryRun.GetHashCode();
                return hashCode;
            }
        }
    }
}
