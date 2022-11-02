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
    /// This is a auto create Body Object
    /// </summary>
    public class RegisterServerMonitorRequestBody 
    {

        /// <summary>
        /// 注册云服务器监控。
        /// </summary>
        [JsonProperty("monitorMetrics", NullValueHandling = NullValueHandling.Ignore)]
        public string MonitorMetrics { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterServerMonitorRequestBody {\n");
            sb.Append("  monitorMetrics: ").Append(MonitorMetrics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegisterServerMonitorRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegisterServerMonitorRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MonitorMetrics == input.MonitorMetrics ||
                    (this.MonitorMetrics != null &&
                    this.MonitorMetrics.Equals(input.MonitorMetrics))
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
                if (this.MonitorMetrics != null)
                    hashCode = hashCode * 59 + this.MonitorMetrics.GetHashCode();
                return hashCode;
            }
        }
    }
}
