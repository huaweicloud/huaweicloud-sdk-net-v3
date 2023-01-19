using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 复制记录额外信息
    /// </summary>
    public class ReplicationRecordsExtraInfo 
    {

        /// <summary>
        /// 复制进度
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public int? Progress { get; set; }

        /// <summary>
        /// 失败错误码，成功时为空
        /// </summary>
        [JsonProperty("fail_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FailCode { get; set; }

        /// <summary>
        /// 错误原因
        /// </summary>
        [JsonProperty("fail_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailReason { get; set; }

        /// <summary>
        /// 是否为自动调度复制
        /// </summary>
        [JsonProperty("auto_trigger", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoTrigger { get; set; }

        /// <summary>
        /// 目标端的存储库id
        /// </summary>
        [JsonProperty("destinatio_vault_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinatioVaultId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplicationRecordsExtraInfo {\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  failCode: ").Append(FailCode).Append("\n");
            sb.Append("  failReason: ").Append(FailReason).Append("\n");
            sb.Append("  autoTrigger: ").Append(AutoTrigger).Append("\n");
            sb.Append("  destinatioVaultId: ").Append(DestinatioVaultId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReplicationRecordsExtraInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReplicationRecordsExtraInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
                ) && 
                (
                    this.FailCode == input.FailCode ||
                    (this.FailCode != null &&
                    this.FailCode.Equals(input.FailCode))
                ) && 
                (
                    this.FailReason == input.FailReason ||
                    (this.FailReason != null &&
                    this.FailReason.Equals(input.FailReason))
                ) && 
                (
                    this.AutoTrigger == input.AutoTrigger ||
                    (this.AutoTrigger != null &&
                    this.AutoTrigger.Equals(input.AutoTrigger))
                ) && 
                (
                    this.DestinatioVaultId == input.DestinatioVaultId ||
                    (this.DestinatioVaultId != null &&
                    this.DestinatioVaultId.Equals(input.DestinatioVaultId))
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
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.FailCode != null)
                    hashCode = hashCode * 59 + this.FailCode.GetHashCode();
                if (this.FailReason != null)
                    hashCode = hashCode * 59 + this.FailReason.GetHashCode();
                if (this.AutoTrigger != null)
                    hashCode = hashCode * 59 + this.AutoTrigger.GetHashCode();
                if (this.DestinatioVaultId != null)
                    hashCode = hashCode * 59 + this.DestinatioVaultId.GetHashCode();
                return hashCode;
            }
        }
    }
}
