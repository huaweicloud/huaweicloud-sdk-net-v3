using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// **参数解释**: 查询事务筛选条件。 **约束限制**: 不涉及。
    /// </summary>
    public class ListTransactionRequestBodyTransactionQueryInfo 
    {

        /// <summary>
        /// **参数解释**: 事务执行时长，单位：秒。 **约束限制**: 不涉及。 **取值范围**: 非负整数。 **默认取值**: 0
        /// </summary>
        [JsonProperty("exec_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecTime { get; set; }

        /// <summary>
        /// **参数解释**: 事务xlog日志大小：单位byte。 **约束限制**: 不涉及。 **取值范围**: 非负整数。 **默认取值**: 0
        /// </summary>
        [JsonProperty("xlog_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string XlogQuantity { get; set; }

        /// <summary>
        /// **参数解释**: 数据库名。 **约束限制**: 不涉及。
        /// </summary>
        [JsonProperty("datnames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Datnames { get; set; }

        /// <summary>
        /// **参数解释**: 用户名。 **约束限制**: 不涉及。
        /// </summary>
        [JsonProperty("usenames", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Usenames { get; set; }

        /// <summary>
        /// **参数解释**: 用户发起事务请求的客户端地址。 **约束限制**: 不涉及。
        /// </summary>
        [JsonProperty("client_addrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ClientAddrs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTransactionRequestBodyTransactionQueryInfo {\n");
            sb.Append("  execTime: ").Append(ExecTime).Append("\n");
            sb.Append("  xlogQuantity: ").Append(XlogQuantity).Append("\n");
            sb.Append("  datnames: ").Append(Datnames).Append("\n");
            sb.Append("  usenames: ").Append(Usenames).Append("\n");
            sb.Append("  clientAddrs: ").Append(ClientAddrs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTransactionRequestBodyTransactionQueryInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTransactionRequestBodyTransactionQueryInfo input)
        {
            if (input == null) return false;
            if (this.ExecTime != input.ExecTime || (this.ExecTime != null && !this.ExecTime.Equals(input.ExecTime))) return false;
            if (this.XlogQuantity != input.XlogQuantity || (this.XlogQuantity != null && !this.XlogQuantity.Equals(input.XlogQuantity))) return false;
            if (this.Datnames != input.Datnames || (this.Datnames != null && input.Datnames != null && !this.Datnames.SequenceEqual(input.Datnames))) return false;
            if (this.Usenames != input.Usenames || (this.Usenames != null && input.Usenames != null && !this.Usenames.SequenceEqual(input.Usenames))) return false;
            if (this.ClientAddrs != input.ClientAddrs || (this.ClientAddrs != null && input.ClientAddrs != null && !this.ClientAddrs.SequenceEqual(input.ClientAddrs))) return false;

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
                if (this.ExecTime != null) hashCode = hashCode * 59 + this.ExecTime.GetHashCode();
                if (this.XlogQuantity != null) hashCode = hashCode * 59 + this.XlogQuantity.GetHashCode();
                if (this.Datnames != null) hashCode = hashCode * 59 + this.Datnames.GetHashCode();
                if (this.Usenames != null) hashCode = hashCode * 59 + this.Usenames.GetHashCode();
                if (this.ClientAddrs != null) hashCode = hashCode * 59 + this.ClientAddrs.GetHashCode();
                return hashCode;
            }
        }
    }
}
