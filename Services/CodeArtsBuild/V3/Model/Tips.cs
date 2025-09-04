using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 资讯
    /// </summary>
    public class Tips 
    {

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 下一个活动日
        /// </summary>
        [JsonProperty("next_action", NullValueHandling = NullValueHandling.Ignore)]
        public int? NextAction { get; set; }

        /// <summary>
        /// 下一个活动日剩余时间
        /// </summary>
        [JsonProperty("next_action_remain_day", NullValueHandling = NullValueHandling.Ignore)]
        public int? NextActionRemainDay { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("next_action_url", NullValueHandling = NullValueHandling.Ignore)]
        public string NextActionUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tips {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  nextAction: ").Append(NextAction).Append("\n");
            sb.Append("  nextActionRemainDay: ").Append(NextActionRemainDay).Append("\n");
            sb.Append("  nextActionUrl: ").Append(NextActionUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Tips);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Tips input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.NextAction != input.NextAction || (this.NextAction != null && !this.NextAction.Equals(input.NextAction))) return false;
            if (this.NextActionRemainDay != input.NextActionRemainDay || (this.NextActionRemainDay != null && !this.NextActionRemainDay.Equals(input.NextActionRemainDay))) return false;
            if (this.NextActionUrl != input.NextActionUrl || (this.NextActionUrl != null && !this.NextActionUrl.Equals(input.NextActionUrl))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.NextAction != null) hashCode = hashCode * 59 + this.NextAction.GetHashCode();
                if (this.NextActionRemainDay != null) hashCode = hashCode * 59 + this.NextActionRemainDay.GetHashCode();
                if (this.NextActionUrl != null) hashCode = hashCode * 59 + this.NextActionUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
