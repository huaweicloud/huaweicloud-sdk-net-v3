using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class AssociateInstanceRequest 
    {

        /// <summary>
        /// 绑定接口可以加，标识请求是从哪个服务调过来的
        /// </summary>
        [SDKProperty("binding-instance-service", IsHeader = true)]
        [JsonProperty("binding-instance-service", NullValueHandling = NullValueHandling.Ignore)]
        public string BindingInstanceService { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("global_eip_id", IsPath = true)]
        [JsonProperty("global_eip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalEipId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public AssociateInstanceGlobalEipRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateInstanceRequest {\n");
            sb.Append("  bindingInstanceService: ").Append(BindingInstanceService).Append("\n");
            sb.Append("  globalEipId: ").Append(GlobalEipId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateInstanceRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateInstanceRequest input)
        {
            if (input == null) return false;
            if (this.BindingInstanceService != input.BindingInstanceService || (this.BindingInstanceService != null && !this.BindingInstanceService.Equals(input.BindingInstanceService))) return false;
            if (this.GlobalEipId != input.GlobalEipId || (this.GlobalEipId != null && !this.GlobalEipId.Equals(input.GlobalEipId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.BindingInstanceService != null) hashCode = hashCode * 59 + this.BindingInstanceService.GetHashCode();
                if (this.GlobalEipId != null) hashCode = hashCode * 59 + this.GlobalEipId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
