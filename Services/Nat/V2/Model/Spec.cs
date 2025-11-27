using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Spec 
    {

        /// <summary>
        /// 规格名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 规格编号。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 规格cbc编码。
        /// </summary>
        [JsonProperty("cbc_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CbcCode { get; set; }

        /// <summary>
        /// 最大规则数。
        /// </summary>
        [JsonProperty("rule_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? RuleMax { get; set; }

        /// <summary>
        /// 最大连接数。
        /// </summary>
        [JsonProperty("sess_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? SessMax { get; set; }

        /// <summary>
        /// 最大bps。
        /// </summary>
        [JsonProperty("bps_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? BpsMax { get; set; }

        /// <summary>
        /// 最大pps。
        /// </summary>
        [JsonProperty("pps_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? PpsMax { get; set; }

        /// <summary>
        /// 最大qps。
        /// </summary>
        [JsonProperty("qps_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? QpsMax { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Spec {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  cbcCode: ").Append(CbcCode).Append("\n");
            sb.Append("  ruleMax: ").Append(RuleMax).Append("\n");
            sb.Append("  sessMax: ").Append(SessMax).Append("\n");
            sb.Append("  bpsMax: ").Append(BpsMax).Append("\n");
            sb.Append("  ppsMax: ").Append(PpsMax).Append("\n");
            sb.Append("  qpsMax: ").Append(QpsMax).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Spec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Spec input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.CbcCode != input.CbcCode || (this.CbcCode != null && !this.CbcCode.Equals(input.CbcCode))) return false;
            if (this.RuleMax != input.RuleMax || (this.RuleMax != null && !this.RuleMax.Equals(input.RuleMax))) return false;
            if (this.SessMax != input.SessMax || (this.SessMax != null && !this.SessMax.Equals(input.SessMax))) return false;
            if (this.BpsMax != input.BpsMax || (this.BpsMax != null && !this.BpsMax.Equals(input.BpsMax))) return false;
            if (this.PpsMax != input.PpsMax || (this.PpsMax != null && !this.PpsMax.Equals(input.PpsMax))) return false;
            if (this.QpsMax != input.QpsMax || (this.QpsMax != null && !this.QpsMax.Equals(input.QpsMax))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.CbcCode != null) hashCode = hashCode * 59 + this.CbcCode.GetHashCode();
                if (this.RuleMax != null) hashCode = hashCode * 59 + this.RuleMax.GetHashCode();
                if (this.SessMax != null) hashCode = hashCode * 59 + this.SessMax.GetHashCode();
                if (this.BpsMax != null) hashCode = hashCode * 59 + this.BpsMax.GetHashCode();
                if (this.PpsMax != null) hashCode = hashCode * 59 + this.PpsMax.GetHashCode();
                if (this.QpsMax != null) hashCode = hashCode * 59 + this.QpsMax.GetHashCode();
                return hashCode;
            }
        }
    }
}
