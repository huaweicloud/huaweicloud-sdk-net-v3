using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rabbitmq.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowVhostDetailResp 
    {

        /// <summary>
        /// **参数解释**： Vhost名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 是否开启消息轨迹[（AMQP版本不涉及此字段）](tag:hws,hws_hk)。 **取值范围**： - true：开启。 - false：不开启
        /// </summary>
        [JsonProperty("tracing", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tracing { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowVhostDetailResp {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  tracing: ").Append(Tracing).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowVhostDetailResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowVhostDetailResp input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Tracing != input.Tracing || (this.Tracing != null && !this.Tracing.Equals(input.Tracing))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Tracing != null) hashCode = hashCode * 59 + this.Tracing.GetHashCode();
                return hashCode;
            }
        }
    }
}
