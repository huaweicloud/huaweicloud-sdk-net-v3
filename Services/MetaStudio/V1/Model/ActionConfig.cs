using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 动作编排配置。
    /// </summary>
    public class ActionConfig 
    {

        /// <summary>
        /// 算法自动插入无语义动作的时间间隔。这个参数填0或者不填默认是间隔4秒，设置成255时不自动插入无语义动作。
        /// </summary>
        [JsonProperty("action_interval", NullValueHandling = NullValueHandling.Ignore)]
        public float? ActionInterval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionConfig {\n");
            sb.Append("  actionInterval: ").Append(ActionInterval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ActionConfig input)
        {
            if (input == null) return false;
            if (this.ActionInterval != input.ActionInterval || (this.ActionInterval != null && !this.ActionInterval.Equals(input.ActionInterval))) return false;

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
                if (this.ActionInterval != null) hashCode = hashCode * 59 + this.ActionInterval.GetHashCode();
                return hashCode;
            }
        }
    }
}
