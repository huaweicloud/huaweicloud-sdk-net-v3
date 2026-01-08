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
    /// 
    /// </summary>
    public class HbaHistoryResult 
    {

        /// <summary>
        /// **参数解释**: 客户端接入认证修改记录的ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**: 修改结果。 **取值范围**:  - success：已生效。  - failed：未生效。  - etting：设置中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**: 修改时间。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// **参数解释**: 修改失败原因。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("fail_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailReason { get; set; }

        /// <summary>
        /// **参数解释**: 修改之前的值。
        /// </summary>
        [JsonProperty("before_confs", NullValueHandling = NullValueHandling.Ignore)]
        public List<HbaConfResult> BeforeConfs { get; set; }

        /// <summary>
        /// **参数解释**: 修改之后的值。
        /// </summary>
        [JsonProperty("after_confs", NullValueHandling = NullValueHandling.Ignore)]
        public List<HbaConfResult> AfterConfs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HbaHistoryResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  failReason: ").Append(FailReason).Append("\n");
            sb.Append("  beforeConfs: ").Append(BeforeConfs).Append("\n");
            sb.Append("  afterConfs: ").Append(AfterConfs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HbaHistoryResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HbaHistoryResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.FailReason != input.FailReason || (this.FailReason != null && !this.FailReason.Equals(input.FailReason))) return false;
            if (this.BeforeConfs != input.BeforeConfs || (this.BeforeConfs != null && input.BeforeConfs != null && !this.BeforeConfs.SequenceEqual(input.BeforeConfs))) return false;
            if (this.AfterConfs != input.AfterConfs || (this.AfterConfs != null && input.AfterConfs != null && !this.AfterConfs.SequenceEqual(input.AfterConfs))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.FailReason != null) hashCode = hashCode * 59 + this.FailReason.GetHashCode();
                if (this.BeforeConfs != null) hashCode = hashCode * 59 + this.BeforeConfs.GetHashCode();
                if (this.AfterConfs != null) hashCode = hashCode * 59 + this.AfterConfs.GetHashCode();
                return hashCode;
            }
        }
    }
}
