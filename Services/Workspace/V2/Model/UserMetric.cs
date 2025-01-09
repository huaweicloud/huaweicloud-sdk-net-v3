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
    /// 
    /// </summary>
    public class UserMetric 
    {

        /// <summary>
        /// 用户名称
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// 桌面使用统计信息 * &#x60;user_usage&#x60; -  用户使用时长(单位:秒)，同一时间登录多台PC的话;相应的时间会累加 * &#x60;user_login_count&#x60; -  用户登录次数(单位:次) * &#x60;user_login_success_count&#x60; -  用户登录成功次数(单位:次) * &#x60;user_login_fail_count&#x60; -  用户登录失败次数(单位:次)
        /// </summary>
        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public List<Metric> Metric { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserMetric {\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  metric: ").Append(Metric).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserMetric);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserMetric input)
        {
            if (input == null) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.Metric != input.Metric || (this.Metric != null && input.Metric != null && !this.Metric.SequenceEqual(input.Metric))) return false;

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
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Metric != null) hashCode = hashCode * 59 + this.Metric.GetHashCode();
                return hashCode;
            }
        }
    }
}
