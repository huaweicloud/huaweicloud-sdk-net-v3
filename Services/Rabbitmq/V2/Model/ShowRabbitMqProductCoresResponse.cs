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
    /// Response Object
    /// </summary>
    public class ShowRabbitMqProductCoresResponse : SdkResponse
    {

        /// <summary>
        /// 产品规格核数。
        /// </summary>
        [JsonProperty("core_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CoreNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRabbitMqProductCoresResponse {\n");
            sb.Append("  coreNum: ").Append(CoreNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRabbitMqProductCoresResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRabbitMqProductCoresResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CoreNum == input.CoreNum ||
                    (this.CoreNum != null &&
                    this.CoreNum.Equals(input.CoreNum))
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
                if (this.CoreNum != null)
                    hashCode = hashCode * 59 + this.CoreNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
