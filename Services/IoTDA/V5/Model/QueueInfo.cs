using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 添加时队列结构体。
    /// </summary>
    public class QueueInfo 
    {

        /// <summary>
        /// **参数说明**：队列名称，同一租户不允许重复。 **取值范围**：长度不低于8不超过128，只允许字母、数字、下划线（_）、连接符（-）、间隔号（.）、冒号（:）的组合。
        /// </summary>
        [JsonProperty("queue_name", NullValueHandling = NullValueHandling.Ignore)]
        public string QueueName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueInfo {\n");
            sb.Append("  queueName: ").Append(QueueName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueueInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueueInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QueueName == input.QueueName ||
                    (this.QueueName != null &&
                    this.QueueName.Equals(input.QueueName))
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
                if (this.QueueName != null)
                    hashCode = hashCode * 59 + this.QueueName.GetHashCode();
                return hashCode;
            }
        }
    }
}
