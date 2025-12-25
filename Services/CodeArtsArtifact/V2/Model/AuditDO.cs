using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AuditDO 
    {

        /// <summary>
        /// **参数解释**： 操作ID。  **取值范围**： 不涉及。id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 操作模块。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("module", NullValueHandling = NullValueHandling.Ignore)]
        public string Module { get; set; }

        /// <summary>
        /// **参数解释**： 操作类型。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public string Operation { get; set; }

        /// <summary>
        /// **参数解释**： 操作时间。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// **参数解释**： 操作信息。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        public string Info { get; set; }

        /// <summary>
        /// **参数解释**： 操作数据。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        /// <summary>
        /// **参数解释**： 原因。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// **参数解释**： 操作人客户端类型。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("userAgent", NullValueHandling = NullValueHandling.Ignore)]
        public string UserAgent { get; set; }

        /// <summary>
        /// **参数解释**： 操作人。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public string Operator { get; set; }

        /// <summary>
        /// **参数解释**： 操作人名字。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("operatorNickName", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorNickName { get; set; }

        /// <summary>
        /// **参数解释**： 操作人租户名。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("operatorTenantName", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorTenantName { get; set; }

        /// <summary>
        /// **参数解释**： 操作人IP地址。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("ipSource", NullValueHandling = NullValueHandling.Ignore)]
        public string IpSource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditDO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  module: ").Append(Module).Append("\n");
            sb.Append("  operation: ").Append(Operation).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  info: ").Append(Info).Append("\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  userAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  operatorNickName: ").Append(OperatorNickName).Append("\n");
            sb.Append("  operatorTenantName: ").Append(OperatorTenantName).Append("\n");
            sb.Append("  ipSource: ").Append(IpSource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuditDO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuditDO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Module != input.Module || (this.Module != null && !this.Module.Equals(input.Module))) return false;
            if (this.Operation != input.Operation || (this.Operation != null && !this.Operation.Equals(input.Operation))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.Info != input.Info || (this.Info != null && !this.Info.Equals(input.Info))) return false;
            if (this.Data != input.Data || (this.Data != null && !this.Data.Equals(input.Data))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.UserAgent != input.UserAgent || (this.UserAgent != null && !this.UserAgent.Equals(input.UserAgent))) return false;
            if (this.Operator != input.Operator || (this.Operator != null && !this.Operator.Equals(input.Operator))) return false;
            if (this.OperatorNickName != input.OperatorNickName || (this.OperatorNickName != null && !this.OperatorNickName.Equals(input.OperatorNickName))) return false;
            if (this.OperatorTenantName != input.OperatorTenantName || (this.OperatorTenantName != null && !this.OperatorTenantName.Equals(input.OperatorTenantName))) return false;
            if (this.IpSource != input.IpSource || (this.IpSource != null && !this.IpSource.Equals(input.IpSource))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Module != null) hashCode = hashCode * 59 + this.Module.GetHashCode();
                if (this.Operation != null) hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Info != null) hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.UserAgent != null) hashCode = hashCode * 59 + this.UserAgent.GetHashCode();
                if (this.Operator != null) hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.OperatorNickName != null) hashCode = hashCode * 59 + this.OperatorNickName.GetHashCode();
                if (this.OperatorTenantName != null) hashCode = hashCode * 59 + this.OperatorTenantName.GetHashCode();
                if (this.IpSource != null) hashCode = hashCode * 59 + this.IpSource.GetHashCode();
                return hashCode;
            }
        }
    }
}
