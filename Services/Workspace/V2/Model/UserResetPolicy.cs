using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 用户重置策略。
    /// </summary>
    public class UserResetPolicy 
    {

        /// <summary>
        /// 开关
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 用户每天自动重试次数,重置次数每天0点刷新。
        /// </summary>
        [JsonProperty("reset_count_per_day", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResetCountPerDay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserResetPolicy {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  resetCountPerDay: ").Append(ResetCountPerDay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserResetPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserResetPolicy input)
        {
            if (input == null) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.ResetCountPerDay != input.ResetCountPerDay || (this.ResetCountPerDay != null && !this.ResetCountPerDay.Equals(input.ResetCountPerDay))) return false;

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
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.ResetCountPerDay != null) hashCode = hashCode * 59 + this.ResetCountPerDay.GetHashCode();
                return hashCode;
            }
        }
    }
}
