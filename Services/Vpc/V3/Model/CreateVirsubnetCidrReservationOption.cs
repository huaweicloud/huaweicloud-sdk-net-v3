using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateVirsubnetCidrReservationOption 
    {

        /// <summary>
        /// **参数解释**： 子网预留网段所属的子网ID。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("virsubnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VirsubnetId { get; set; }

        /// <summary>
        /// **参数解释**： 子网预留网段的IP版本，支持IPv4和IPv6。 **约束限制**： 不涉及。 **取值范围**： - 4：表示IPv4。 - 6：表示IPv6。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }

        /// <summary>
        /// **参数解释**： 子网预留网段的IP网段。 **约束限制**： - CIDR格式，掩码长度最小值为“所属子网的网段掩码 + 2”，最大值为32（IPv4）或128（IPv6）。 - cidr和mask参数必须输入一个，两者同时输入时不能冲突。 - 子网预留网段不能包含所属子网的已使用的地址和系统预留地址（子网的第1个和最后2个地址）。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        /// <summary>
        /// **参数解释**： 子网预留网段的IP网段掩码长度。 **约束限制**： - 整数，预留网段的掩码长度最小值为“所属子网的网段掩码 + 2”，最大值为32（IPv4）或128（IPv6）。 - cidr和mask参数必须输入一个，两者同时输入时不能冲突。 - 子网预留网段不能包含所属子网的已使用的地址和系统预留地址（子网的第1个和最后2个地址）。 - 指定掩码长度创建预留网段，最后mask与子网掩码的差值长度的bit位由系统自动分配，例如子网cidr为192.168.21.0/24，子网掩码长度24，指定预留网段长度为27，差值长度27 - 24 &#x3D; 3，即第25,26,27这3个bit位由系统自动分配。例如：   - 第25-27的bit位分配为011，最终创建出的子网预留网段cidr是192.168.21.96/27，其中96转为二进制是0110 0000；   - 第25-27的bit位分配为110，最终创建出的子网预留网段cidr是192.168.21.192/27，其中192转为二进制是1100 0000。  **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("mask", NullValueHandling = NullValueHandling.Ignore)]
        public int? Mask { get; set; }

        /// <summary>
        /// **参数解释**： 子网预留网段的名称。 **约束限制**： 1-64个字符，支持数字、字母、中文、_(下划线)、-（中划线）、.（点）。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 子网预留网段的描述信息。 **约束限制**： 0-255个字符，不能包含“&lt;”和“&gt;”。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVirsubnetCidrReservationOption {\n");
            sb.Append("  virsubnetId: ").Append(VirsubnetId).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  mask: ").Append(Mask).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateVirsubnetCidrReservationOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateVirsubnetCidrReservationOption input)
        {
            if (input == null) return false;
            if (this.VirsubnetId != input.VirsubnetId || (this.VirsubnetId != null && !this.VirsubnetId.Equals(input.VirsubnetId))) return false;
            if (this.IpVersion != input.IpVersion || (this.IpVersion != null && !this.IpVersion.Equals(input.IpVersion))) return false;
            if (this.Cidr != input.Cidr || (this.Cidr != null && !this.Cidr.Equals(input.Cidr))) return false;
            if (this.Mask != input.Mask || (this.Mask != null && !this.Mask.Equals(input.Mask))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.VirsubnetId != null) hashCode = hashCode * 59 + this.VirsubnetId.GetHashCode();
                if (this.IpVersion != null) hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.Cidr != null) hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.Mask != null) hashCode = hashCode * 59 + this.Mask.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
