using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PostPaidServerPublicip 
    {

        /// <summary>
        /// 为待创建云服务器分配已有弹性IP时，分配的弹性IP的ID，UUID格式。  约束：只能分配状态（status）为DOWN的弹性IP。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("eip", NullValueHandling = NullValueHandling.Ignore)]
        public PostPaidServerEip Eip { get; set; }

        /// <summary>
        /// 弹性公网IP随实例释放策略。  true：弹性公网IP随实例释放。 false：弹性公网IP不随实例释放。 默认值：false。
        /// </summary>
        [JsonProperty("delete_on_termination", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteOnTermination { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostPaidServerPublicip {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  eip: ").Append(Eip).Append("\n");
            sb.Append("  deleteOnTermination: ").Append(DeleteOnTermination).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PostPaidServerPublicip);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PostPaidServerPublicip input)
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
                ) && 
                (
                    this.DeleteOnTermination == input.DeleteOnTermination ||
                    (this.DeleteOnTermination != null &&
                    this.DeleteOnTermination.Equals(input.DeleteOnTermination))
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
                if (this.DeleteOnTermination != null)
                    hashCode = hashCode * 59 + this.DeleteOnTermination.GetHashCode();
                return hashCode;
            }
        }
    }
}
