using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AdvancedIpsRuleDto 
    {

        /// <summary>
        /// 动作：0表示仅记录日志、1表示拦截session、2表示拦截ip
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public int? Action { get; set; }

        /// <summary>
        /// 高级ips规则id
        /// </summary>
        [JsonProperty("ips_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IpsRuleId { get; set; }

        /// <summary>
        /// ips规则类型：0表示敏感目录扫描、1表示反弹xshell
        /// </summary>
        [JsonProperty("ips_rule_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpsRuleType { get; set; }

        /// <summary>
        /// 防护对象id
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 包含特殊参数的JSON字符串
        /// </summary>
        [JsonProperty("param", NullValueHandling = NullValueHandling.Ignore)]
        public string Param { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedIpsRuleDto {\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  ipsRuleId: ").Append(IpsRuleId).Append("\n");
            sb.Append("  ipsRuleType: ").Append(IpsRuleType).Append("\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  param: ").Append(Param).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdvancedIpsRuleDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdvancedIpsRuleDto input)
        {
            if (input == null) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.IpsRuleId != input.IpsRuleId || (this.IpsRuleId != null && !this.IpsRuleId.Equals(input.IpsRuleId))) return false;
            if (this.IpsRuleType != input.IpsRuleType || (this.IpsRuleType != null && !this.IpsRuleType.Equals(input.IpsRuleType))) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.Param != input.Param || (this.Param != null && !this.Param.Equals(input.Param))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.IpsRuleId != null) hashCode = hashCode * 59 + this.IpsRuleId.GetHashCode();
                if (this.IpsRuleType != null) hashCode = hashCode * 59 + this.IpsRuleType.GetHashCode();
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.Param != null) hashCode = hashCode * 59 + this.Param.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
