using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAlarmConfigResponse : SdkResponse
    {

        /// <summary>
        /// 告警配置列表
        /// </summary>
        [JsonProperty("alarm_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmConfig> AlarmConfigs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public Object Data { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAlarmConfigResponse {\n");
            sb.Append("  alarmConfigs: ").Append(AlarmConfigs).Append("\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAlarmConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAlarmConfigResponse input)
        {
            if (input == null) return false;
            if (this.AlarmConfigs != input.AlarmConfigs || (this.AlarmConfigs != null && input.AlarmConfigs != null && !this.AlarmConfigs.SequenceEqual(input.AlarmConfigs))) return false;
            if (this.Data != input.Data || (this.Data != null && !this.Data.Equals(input.Data))) return false;

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
                if (this.AlarmConfigs != null) hashCode = hashCode * 59 + this.AlarmConfigs.GetHashCode();
                if (this.Data != null) hashCode = hashCode * 59 + this.Data.GetHashCode();
                return hashCode;
            }
        }
    }
}
