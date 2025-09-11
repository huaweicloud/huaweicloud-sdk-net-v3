using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SessionStatisticsBean 
    {

        /// <summary>
        /// 活跃SESSION数量
        /// </summary>
        [JsonProperty("active_session_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? ActiveSessionNum { get; set; }

        /// <summary>
        /// 失败SESSION数量
        /// </summary>
        [JsonProperty("fail_session_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? FailSessionNum { get; set; }

        /// <summary>
        /// 新增SESSION数量
        /// </summary>
        [JsonProperty("new_session_num", NullValueHandling = NullValueHandling.Ignore)]
        public long? NewSessionNum { get; set; }

        /// <summary>
        /// 周期
        /// </summary>
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public string Period { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionStatisticsBean {\n");
            sb.Append("  activeSessionNum: ").Append(ActiveSessionNum).Append("\n");
            sb.Append("  failSessionNum: ").Append(FailSessionNum).Append("\n");
            sb.Append("  newSessionNum: ").Append(NewSessionNum).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SessionStatisticsBean);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SessionStatisticsBean input)
        {
            if (input == null) return false;
            if (this.ActiveSessionNum != input.ActiveSessionNum || (this.ActiveSessionNum != null && !this.ActiveSessionNum.Equals(input.ActiveSessionNum))) return false;
            if (this.FailSessionNum != input.FailSessionNum || (this.FailSessionNum != null && !this.FailSessionNum.Equals(input.FailSessionNum))) return false;
            if (this.NewSessionNum != input.NewSessionNum || (this.NewSessionNum != null && !this.NewSessionNum.Equals(input.NewSessionNum))) return false;
            if (this.Period != input.Period || (this.Period != null && !this.Period.Equals(input.Period))) return false;

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
                if (this.ActiveSessionNum != null) hashCode = hashCode * 59 + this.ActiveSessionNum.GetHashCode();
                if (this.FailSessionNum != null) hashCode = hashCode * 59 + this.FailSessionNum.GetHashCode();
                if (this.NewSessionNum != null) hashCode = hashCode * 59 + this.NewSessionNum.GetHashCode();
                if (this.Period != null) hashCode = hashCode * 59 + this.Period.GetHashCode();
                return hashCode;
            }
        }
    }
}
