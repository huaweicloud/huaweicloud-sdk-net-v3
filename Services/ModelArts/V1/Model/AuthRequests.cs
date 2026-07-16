using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AuthRequests 
    {

        /// <summary>
        /// **参数解释**：随机UUID，用来定位使用。 **取值范围**不涉及。
        /// </summary>
        [JsonProperty("action_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionId { get; set; }

        /// <summary>
        /// **参数解释**：细粒度action。 **取值范围**不涉及。
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// **参数解释**：资源。 **取值范围**不涉及。
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public string Resource { get; set; }

        /// <summary>
        /// **参数解释**：操作对象。 **取值范围**不涉及。
        /// </summary>
        [JsonProperty("service_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ServiceAttributes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthRequests {\n");
            sb.Append("  actionId: ").Append(ActionId).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  serviceAttributes: ").Append(ServiceAttributes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuthRequests);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AuthRequests input)
        {
            if (input == null) return false;
            if (this.ActionId != input.ActionId || (this.ActionId != null && !this.ActionId.Equals(input.ActionId))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.Resource != input.Resource || (this.Resource != null && !this.Resource.Equals(input.Resource))) return false;
            if (this.ServiceAttributes != input.ServiceAttributes || (this.ServiceAttributes != null && input.ServiceAttributes != null && !this.ServiceAttributes.SequenceEqual(input.ServiceAttributes))) return false;

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
                if (this.ActionId != null) hashCode = hashCode * 59 + this.ActionId.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.ServiceAttributes != null) hashCode = hashCode * 59 + this.ServiceAttributes.GetHashCode();
                return hashCode;
            }
        }
    }
}
