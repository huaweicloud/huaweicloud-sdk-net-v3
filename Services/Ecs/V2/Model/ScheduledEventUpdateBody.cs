using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 修改计划事件计划执行开始时间
    /// </summary>
    public class ScheduledEventUpdateBody 
    {

        /// <summary>
        /// 计划执行开始时间，新的开始时间必须早于not_before_deadline
        /// </summary>
        [JsonProperty("not_before", NullValueHandling = NullValueHandling.Ignore)]
        public string NotBefore { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduledEventUpdateBody {\n");
            sb.Append("  notBefore: ").Append(NotBefore).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduledEventUpdateBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScheduledEventUpdateBody input)
        {
            if (input == null) return false;
            if (this.NotBefore != input.NotBefore || (this.NotBefore != null && !this.NotBefore.Equals(input.NotBefore))) return false;

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
                if (this.NotBefore != null) hashCode = hashCode * 59 + this.NotBefore.GetHashCode();
                return hashCode;
            }
        }
    }
}
