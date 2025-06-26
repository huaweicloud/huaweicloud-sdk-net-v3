using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TriggerSetting 
    {

        /// <summary>
        /// 定时设置，cron格式描述 &#39;* * * * * *&#39;。cron 基于 UTC 时间。
        /// </summary>
        [JsonProperty("cron", NullValueHandling = NullValueHandling.Ignore)]
        public string Cron { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TriggerSetting {\n");
            sb.Append("  cron: ").Append(Cron).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TriggerSetting);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TriggerSetting input)
        {
            if (input == null) return false;
            if (this.Cron != input.Cron || (this.Cron != null && !this.Cron.Equals(input.Cron))) return false;

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
                if (this.Cron != null) hashCode = hashCode * 59 + this.Cron.GetHashCode();
                return hashCode;
            }
        }
    }
}
