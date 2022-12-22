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
    /// 批量创建后端服务器响应结果
    /// </summary>
    public class BatchDeleteMembersState 
    {

        /// <summary>
        /// 后端服务器ID。  &gt;说明： 此处并非ECS服务器的ID，而是ELB为绑定的后端服务器自动生成的member ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 当前后端服务器删除结果状态。  取值： - successful：删除成功。 - not found：member不存在。
        /// </summary>
        [JsonProperty("ret_status", NullValueHandling = NullValueHandling.Ignore)]
        public string RetStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteMembersState {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  retStatus: ").Append(RetStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteMembersState);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteMembersState input)
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
                    this.RetStatus == input.RetStatus ||
                    (this.RetStatus != null &&
                    this.RetStatus.Equals(input.RetStatus))
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
                if (this.RetStatus != null)
                    hashCode = hashCode * 59 + this.RetStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
