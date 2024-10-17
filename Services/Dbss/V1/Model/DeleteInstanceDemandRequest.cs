using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteInstanceDemandRequest 
    {

        /// <summary>
        /// 实例ID。可在查询实例列表接口的ID字段获取。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 是否删除弹性IP
        /// </summary>
        [JsonProperty("delete_publicip", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeletePublicip { get; set; }

        /// <summary>
        /// 是否删除磁盘
        /// </summary>
        [JsonProperty("delete_volume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteVolume { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteInstanceDemandRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  deletePublicip: ").Append(DeletePublicip).Append("\n");
            sb.Append("  deleteVolume: ").Append(DeleteVolume).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteInstanceDemandRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteInstanceDemandRequest input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DeletePublicip != input.DeletePublicip || (this.DeletePublicip != null && !this.DeletePublicip.Equals(input.DeletePublicip))) return false;
            if (this.DeleteVolume != input.DeleteVolume || (this.DeleteVolume != null && !this.DeleteVolume.Equals(input.DeleteVolume))) return false;

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
                if (this.DeletePublicip != null) hashCode = hashCode * 59 + this.DeletePublicip.GetHashCode();
                if (this.DeleteVolume != null) hashCode = hashCode * 59 + this.DeleteVolume.GetHashCode();
                return hashCode;
            }
        }
    }
}
