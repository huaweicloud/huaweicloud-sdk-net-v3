using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PolicyTriggerPropertiesReq 
    {

        /// <summary>
        /// 调度规则。限制24条规则。调度器的调度规则，可参照iCalendar RFC 2445规范中的事件规则，但仅支持FREQ、BYDAY、BYHOUR、BYMINUTE、INTERVAL等参数，其中FREQ仅支持WEEKLY和DAILY，BYDAY支持一周七天（MO、TU、WE、TH、FR、SA、SU），BYHOUR支持0-23小时，BYMINUTE支持0-59分钟，并且间隔不能小于一小时，一天最大24个时间点。例如，周一到周天，每天UTC时间的14:00调度，其规则为：&#39;FREQ&#x3D;WEEKLY;BYDAY&#x3D;MO,TU,WE,TH,FR,SA,SU;BYHOUR&#x3D;14;BYMINUTE&#x3D;00&#39;。例如：某个地区的时间为 UTC+8，若在该地区每天14:00调度，则在14点基础上减8，其规则为&#39;FREQ&#x3D;DAILY;INTERVAL&#x3D;1;BYHOUR&#x3D;6;BYMINUTE&#x3D;00&#39;。
        /// </summary>
        [JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Pattern { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyTriggerPropertiesReq {\n");
            sb.Append("  pattern: ").Append(Pattern).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyTriggerPropertiesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyTriggerPropertiesReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pattern == input.Pattern ||
                    this.Pattern != null &&
                    input.Pattern != null &&
                    this.Pattern.SequenceEqual(input.Pattern)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Pattern != null)
                    hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                return hashCode;
            }
        }
    }
}
