using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 批量添加member请求参数。
    /// </summary>
    public class BatchUpdateMembersOption 
    {

        /// <summary>
        /// 后端服务器ID。 &gt;此处并非ECS服务器的ID，而是ELB为绑定的后端服务器自动生成的member ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 参数解释：后端服务器的可用区。 约束限制：  仅支持iptarget类型的后端服务器设置该字段。且后端服务器组开启可用区亲和时，iptarget类型的后端服务器必须配置该字段为有效非空值。 取值范围：本region中ECS可选择的可用区。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 后端服务器的管理状态。取值：true、false。  虽然创建、更新请求支持该字段，但实际取值决定于后端服务器对应的弹性云服务器是否存在。若存在，该值为true，否则，该值为false。  请勿传入该字段。
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 后端服务器名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 后端服务器端口。  在开启端口透传的pool下的member，该字段无法更新。  [网关型LB，即pool协议为IP时，protocol_port必须设置为0。](tag:hws_eu)
        /// </summary>
        [JsonProperty("protocol_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProtocolPort { get; set; }

        /// <summary>
        /// 后端服务器的权重，请求按权重在同一后端服务器组下的后端服务器间分发。权重为0的后端不再接受新的请求。当后端服务器所在的后端服务器组的lb_algorithm的取值为SOURCE_IP时，该字段无效。
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdateMembersOption {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  protocolPort: ").Append(ProtocolPort).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdateMembersOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdateMembersOption input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProtocolPort != input.ProtocolPort || (this.ProtocolPort != null && !this.ProtocolPort.Equals(input.ProtocolPort))) return false;
            if (this.Weight != input.Weight || (this.Weight != null && !this.Weight.Equals(input.Weight))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProtocolPort != null) hashCode = hashCode * 59 + this.ProtocolPort.GetHashCode();
                if (this.Weight != null) hashCode = hashCode * 59 + this.Weight.GetHashCode();
                return hashCode;
            }
        }
    }
}
