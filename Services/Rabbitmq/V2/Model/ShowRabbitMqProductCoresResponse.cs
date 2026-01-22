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
        /// **参数解释**： 核数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("core_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? CoreNum { get; set; }

        /// <summary>
        /// **参数解释**： 预估存储空间，当填写的broker_num小于等于当前实例真实值时，显示为当前实例的存储空间。如果填写的broker_num大于当前实例真实值时，显示为所填写broker_num时实例的预估存储空间。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("total_extend_storage_space", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalExtendStorageSpace { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRabbitMqProductCoresResponse {\n");
            sb.Append("  coreNum: ").Append(CoreNum).Append("\n");
            sb.Append("  totalExtendStorageSpace: ").Append(TotalExtendStorageSpace).Append("\n");
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
            if (input == null) return false;
            if (this.CoreNum != input.CoreNum || (this.CoreNum != null && !this.CoreNum.Equals(input.CoreNum))) return false;
            if (this.TotalExtendStorageSpace != input.TotalExtendStorageSpace || (this.TotalExtendStorageSpace != null && !this.TotalExtendStorageSpace.Equals(input.TotalExtendStorageSpace))) return false;

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
                if (this.CoreNum != null) hashCode = hashCode * 59 + this.CoreNum.GetHashCode();
                if (this.TotalExtendStorageSpace != null) hashCode = hashCode * 59 + this.TotalExtendStorageSpace.GetHashCode();
                return hashCode;
            }
        }
    }
}
