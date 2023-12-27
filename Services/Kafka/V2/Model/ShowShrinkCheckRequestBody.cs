using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowShrinkCheckRequestBody 
    {

        /// <summary>
        /// 缩容后集群节点数
        /// </summary>
        [JsonProperty("new_broker_num", NullValueHandling = NullValueHandling.Ignore)]
        public string NewBrokerNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowShrinkCheckRequestBody {\n");
            sb.Append("  newBrokerNum: ").Append(NewBrokerNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowShrinkCheckRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowShrinkCheckRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewBrokerNum == input.NewBrokerNum ||
                    (this.NewBrokerNum != null &&
                    this.NewBrokerNum.Equals(input.NewBrokerNum))
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
                if (this.NewBrokerNum != null)
                    hashCode = hashCode * 59 + this.NewBrokerNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
