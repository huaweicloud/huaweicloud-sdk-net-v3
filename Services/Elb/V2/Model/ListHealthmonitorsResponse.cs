using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListHealthmonitorsResponse : SdkResponse
    {

        /// <summary>
        /// 健康检查对象的列表
        /// </summary>
        [JsonProperty("healthmonitors", NullValueHandling = NullValueHandling.Ignore)]
        public List<HealthmonitorResp> Healthmonitors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHealthmonitorsResponse {\n");
            sb.Append("  healthmonitors: ").Append(Healthmonitors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHealthmonitorsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHealthmonitorsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Healthmonitors == input.Healthmonitors ||
                    this.Healthmonitors != null &&
                    input.Healthmonitors != null &&
                    this.Healthmonitors.SequenceEqual(input.Healthmonitors)
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
                if (this.Healthmonitors != null)
                    hashCode = hashCode * 59 + this.Healthmonitors.GetHashCode();
                return hashCode;
            }
        }
    }
}
