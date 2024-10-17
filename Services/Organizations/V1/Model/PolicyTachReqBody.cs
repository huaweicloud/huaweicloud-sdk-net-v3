using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// AttachPolicy 和 DetachPolicy 操作的请求体。
    /// </summary>
    public class PolicyTachReqBody 
    {

        /// <summary>
        /// 根、组织单元或账号的唯一标识符（ID）。
        /// </summary>
        [JsonProperty("entity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EntityId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyTachReqBody {\n");
            sb.Append("  entityId: ").Append(EntityId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyTachReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyTachReqBody input)
        {
            if (input == null) return false;
            if (this.EntityId != input.EntityId || (this.EntityId != null && !this.EntityId.Equals(input.EntityId))) return false;

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
                if (this.EntityId != null) hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                return hashCode;
            }
        }
    }
}
