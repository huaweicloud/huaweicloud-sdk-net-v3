using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// publicip字段数据结构说明
    /// </summary>
    public class PublicIp 
    {

        /// <summary>
        /// 创建裸金属服务器分配已有弹性公网IP时，分配的弹性公网IP的ID，UUID格式。弹性公网IP的ID可以从网络控制台或者参考《虚拟私有云API参考》的“查询弹性公网IP列表”章节获取。约束：只能分配状态（status）为DOWN的弹性公网IP。批量创建裸金属服务器时，不能使用已有弹性公网IP，即不支持此参数。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("eip", NullValueHandling = NullValueHandling.Ignore)]
        public Eip Eip { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicIp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  eip: ").Append(Eip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicIp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublicIp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Eip == input.Eip ||
                    (this.Eip != null &&
                    this.Eip.Equals(input.Eip))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Eip != null)
                    hashCode = hashCode * 59 + this.Eip.GetHashCode();
                return hashCode;
            }
        }
    }
}
