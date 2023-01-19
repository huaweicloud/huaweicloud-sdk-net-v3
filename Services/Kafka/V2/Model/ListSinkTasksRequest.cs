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
    /// Request Object
    /// </summary>
    public class ListSinkTasksRequest 
    {

        /// <summary>
        /// 实例转储ID。 请参考[实例生命周期][查询实例]接口返回的数据。
        /// </summary>
        [SDKProperty("connector_id", IsPath = true)]
        [JsonProperty("connector_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectorId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSinkTasksRequest {\n");
            sb.Append("  connectorId: ").Append(ConnectorId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSinkTasksRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSinkTasksRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConnectorId == input.ConnectorId ||
                    (this.ConnectorId != null &&
                    this.ConnectorId.Equals(input.ConnectorId))
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
                if (this.ConnectorId != null)
                    hashCode = hashCode * 59 + this.ConnectorId.GetHashCode();
                return hashCode;
            }
        }
    }
}
